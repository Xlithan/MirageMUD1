using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Shared.Models;

namespace Client.Forms
{
    internal enum MenuView
    {
        Main,
        Login,
        NewAccount,
        Characters,
        NewCharacter,
        IPConfig,
        GameOptions
    }

    /// <summary>
    /// Shows exactly one Panel at a time, tracks history for Back().
    /// </summary>
    internal sealed class PanelNavigator<TView> where TView : struct, Enum
    {
        private readonly Dictionary<TView, Panel> _map;
        private readonly Stack<TView> _history = new();
        private TView _current;

        public PanelNavigator(Dictionary<TView, Panel> map, TView initialView)
        {
            _map = map;
            _current = initialView;
            Show(initialView, recordHistory: false);
        }

        public TView Current => _current;

        public void Show(TView view) => Show(view, recordHistory: true);

        public void Back()
        {
            if (_history.Count == 0) return;
            var prev = _history.Pop();
            Show(prev, recordHistory: false);
        }

        public void ResetTo(TView view)
        {
            _history.Clear();
            Show(view, recordHistory: false);
        }

        private void Show(TView view, bool recordHistory)
        {
            if (EqualityComparer<TView>.Default.Equals(view, _current))
                return;

            if (recordHistory)
                _history.Push(_current);

            foreach (var kv in _map)
            {
                bool active = EqualityComparer<TView>.Default.Equals(kv.Key, view);
                var p = kv.Value;
                p.Visible = active;
                p.Enabled = active;
                if (active) p.BringToFront();
            }

            _current = view;
        }
    }

    public partial class MainMenuForm : Form
    {
        private PanelNavigator<MenuView> _nav = null!;
        private Label _lblServerStatus = null!;
        private System.Windows.Forms.Timer _statusTimer = null!;
        private int _statusTick = 0;
        private DateTime _lastPingAtUtc;
        private TimeSpan? _lastLatency;
        private bool _loginBusy;

        private sealed record CharItem(string Id, string Display)
        {
            public override string ToString() => Display;
        }

        private void ResetToMain()
        {
            _loginBusy = false;
            _nav.ResetTo(MenuView.Main);
            _lblServerStatus.BringToFront();
        }

        private string? GetSelectedCharId()
            => lstChars.SelectedItem is CharItem it ? it.Id : null;

        // call this from ctor after InitializeComponent()
        private void InitializeNavigation()
        {
            // Ensure form receives key events (for Esc = Back)
            KeyPreview = true;
            KeyDown += (_, e) =>
            {
                if (e.KeyCode != Keys.Escape) return;

                switch (_nav.Current)
                {
                    case MenuView.Login:
                    case MenuView.NewAccount:
                    case MenuView.Characters:
                        ResetToMain();
                        break;
                    case MenuView.Main:
                        Close();
                        break;
                    default:
                        _nav.Back();           // for other sub-screens
                        break;
                }
            };

            CreateServerStatusUi();

            _nav = new PanelNavigator<MenuView>(
                new Dictionary<MenuView, Panel>
                {
                    { MenuView.Main,         mnuMainMenu },
                    { MenuView.Login,        mnuLogin },
                    { MenuView.NewAccount,   mnuNewAccount },
                    { MenuView.Characters,   mnuChars },
                    { MenuView.NewCharacter, mnuNewCharacter },
                    { MenuView.IPConfig,     mnuIPConfig },
                    { MenuView.GameOptions,  mnuGameOptions }
                },
                initialView: MenuView.Main
            );

            // --- Main menu -> submenus ---
            AddNav(lblMainMenu_NewAccount, MenuView.NewAccount);
            AddNav(lblMainMenu_Login, MenuView.Login);
            AddNav(lblMainMenu_IPConfig, MenuView.IPConfig);
            AddNav(lblMainMenu_GameOptions, MenuView.GameOptions);
            AddAction(lblMainMenu_Exit, () => Close());

            // --- Cancel/Back labels ---
            AddAction(lblLoginCancel, ResetToMain);
            AddBack(lblNewAccountCancel);
            AddBack(lblIPConfigCancel);
            AddBack(lblGameOptionsCancel);
            AddNav(lblCharsCancel, MenuView.Main);          // characters back to main
            AddNav(lblNewCharCancel, MenuView.Characters);  // new-char back to chars

            // --- Characters menu actions (wire now; logic later) ---
            AddNav(lblCharsNew, MenuView.NewCharacter);
            // lblCharsUse -> proceed into game world (hook when ready)
            // lblCharsDelete -> confirm + server call

            // send login when the user clicks Connect on the Login panel
            AddAction(lblLoginConnect, async () => await LoginConnectAsync());

            // Double-click selects character
            lstChars.DoubleClick += async (_, __) => await UseSelectedCharacterAsync();

            // "Use Character"
            AddAction(lblCharsUse, async () => await UseSelectedCharacterAsync());

            // "Delete Character"
            AddAction(lblCharsDelete, async () =>
            {
                var id = GetSelectedCharId();
                if (id is null) return;
                if (MessageBox.Show(this, "Delete this character?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

                try
                {
                    await Client.Game.ClientGameLogic.DeleteCharacter(_client, id);
                    // Server will reply with a fresh SAllChars; the UI will update via ShowCharacters(...)
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, $"Failed to delete: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            // "New Character"
            AddNav(lblCharsNew, MenuView.NewCharacter);
        }

        private async Task UseSelectedCharacterAsync()
        {
            var id = GetSelectedCharId();
            if (id is null) return;

            try
            {
                await Client.Game.ClientGameLogic.UseCharacter(_client, id);
                // Server will reply with SInGame (and/or player data next)
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to use character: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNav(Label label, MenuView view)
            => BindLabel(label, () => { _nav.Show(view); _lblServerStatus.BringToFront(); });

        private void AddBack(Label label)
            => BindLabel(label, () => { _nav.Back(); _lblServerStatus.BringToFront(); });

        private void AddAction(Label label, Action onClick)
            => BindLabel(label, onClick);

        private void BindLabel(Label label, Action onClick)
        {
            if (label == null) return;

            label.Cursor = Cursors.Hand;
            var normal = Color.White;
            var hover = Color.Gold;

            label.MouseEnter += (_, __) => label.ForeColor = hover;
            label.MouseLeave += (_, __) => label.ForeColor = normal;
            label.Click += (_, __) => onClick();
        }

        // ===== public helpers the networking layer can call =====

        public void ShowLogin()
        {
            _nav.ResetTo(MenuView.Login);
            _lblServerStatus.BringToFront();
        }

        public void ShowCharacters(List<Shared.Models.CharacterSummary> characters)
        {
            _nav.ResetTo(MenuView.Characters);

            lstChars.BeginUpdate();
            try
            {
                lstChars.Items.Clear();
                foreach (var c in characters)
                    lstChars.Items.Add(new CharItem(
                        c.Id,
                        $"{c.Name} [{c.Class}] - Level: {c.Level}"
                    ));
            }
            finally { lstChars.EndUpdate(); }

            // (optional) auto-select first
            if (lstChars.Items.Count > 0) lstChars.SelectedIndex = 0;
            _lblServerStatus.BringToFront();
        }

        public void ShowLoginError(string message)
        {
            _nav.ResetTo(MenuView.Login);
            MessageBox.Show(this, message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CreateServerStatusUi()
        {
            _lblServerStatus = new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,        // solid background if you prefer: Color.Black
                ForeColor = Color.IndianRed,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font(Font.FontFamily, 8.5f, FontStyle.Regular),
                Text = "Server: Offline",
                Location = new Point(10, ClientSize.Height - 25),
                Size = new Size(200, 18),
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom
            };

            // Add to the FORM so it overlays all panels
            Controls.Add(_lblServerStatus);
            _lblServerStatus.BringToFront();

            _statusTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _statusTimer.Tick += async (_, __) =>
            {
                _statusTick++;

                // 1) socket state
                var online = _client.IsConnected;
                SetServerStatusLabel(online);

                // 2) optional ping every 10s
                if (online && _statusTick % 10 == 0)
                {
                    _lastPingAtUtc = DateTime.UtcNow;
                    try { await Client.Game.ClientGameLogic.SendSync(_client); } catch { /* ignore */ }
                }
            };
            _statusTimer.Start();

            FormClosed += (_, __) => _statusTimer.Stop();
        }
        private void SetServerStatusLabel(bool online)
        {
            var latency = _lastLatency is { } t ? $"  ({(int)t.TotalMilliseconds} ms)" : "";
            _lblServerStatus.Text = online ? $"Server: Online{latency}" : "Server: Offline";
            _lblServerStatus.ForeColor = online ? Color.LimeGreen : Color.IndianRed;
            _lblServerStatus.BackColor = Color.Transparent;
        }
        private bool IsClientConnected()
        {
            try { return _client?.IsConnected ?? false; }
            catch { return false; } // in case the client is disposing
        }
        internal void OnPong(DateTime nowUtc)
        {
            if (_lastPingAtUtc != default)
                _lastLatency = nowUtc - _lastPingAtUtc;

            SetServerStatusLabel(true);
            _lblServerStatus.BringToFront();
        }
        private async Task LoginConnectAsync()
        {
            if (_loginBusy) return;
            _loginBusy = true;

            try
            {
                var user = txtLoginName.Text.Trim();
                var pass = txtLoginPassword.Text;

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show(this, "Enter a username/email and password.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // If not connected, try once — if it fails, show ONE message and stop.
                if (!_client.IsConnected)
                {
                    var ok = await _client.TryConnectAsync(_config);
                    if (!ok)
                    {
                        ShowLoginError("Could not connect to server (offline).");
                        return;
                    }
                }

                // Connected: send login. If this fails, show ONE message.
                try
                {
                    await Client.Game.ClientGameLogic.SendLogin(_client, user, pass);
                }
                catch (Exception ex)
                {
                    // If the socket dropped between connect and send, prefer the offline message.
                    if (!_client.IsConnected)
                        ShowLoginError("Could not connect to server (offline).");
                    else
                        ShowLoginError($"Failed to send login: {ex.Message}");
                }
            }
            finally
            {
                _loginBusy = false;
            }
        }
    }
}