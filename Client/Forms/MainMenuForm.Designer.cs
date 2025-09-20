using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        // Panels replacing VB6 PictureBox menus
        private Panel mnuNewCharacter;
        private Panel mnuCredits;
        private Panel mnuNewAccount;
        private Panel mnuChars;
        private Panel mnuLogin;
        private Panel mnuIPConfig;
        private Panel mnuGameOptions;

        // Top-level main menu labels (the clickable options)
        private Label lblMainMenuT;
        private Label lblMainMenu_NewAccount;
        private Label lblMainMenu_Login;
        private Label lblMainMenu_IPConfig;
        private Label lblMainMenu_GameOptions;
        private Label lblMainMenu_Exit;
        private Label lblMainMenu_Credits;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            mnuNewCharacter = new Panel();
            mnuCredits = new Panel();
            mnuNewAccount = new Panel();
            mnuChars = new Panel();
            mnuLogin = new Panel();
            mnuIPConfig = new Panel();
            mnuGameOptions = new Panel();
            lblMainMenuT = new Label();
            lblMainMenu_NewAccount = new Label();
            lblMainMenu_Login = new Label();
            lblMainMenu_IPConfig = new Label();
            lblMainMenu_GameOptions = new Label();
            lblMainMenu_Exit = new Label();
            lblMainMenu_Credits = new Label();
            mnuNewCharacter.SuspendLayout();
            SuspendLayout();
            // 
            // mnuNewCharacter
            // 
            mnuNewCharacter.BackColor = Color.Black;
            mnuNewCharacter.BackgroundImage = (Image)resources.GetObject("mnuNewCharacter.BackgroundImage");
            mnuNewCharacter.BackgroundImageLayout = ImageLayout.None;
            mnuNewCharacter.Controls.Add(lblMainMenu_Credits);
            mnuNewCharacter.Controls.Add(lblMainMenuT);
            mnuNewCharacter.Controls.Add(lblMainMenu_NewAccount);
            mnuNewCharacter.Controls.Add(lblMainMenu_Exit);
            mnuNewCharacter.Controls.Add(lblMainMenu_Login);
            mnuNewCharacter.Controls.Add(lblMainMenu_GameOptions);
            mnuNewCharacter.Controls.Add(lblMainMenu_IPConfig);
            mnuNewCharacter.Location = new Point(0, 0);
            mnuNewCharacter.Name = "mnuNewCharacter";
            mnuNewCharacter.Size = new Size(500, 300);
            mnuNewCharacter.TabIndex = 7;
            mnuNewCharacter.Visible = false;
            // 
            // mnuCredits
            // 
            mnuCredits.BackColor = Color.Black;
            mnuCredits.BackgroundImage = (Image)resources.GetObject("mnuCredits.BackgroundImage");
            mnuCredits.Location = new Point(0, 0);
            mnuCredits.Name = "mnuCredits";
            mnuCredits.Size = new Size(500, 300);
            mnuCredits.TabIndex = 8;
            mnuCredits.Visible = false;
            // 
            // mnuNewAccount
            // 
            mnuNewAccount.BackColor = Color.Black;
            mnuNewAccount.BackgroundImage = (Image)resources.GetObject("mnuNewAccount.BackgroundImage");
            mnuNewAccount.Location = new Point(0, 0);
            mnuNewAccount.Name = "mnuNewAccount";
            mnuNewAccount.Size = new Size(500, 300);
            mnuNewAccount.TabIndex = 9;
            mnuNewAccount.Visible = false;
            // 
            // mnuChars
            // 
            mnuChars.BackColor = Color.Black;
            mnuChars.BackgroundImage = (Image)resources.GetObject("mnuChars.BackgroundImage");
            mnuChars.Location = new Point(0, 0);
            mnuChars.Name = "mnuChars";
            mnuChars.Size = new Size(500, 300);
            mnuChars.TabIndex = 10;
            mnuChars.Visible = false;
            // 
            // mnuLogin
            // 
            mnuLogin.BackColor = Color.Black;
            mnuLogin.BackgroundImage = (Image)resources.GetObject("mnuLogin.BackgroundImage");
            mnuLogin.Location = new Point(0, 0);
            mnuLogin.Name = "mnuLogin";
            mnuLogin.Size = new Size(500, 300);
            mnuLogin.TabIndex = 11;
            mnuLogin.Visible = false;
            // 
            // mnuIPConfig
            // 
            mnuIPConfig.BackColor = Color.Black;
            mnuIPConfig.BackgroundImage = (Image)resources.GetObject("mnuIPConfig.BackgroundImage");
            mnuIPConfig.Location = new Point(0, 0);
            mnuIPConfig.Name = "mnuIPConfig";
            mnuIPConfig.Size = new Size(500, 300);
            mnuIPConfig.TabIndex = 12;
            mnuIPConfig.Visible = false;
            // 
            // mnuGameOptions
            // 
            mnuGameOptions.BackColor = Color.Black;
            mnuGameOptions.BackgroundImage = (Image)resources.GetObject("mnuGameOptions.BackgroundImage");
            mnuGameOptions.Location = new Point(0, 0);
            mnuGameOptions.Name = "mnuGameOptions";
            mnuGameOptions.Size = new Size(500, 300);
            mnuGameOptions.TabIndex = 13;
            mnuGameOptions.Visible = false;
            // 
            // lblMainMenuT
            // 
            lblMainMenuT.BackColor = Color.Transparent;
            lblMainMenuT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblMainMenuT.ForeColor = Color.White;
            lblMainMenuT.Location = new Point(247, 18);
            lblMainMenuT.Name = "lblMainMenuT";
            lblMainMenuT.Size = new Size(205, 37);
            lblMainMenuT.TabIndex = 0;
            lblMainMenuT.Text = "Main Menu";
            lblMainMenuT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu_NewAccount
            // 
            lblMainMenu_NewAccount.BackColor = Color.Transparent;
            lblMainMenu_NewAccount.ForeColor = Color.White;
            lblMainMenu_NewAccount.Location = new Point(247, 78);
            lblMainMenu_NewAccount.Name = "lblMainMenu_NewAccount";
            lblMainMenu_NewAccount.Size = new Size(205, 19);
            lblMainMenu_NewAccount.TabIndex = 1;
            lblMainMenu_NewAccount.Text = "New Account";
            lblMainMenu_NewAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu_Login
            // 
            lblMainMenu_Login.BackColor = Color.Transparent;
            lblMainMenu_Login.ForeColor = Color.White;
            lblMainMenu_Login.Location = new Point(247, 114);
            lblMainMenu_Login.Name = "lblMainMenu_Login";
            lblMainMenu_Login.Size = new Size(205, 19);
            lblMainMenu_Login.TabIndex = 2;
            lblMainMenu_Login.Text = "Login";
            lblMainMenu_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu_IPConfig
            // 
            lblMainMenu_IPConfig.BackColor = Color.Transparent;
            lblMainMenu_IPConfig.ForeColor = Color.White;
            lblMainMenu_IPConfig.Location = new Point(247, 150);
            lblMainMenu_IPConfig.Name = "lblMainMenu_IPConfig";
            lblMainMenu_IPConfig.Size = new Size(205, 19);
            lblMainMenu_IPConfig.TabIndex = 3;
            lblMainMenu_IPConfig.Text = "IP Config";
            lblMainMenu_IPConfig.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu_GameOptions
            // 
            lblMainMenu_GameOptions.BackColor = Color.Transparent;
            lblMainMenu_GameOptions.ForeColor = Color.White;
            lblMainMenu_GameOptions.Location = new Point(247, 186);
            lblMainMenu_GameOptions.Name = "lblMainMenu_GameOptions";
            lblMainMenu_GameOptions.Size = new Size(205, 19);
            lblMainMenu_GameOptions.TabIndex = 4;
            lblMainMenu_GameOptions.Text = "Game Options";
            lblMainMenu_GameOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu_Exit
            // 
            lblMainMenu_Exit.BackColor = Color.Transparent;
            lblMainMenu_Exit.ForeColor = Color.White;
            lblMainMenu_Exit.Location = new Point(247, 222);
            lblMainMenu_Exit.Name = "lblMainMenu_Exit";
            lblMainMenu_Exit.Size = new Size(205, 19);
            lblMainMenu_Exit.TabIndex = 5;
            lblMainMenu_Exit.Text = "Exit Game";
            lblMainMenu_Exit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainMenu_Credits
            // 
            lblMainMenu_Credits.AutoSize = true;
            lblMainMenu_Credits.BackColor = Color.Transparent;
            lblMainMenu_Credits.ForeColor = Color.White;
            lblMainMenu_Credits.Location = new Point(441, 271);
            lblMainMenu_Credits.Name = "lblMainMenu_Credits";
            lblMainMenu_Credits.Size = new Size(44, 15);
            lblMainMenu_Credits.TabIndex = 6;
            lblMainMenu_Credits.Text = "Credits";
            lblMainMenu_Credits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(500, 300);
            Controls.Add(mnuNewCharacter);
            Controls.Add(mnuCredits);
            Controls.Add(mnuNewAccount);
            Controls.Add(mnuChars);
            Controls.Add(mnuLogin);
            Controls.Add(mnuIPConfig);
            Controls.Add(mnuGameOptions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MirageSource 5";
            mnuNewCharacter.ResumeLayout(false);
            mnuNewCharacter.PerformLayout();
            ResumeLayout(false);
        }
    }
}