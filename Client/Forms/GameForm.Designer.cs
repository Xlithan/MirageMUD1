using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;

        private RichTextBox txtChat;
        private TextBox txtMyChat;
        private ListBox lstSpells;
        private ListBox lstInv;
        private ListBox lstItems;
        private ListBox lstNPCs;
        private ListBox lstPlayers;
        private PictureBox picInvSelected;
        private PictureBox picXP;
        private PictureBox picMP;
        private PictureBox picStamina;
        private PictureBox picHP;
        private PictureBox picTarget;

        private Label lblRoomNum;
        private Label Label8;
        private Label lblBlockChance;
        private Label lblCritHit;
        private Label lblLevel;
        private Label lblSpeed;
        private Label lblMagi;
        private Label lblDef;
        private Label lblStr;
        private Label Label7;
        private Label Label6;
        private Label Label5;
        private Label Label4;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private Label lblCast;
        private Label lblUseItem;
        private Label lblDropItem;
        private Label lblXP;
        private Label lblHP;
        private Label lblTarget;
        private Label lblStamina;
        private Label lblMP;

        private PictureBox picMinimiseButton;
        private PictureBox picInventoryButton;
        private PictureBox picSpellsButton;
        private PictureBox picStatsButton;
        private PictureBox picTrainButton;
        private PictureBox picTradeButton;
        private PictureBox picQuitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtChat = new RichTextBox();
            txtMyChat = new TextBox();
            lstPlayers = new ListBox();
            lstNPCs = new ListBox();
            lstItems = new ListBox();
            lstInv = new ListBox();
            picInvSelected = new PictureBox();
            lstSpells = new ListBox();
            picHP = new PictureBox();
            picStamina = new PictureBox();
            picMP = new PictureBox();
            picXP = new PictureBox();
            lblHP = new Label();
            lblStamina = new Label();
            lblMP = new Label();
            lblXP = new Label();
            picTarget = new PictureBox();
            lblTarget = new Label();
            Label1 = new Label();
            lblStr = new Label();
            Label2 = new Label();
            lblDef = new Label();
            Label3 = new Label();
            lblMagi = new Label();
            Label4 = new Label();
            lblSpeed = new Label();
            Label5 = new Label();
            lblLevel = new Label();
            Label6 = new Label();
            lblCritHit = new Label();
            Label7 = new Label();
            lblBlockChance = new Label();
            Label8 = new Label();
            lblRoomNum = new Label();
            lblUseItem = new Label();
            lblDropItem = new Label();
            lblCast = new Label();
            picMinimiseButton = new PictureBox();
            picQuitButton = new PictureBox();
            picInventoryButton = new PictureBox();
            picSpellsButton = new PictureBox();
            picStatsButton = new PictureBox();
            picTrainButton = new PictureBox();
            picTradeButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picInvSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStamina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTarget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimiseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQuitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInventoryButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSpellsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTrainButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTradeButton).BeginInit();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.FromArgb(34, 35, 36);
            txtChat.BorderStyle = BorderStyle.None;
            txtChat.Font = new Font("Courier New", 9F);
            txtChat.ForeColor = Color.FromArgb(224, 224, 224);
            txtChat.Location = new Point(158, 53);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtChat.Size = new Size(492, 370);
            txtChat.TabIndex = 0;
            txtChat.Text = "";
            // 
            // txtMyChat
            // 
            txtMyChat.BackColor = Color.FromArgb(30, 29, 34);
            txtMyChat.BorderStyle = BorderStyle.None;
            txtMyChat.Font = new Font("Tahoma", 6.75F, FontStyle.Bold);
            txtMyChat.ForeColor = Color.White;
            txtMyChat.Location = new Point(160, 446);
            txtMyChat.Name = "txtMyChat";
            txtMyChat.Size = new Size(490, 11);
            txtMyChat.TabIndex = 1;
            // 
            // lstPlayers
            // 
            lstPlayers.BackColor = Color.FromArgb(30, 29, 34);
            lstPlayers.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lstPlayers.ForeColor = Color.FromArgb(224, 224, 224);
            lstPlayers.ItemHeight = 14;
            lstPlayers.Location = new Point(8, 75);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(137, 88);
            lstPlayers.TabIndex = 2;
            // 
            // lstNPCs
            // 
            lstNPCs.BackColor = Color.FromArgb(30, 29, 34);
            lstNPCs.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lstNPCs.ForeColor = Color.FromArgb(224, 224, 224);
            lstNPCs.ItemHeight = 14;
            lstNPCs.Location = new Point(8, 204);
            lstNPCs.Name = "lstNPCs";
            lstNPCs.Size = new Size(137, 88);
            lstNPCs.TabIndex = 3;
            // 
            // lstItems
            // 
            lstItems.BackColor = Color.FromArgb(30, 29, 34);
            lstItems.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lstItems.ForeColor = Color.FromArgb(224, 224, 224);
            lstItems.ItemHeight = 14;
            lstItems.Location = new Point(8, 336);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(137, 102);
            lstItems.TabIndex = 4;
            // 
            // lstInv
            // 
            lstInv.BackColor = Color.FromArgb(30, 29, 34);
            lstInv.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lstInv.ForeColor = Color.FromArgb(224, 224, 224);
            lstInv.ItemHeight = 14;
            lstInv.Location = new Point(663, 76);
            lstInv.Name = "lstInv";
            lstInv.Size = new Size(152, 144);
            lstInv.TabIndex = 5;
            // 
            // picInvSelected
            // 
            picInvSelected.BackColor = Color.Black;
            picInvSelected.Location = new Point(778, 238);
            picInvSelected.Name = "picInvSelected";
            picInvSelected.Size = new Size(32, 32);
            picInvSelected.TabIndex = 6;
            picInvSelected.TabStop = false;
            // 
            // lstSpells
            // 
            lstSpells.BackColor = Color.FromArgb(30, 29, 34);
            lstSpells.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            lstSpells.ForeColor = Color.FromArgb(224, 224, 224);
            lstSpells.ItemHeight = 14;
            lstSpells.Location = new Point(662, 296);
            lstSpells.Name = "lstSpells";
            lstSpells.Size = new Size(152, 130);
            lstSpells.TabIndex = 7;
            // 
            // picHP
            // 
            picHP.BackColor = Color.Silver;
            picHP.Image = Properties.Resources.hpbar;
            picHP.Location = new Point(33, 15);
            picHP.Name = "picHP";
            picHP.Size = new Size(93, 9);
            picHP.TabIndex = 8;
            picHP.TabStop = false;
            // 
            // picStamina
            // 
            picStamina.BackColor = Color.Silver;
            picStamina.Image = Properties.Resources.spbar;
            picStamina.Location = new Point(173, 15);
            picStamina.Name = "picStamina";
            picStamina.Size = new Size(93, 9);
            picStamina.TabIndex = 9;
            picStamina.TabStop = false;
            // 
            // picMP
            // 
            picMP.BackColor = Color.Silver;
            picMP.Image = Properties.Resources.mpbar;
            picMP.Location = new Point(312, 15);
            picMP.Name = "picMP";
            picMP.Size = new Size(93, 9);
            picMP.TabIndex = 10;
            picMP.TabStop = false;
            // 
            // picXP
            // 
            picXP.BackColor = Color.Silver;
            picXP.Image = Properties.Resources.xpbar;
            picXP.Location = new Point(452, 15);
            picXP.Name = "picXP";
            picXP.Size = new Size(273, 9);
            picXP.TabIndex = 11;
            picXP.TabStop = false;
            // 
            // lblHP
            // 
            lblHP.BackColor = Color.Transparent;
            lblHP.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            lblHP.ForeColor = Color.FromArgb(224, 224, 224);
            lblHP.Location = new Point(43, 0);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(73, 17);
            lblHP.TabIndex = 12;
            lblHP.Text = "0/0";
            lblHP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStamina
            // 
            lblStamina.BackColor = Color.Transparent;
            lblStamina.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            lblStamina.ForeColor = Color.FromArgb(224, 224, 224);
            lblStamina.Location = new Point(183, 0);
            lblStamina.Name = "lblStamina";
            lblStamina.Size = new Size(73, 17);
            lblStamina.TabIndex = 13;
            lblStamina.Text = "0/0";
            lblStamina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMP
            // 
            lblMP.BackColor = Color.Transparent;
            lblMP.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            lblMP.ForeColor = Color.FromArgb(224, 224, 224);
            lblMP.Location = new Point(323, 0);
            lblMP.Name = "lblMP";
            lblMP.Size = new Size(73, 17);
            lblMP.TabIndex = 14;
            lblMP.Text = "0/0";
            lblMP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXP
            // 
            lblXP.BackColor = Color.Transparent;
            lblXP.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            lblXP.ForeColor = Color.FromArgb(224, 224, 224);
            lblXP.Location = new Point(554, 0);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(73, 17);
            lblXP.TabIndex = 15;
            lblXP.Text = "0/0";
            lblXP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picTarget
            // 
            picTarget.BackColor = Color.Black;
            picTarget.Location = new Point(44, 488);
            picTarget.Name = "picTarget";
            picTarget.Size = new Size(66, 66);
            picTarget.TabIndex = 16;
            picTarget.TabStop = false;
            // 
            // lblTarget
            // 
            lblTarget.BackColor = Color.Transparent;
            lblTarget.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTarget.ForeColor = Color.FromArgb(224, 224, 224);
            lblTarget.Location = new Point(19, 572);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(115, 16);
            lblTarget.TabIndex = 17;
            lblTarget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label1.ForeColor = Color.FromArgb(47, 35, 33);
            Label1.Location = new Point(194, 488);
            Label1.Name = "Label1";
            Label1.Size = new Size(70, 16);
            Label1.TabIndex = 18;
            Label1.Text = "Strength:";
            // 
            // lblStr
            // 
            lblStr.AutoSize = true;
            lblStr.BackColor = Color.Transparent;
            lblStr.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblStr.ForeColor = Color.FromArgb(110, 85, 81);
            lblStr.Location = new Point(263, 488);
            lblStr.Name = "lblStr";
            lblStr.Size = new Size(23, 16);
            lblStr.TabIndex = 19;
            lblStr.Text = "00";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label2.ForeColor = Color.FromArgb(47, 35, 33);
            Label2.Location = new Point(199, 504);
            Label2.Name = "Label2";
            Label2.Size = new Size(65, 16);
            Label2.TabIndex = 20;
            Label2.Text = "Defense:";
            // 
            // lblDef
            // 
            lblDef.AutoSize = true;
            lblDef.BackColor = Color.Transparent;
            lblDef.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblDef.ForeColor = Color.FromArgb(110, 85, 81);
            lblDef.Location = new Point(263, 504);
            lblDef.Name = "lblDef";
            lblDef.Size = new Size(23, 16);
            lblDef.TabIndex = 21;
            lblDef.Text = "00";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label3.ForeColor = Color.FromArgb(47, 35, 33);
            Label3.Location = new Point(222, 520);
            Label3.Name = "Label3";
            Label3.Size = new Size(42, 16);
            Label3.TabIndex = 22;
            Label3.Text = "Magi:";
            // 
            // lblMagi
            // 
            lblMagi.AutoSize = true;
            lblMagi.BackColor = Color.Transparent;
            lblMagi.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblMagi.ForeColor = Color.FromArgb(110, 85, 81);
            lblMagi.Location = new Point(263, 520);
            lblMagi.Name = "lblMagi";
            lblMagi.Size = new Size(23, 16);
            lblMagi.TabIndex = 23;
            lblMagi.Text = "00";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label4.ForeColor = Color.FromArgb(47, 35, 33);
            Label4.Location = new Point(212, 536);
            Label4.Name = "Label4";
            Label4.Size = new Size(52, 16);
            Label4.TabIndex = 24;
            Label4.Text = "Speed:";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.BackColor = Color.Transparent;
            lblSpeed.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblSpeed.ForeColor = Color.FromArgb(110, 85, 81);
            lblSpeed.Location = new Point(263, 536);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(23, 16);
            lblSpeed.TabIndex = 25;
            lblSpeed.Text = "00";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label5.ForeColor = Color.FromArgb(47, 35, 33);
            Label5.Location = new Point(218, 568);
            Label5.Name = "Label5";
            Label5.Size = new Size(46, 16);
            Label5.TabIndex = 26;
            Label5.Text = "Level:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BackColor = Color.Transparent;
            lblLevel.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblLevel.ForeColor = Color.FromArgb(110, 85, 81);
            lblLevel.Location = new Point(263, 568);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(23, 16);
            lblLevel.TabIndex = 27;
            lblLevel.Text = "00";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label6.ForeColor = Color.FromArgb(47, 35, 33);
            Label6.Location = new Point(344, 496);
            Label6.Name = "Label6";
            Label6.Size = new Size(129, 16);
            Label6.TabIndex = 28;
            Label6.Text = "Critical Hit Chance:";
            // 
            // lblCritHit
            // 
            lblCritHit.AutoSize = true;
            lblCritHit.BackColor = Color.Transparent;
            lblCritHit.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblCritHit.ForeColor = Color.FromArgb(110, 85, 81);
            lblCritHit.Location = new Point(448, 512);
            lblCritHit.Name = "lblCritHit";
            lblCritHit.Size = new Size(23, 16);
            lblCritHit.TabIndex = 29;
            lblCritHit.Text = "00";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label7.ForeColor = Color.FromArgb(47, 35, 33);
            Label7.Location = new Point(376, 528);
            Label7.Name = "Label7";
            Label7.Size = new Size(96, 16);
            Label7.TabIndex = 30;
            Label7.Text = "Block Chance:";
            // 
            // lblBlockChance
            // 
            lblBlockChance.AutoSize = true;
            lblBlockChance.BackColor = Color.Transparent;
            lblBlockChance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblBlockChance.ForeColor = Color.FromArgb(110, 85, 81);
            lblBlockChance.Location = new Point(448, 544);
            lblBlockChance.Name = "lblBlockChance";
            lblBlockChance.Size = new Size(23, 16);
            lblBlockChance.TabIndex = 31;
            lblBlockChance.Text = "00";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.Transparent;
            Label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            Label8.ForeColor = Color.FromArgb(255, 255, 192);
            Label8.Location = new Point(502, 576);
            Label8.Name = "Label8";
            Label8.Size = new Size(48, 16);
            Label8.TabIndex = 32;
            Label8.Text = "Room:";
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.BackColor = Color.Transparent;
            lblRoomNum.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            lblRoomNum.ForeColor = Color.White;
            lblRoomNum.Location = new Point(549, 576);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(15, 16);
            lblRoomNum.TabIndex = 33;
            lblRoomNum.Text = "0";
            // 
            // lblUseItem
            // 
            lblUseItem.BackColor = Color.Transparent;
            lblUseItem.Font = new Font("Tahoma", 9.75F);
            lblUseItem.ForeColor = Color.FromArgb(224, 224, 224);
            lblUseItem.Location = new Point(682, 237);
            lblUseItem.Name = "lblUseItem";
            lblUseItem.Size = new Size(65, 17);
            lblUseItem.TabIndex = 34;
            lblUseItem.Text = "Use Item";
            lblUseItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDropItem
            // 
            lblDropItem.BackColor = Color.Transparent;
            lblDropItem.Font = new Font("Tahoma", 9.75F);
            lblDropItem.ForeColor = Color.FromArgb(224, 224, 224);
            lblDropItem.Location = new Point(682, 253);
            lblDropItem.Name = "lblDropItem";
            lblDropItem.Size = new Size(65, 17);
            lblDropItem.TabIndex = 35;
            lblDropItem.Text = "Drop Item";
            lblDropItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCast
            // 
            lblCast.BackColor = Color.Transparent;
            lblCast.Font = new Font("Tahoma", 9.75F);
            lblCast.ForeColor = Color.FromArgb(224, 224, 224);
            lblCast.Location = new Point(709, 447);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(57, 17);
            lblCast.TabIndex = 36;
            lblCast.Text = "Cast";
            lblCast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMinimiseButton
            // 
            picMinimiseButton.BackColor = Color.Transparent;
            picMinimiseButton.Location = new Point(755, 3);
            picMinimiseButton.Name = "picMinimiseButton";
            picMinimiseButton.Size = new Size(29, 30);
            picMinimiseButton.TabIndex = 37;
            picMinimiseButton.TabStop = false;
            // 
            // picQuitButton
            // 
            picQuitButton.BackColor = Color.Transparent;
            picQuitButton.Location = new Point(786, 3);
            picQuitButton.Name = "picQuitButton";
            picQuitButton.Size = new Size(29, 30);
            picQuitButton.TabIndex = 38;
            picQuitButton.TabStop = false;
            // 
            // picInventoryButton
            // 
            picInventoryButton.BackColor = Color.Transparent;
            picInventoryButton.Location = new Point(461, 654);
            picInventoryButton.Name = "picInventoryButton";
            picInventoryButton.Size = new Size(55, 50);
            picInventoryButton.TabIndex = 39;
            picInventoryButton.TabStop = false;
            // 
            // picSpellsButton
            // 
            picSpellsButton.BackColor = Color.Transparent;
            picSpellsButton.Location = new Point(533, 654);
            picSpellsButton.Name = "picSpellsButton";
            picSpellsButton.Size = new Size(55, 50);
            picSpellsButton.TabIndex = 40;
            picSpellsButton.TabStop = false;
            // 
            // picStatsButton
            // 
            picStatsButton.BackColor = Color.Transparent;
            picStatsButton.Location = new Point(599, 651);
            picStatsButton.Name = "picStatsButton";
            picStatsButton.Size = new Size(55, 50);
            picStatsButton.TabIndex = 41;
            picStatsButton.TabStop = false;
            // 
            // picTrainButton
            // 
            picTrainButton.BackColor = Color.Transparent;
            picTrainButton.Location = new Point(677, 527);
            picTrainButton.Name = "picTrainButton";
            picTrainButton.Size = new Size(55, 50);
            picTrainButton.TabIndex = 42;
            picTrainButton.TabStop = false;
            // 
            // picTradeButton
            // 
            picTradeButton.BackColor = Color.Transparent;
            picTradeButton.Location = new Point(747, 527);
            picTradeButton.Name = "picTradeButton";
            picTradeButton.Size = new Size(55, 50);
            picTradeButton.TabIndex = 43;
            picTradeButton.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 128);
            BackgroundImage = Properties.Resources.game;
            ClientSize = new Size(819, 600);
            ControlBox = false;
            Controls.Add(txtChat);
            Controls.Add(txtMyChat);
            Controls.Add(lstPlayers);
            Controls.Add(lstNPCs);
            Controls.Add(lstItems);
            Controls.Add(lstInv);
            Controls.Add(picInvSelected);
            Controls.Add(lstSpells);
            Controls.Add(picHP);
            Controls.Add(picStamina);
            Controls.Add(picMP);
            Controls.Add(picXP);
            Controls.Add(lblHP);
            Controls.Add(lblStamina);
            Controls.Add(lblMP);
            Controls.Add(lblXP);
            Controls.Add(picTarget);
            Controls.Add(lblTarget);
            Controls.Add(Label1);
            Controls.Add(lblStr);
            Controls.Add(Label2);
            Controls.Add(lblDef);
            Controls.Add(Label3);
            Controls.Add(lblMagi);
            Controls.Add(Label4);
            Controls.Add(lblSpeed);
            Controls.Add(Label5);
            Controls.Add(lblLevel);
            Controls.Add(Label6);
            Controls.Add(lblCritHit);
            Controls.Add(Label7);
            Controls.Add(lblBlockChance);
            Controls.Add(Label8);
            Controls.Add(lblRoomNum);
            Controls.Add(lblUseItem);
            Controls.Add(lblDropItem);
            Controls.Add(lblCast);
            Controls.Add(picMinimiseButton);
            Controls.Add(picQuitButton);
            Controls.Add(picInventoryButton);
            Controls.Add(picSpellsButton);
            Controls.Add(picStatsButton);
            Controls.Add(picTrainButton);
            Controls.Add(picTradeButton);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MirageMUD";
            ((System.ComponentModel.ISupportInitialize)picInvSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStamina).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTarget).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimiseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQuitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInventoryButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSpellsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTrainButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTradeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}