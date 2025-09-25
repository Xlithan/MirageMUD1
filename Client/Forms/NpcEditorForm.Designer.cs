using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class NpcEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmdBack = new Button();
            cmdCancel = new Button();
            cmdSave = new Button();
            txtName = new TextBox();
            txtAttackSay = new TextBox();
            cmbBehavior = new ComboBox();
            scrlAvatar = new HScrollBar();
            scrlRange = new HScrollBar();
            scrlStrength = new HScrollBar();
            scrlDefense = new HScrollBar();
            scrlSpeed = new HScrollBar();
            scrlMagic = new HScrollBar();
            lblAvatarText = new Label();
            lblRangeText = new Label();
            lblStrengthText = new Label();
            lblDefenseText = new Label();
            lblSpeedText = new Label();
            lblMagicText = new Label();
            lblBehaviorText = new Label();
            lblNameText = new Label();
            lblSayText = new Label();
            lblAvatar = new Label();
            lblRange = new Label();
            lblStrength = new Label();
            lblDefense = new Label();
            lblSpeed = new Label();
            lblMagic = new Label();
            lblStartHPText = new Label();
            lblStartHP = new Label();
            lblExpGivenText = new Label();
            lblExpGiven = new Label();
            picAvatar = new PictureBox();
            fraDrop = new GroupBox();
            lblDropChanceText = new Label();
            txtChance = new TextBox();
            lblSpawnRateText = new Label();
            txtSpawnSecs = new TextBox();
            lblItem = new Label();
            lblItemName = new Label();
            lblNumText = new Label();
            scrlNum = new HScrollBar();
            lblNum = new Label();
            lblValueText = new Label();
            scrlValue = new HScrollBar();
            lblValue = new Label();
            picSprites = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            fraDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSprites).BeginInit();
            SuspendLayout();
            // 
            // cmdBack
            // 
            cmdBack.Location = new Point(128, 424);
            cmdBack.Name = "cmdBack";
            cmdBack.Size = new Size(97, 23);
            cmdBack.TabIndex = 31;
            cmdBack.Text = "Back to Index";
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(240, 424);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(97, 23);
            cmdCancel.TabIndex = 32;
            cmdCancel.Text = "Cancel";
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(16, 424);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(97, 23);
            cmdSave.TabIndex = 30;
            cmdSave.Text = "Save";
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 1;
            // 
            // txtAttackSay
            // 
            txtAttackSay.Location = new Point(64, 40);
            txtAttackSay.Name = "txtAttackSay";
            txtAttackSay.Size = new Size(265, 23);
            txtAttackSay.TabIndex = 3;
            // 
            // cmbBehavior
            // 
            cmbBehavior.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBehavior.Location = new Point(96, 184);
            cmbBehavior.Name = "cmbBehavior";
            cmbBehavior.Size = new Size(241, 24);
            cmbBehavior.TabIndex = 24;
            // 
            // scrlAvatar
            // 
            scrlAvatar.Location = new Point(72, 80);
            scrlAvatar.Maximum = 255;
            scrlAvatar.Name = "scrlAvatar";
            scrlAvatar.Size = new Size(193, 17);
            scrlAvatar.TabIndex = 5;
            // 
            // scrlRange
            // 
            scrlRange.Location = new Point(72, 96);
            scrlRange.Maximum = 255;
            scrlRange.Name = "scrlRange";
            scrlRange.Size = new Size(193, 17);
            scrlRange.TabIndex = 8;
            scrlRange.Value = 1;
            // 
            // scrlStrength
            // 
            scrlStrength.Location = new Point(72, 112);
            scrlStrength.Maximum = 255;
            scrlStrength.Name = "scrlStrength";
            scrlStrength.Size = new Size(193, 17);
            scrlStrength.TabIndex = 11;
            // 
            // scrlDefense
            // 
            scrlDefense.Location = new Point(72, 128);
            scrlDefense.Maximum = 255;
            scrlDefense.Name = "scrlDefense";
            scrlDefense.Size = new Size(193, 17);
            scrlDefense.TabIndex = 14;
            // 
            // scrlSpeed
            // 
            scrlSpeed.Enabled = false;
            scrlSpeed.Location = new Point(72, 144);
            scrlSpeed.Maximum = 255;
            scrlSpeed.Name = "scrlSpeed";
            scrlSpeed.Size = new Size(193, 17);
            scrlSpeed.TabIndex = 17;
            // 
            // scrlMagic
            // 
            scrlMagic.Enabled = false;
            scrlMagic.Location = new Point(72, 160);
            scrlMagic.Maximum = 255;
            scrlMagic.Name = "scrlMagic";
            scrlMagic.Size = new Size(193, 17);
            scrlMagic.TabIndex = 20;
            // 
            // lblAvatarText
            // 
            lblAvatarText.BackColor = Color.Transparent;
            lblAvatarText.Location = new Point(16, 80);
            lblAvatarText.Name = "lblAvatarText";
            lblAvatarText.Size = new Size(57, 25);
            lblAvatarText.TabIndex = 4;
            lblAvatarText.Text = "Avatar";
            // 
            // lblRangeText
            // 
            lblRangeText.BackColor = Color.Transparent;
            lblRangeText.Location = new Point(16, 96);
            lblRangeText.Name = "lblRangeText";
            lblRangeText.Size = new Size(57, 25);
            lblRangeText.TabIndex = 7;
            lblRangeText.Text = "Range";
            // 
            // lblStrengthText
            // 
            lblStrengthText.BackColor = Color.Transparent;
            lblStrengthText.Location = new Point(16, 112);
            lblStrengthText.Name = "lblStrengthText";
            lblStrengthText.Size = new Size(57, 25);
            lblStrengthText.TabIndex = 10;
            lblStrengthText.Text = "Strength";
            // 
            // lblDefenseText
            // 
            lblDefenseText.BackColor = Color.Transparent;
            lblDefenseText.Location = new Point(16, 128);
            lblDefenseText.Name = "lblDefenseText";
            lblDefenseText.Size = new Size(57, 25);
            lblDefenseText.TabIndex = 13;
            lblDefenseText.Text = "Defense";
            // 
            // lblSpeedText
            // 
            lblSpeedText.BackColor = Color.Transparent;
            lblSpeedText.Location = new Point(16, 144);
            lblSpeedText.Name = "lblSpeedText";
            lblSpeedText.Size = new Size(57, 25);
            lblSpeedText.TabIndex = 16;
            lblSpeedText.Text = "Speed";
            // 
            // lblMagicText
            // 
            lblMagicText.BackColor = Color.Transparent;
            lblMagicText.Location = new Point(16, 160);
            lblMagicText.Name = "lblMagicText";
            lblMagicText.Size = new Size(57, 25);
            lblMagicText.TabIndex = 19;
            lblMagicText.Text = "Magic";
            // 
            // lblBehaviorText
            // 
            lblBehaviorText.BackColor = Color.Transparent;
            lblBehaviorText.Location = new Point(16, 184);
            lblBehaviorText.Name = "lblBehaviorText";
            lblBehaviorText.Size = new Size(73, 25);
            lblBehaviorText.TabIndex = 23;
            lblBehaviorText.Text = "Behavior";
            // 
            // lblNameText
            // 
            lblNameText.BackColor = Color.Transparent;
            lblNameText.Location = new Point(8, 8);
            lblNameText.Name = "lblNameText";
            lblNameText.Size = new Size(49, 25);
            lblNameText.TabIndex = 0;
            lblNameText.Text = "Name";
            // 
            // lblSayText
            // 
            lblSayText.BackColor = Color.Transparent;
            lblSayText.Location = new Point(8, 40);
            lblSayText.Name = "lblSayText";
            lblSayText.Size = new Size(49, 25);
            lblSayText.TabIndex = 2;
            lblSayText.Text = "Say";
            // 
            // lblAvatar
            // 
            lblAvatar.BackColor = Color.Transparent;
            lblAvatar.Location = new Point(264, 80);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(33, 22);
            lblAvatar.TabIndex = 6;
            lblAvatar.Text = "0";
            lblAvatar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRange
            // 
            lblRange.BackColor = Color.Transparent;
            lblRange.Location = new Point(264, 96);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(33, 22);
            lblRange.TabIndex = 9;
            lblRange.Text = "0";
            lblRange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStrength
            // 
            lblStrength.BackColor = Color.Transparent;
            lblStrength.Location = new Point(264, 112);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(33, 22);
            lblStrength.TabIndex = 12;
            lblStrength.Text = "0";
            lblStrength.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDefense
            // 
            lblDefense.BackColor = Color.Transparent;
            lblDefense.Location = new Point(264, 128);
            lblDefense.Name = "lblDefense";
            lblDefense.Size = new Size(33, 22);
            lblDefense.TabIndex = 15;
            lblDefense.Text = "0";
            lblDefense.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSpeed
            // 
            lblSpeed.BackColor = Color.Transparent;
            lblSpeed.Location = new Point(264, 144);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(33, 22);
            lblSpeed.TabIndex = 18;
            lblSpeed.Text = "0";
            lblSpeed.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMagic
            // 
            lblMagic.BackColor = Color.Transparent;
            lblMagic.Location = new Point(264, 160);
            lblMagic.Name = "lblMagic";
            lblMagic.Size = new Size(33, 22);
            lblMagic.TabIndex = 21;
            lblMagic.Text = "0";
            lblMagic.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStartHPText
            // 
            lblStartHPText.BackColor = Color.Transparent;
            lblStartHPText.Location = new Point(16, 400);
            lblStartHPText.Name = "lblStartHPText";
            lblStartHPText.Size = new Size(65, 25);
            lblStartHPText.TabIndex = 26;
            lblStartHPText.Text = "Start HP";
            // 
            // lblStartHP
            // 
            lblStartHP.BackColor = Color.Transparent;
            lblStartHP.Location = new Point(88, 400);
            lblStartHP.Name = "lblStartHP";
            lblStartHP.Size = new Size(73, 25);
            lblStartHP.TabIndex = 27;
            lblStartHP.Text = "0";
            lblStartHP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblExpGivenText
            // 
            lblExpGivenText.BackColor = Color.Transparent;
            lblExpGivenText.Location = new Point(176, 400);
            lblExpGivenText.Name = "lblExpGivenText";
            lblExpGivenText.Size = new Size(81, 25);
            lblExpGivenText.TabIndex = 28;
            lblExpGivenText.Text = "Exp Given";
            // 
            // lblExpGiven
            // 
            lblExpGiven.BackColor = Color.Transparent;
            lblExpGiven.Location = new Point(256, 400);
            lblExpGiven.Name = "lblExpGiven";
            lblExpGiven.Size = new Size(73, 25);
            lblExpGiven.TabIndex = 29;
            lblExpGiven.Text = "0";
            lblExpGiven.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Black;
            picAvatar.Location = new Point(304, 80);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(48, 48);
            picAvatar.TabIndex = 22;
            picAvatar.TabStop = false;
            // 
            // fraDrop
            // 
            fraDrop.Controls.Add(lblDropChanceText);
            fraDrop.Controls.Add(txtChance);
            fraDrop.Controls.Add(lblSpawnRateText);
            fraDrop.Controls.Add(txtSpawnSecs);
            fraDrop.Controls.Add(lblItem);
            fraDrop.Controls.Add(lblItemName);
            fraDrop.Controls.Add(lblNumText);
            fraDrop.Controls.Add(scrlNum);
            fraDrop.Controls.Add(lblNum);
            fraDrop.Controls.Add(lblValueText);
            fraDrop.Controls.Add(scrlValue);
            fraDrop.Controls.Add(lblValue);
            fraDrop.Location = new Point(8, 216);
            fraDrop.Name = "fraDrop";
            fraDrop.Size = new Size(329, 177);
            fraDrop.TabIndex = 25;
            fraDrop.TabStop = false;
            fraDrop.Text = "Drop Item Data";
            // 
            // lblDropChanceText
            // 
            lblDropChanceText.BackColor = Color.Transparent;
            lblDropChanceText.Location = new Point(8, 16);
            lblDropChanceText.Name = "lblDropChanceText";
            lblDropChanceText.Size = new Size(193, 25);
            lblDropChanceText.TabIndex = 0;
            lblDropChanceText.Text = "Drop Item Chance 1 out of";
            // 
            // txtChance
            // 
            txtChance.Location = new Point(200, 16);
            txtChance.Name = "txtChance";
            txtChance.Size = new Size(121, 23);
            txtChance.TabIndex = 1;
            txtChance.Text = "0";
            txtChance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSpawnRateText
            // 
            lblSpawnRateText.BackColor = Color.Transparent;
            lblSpawnRateText.Location = new Point(8, 48);
            lblSpawnRateText.Name = "lblSpawnRateText";
            lblSpawnRateText.Size = new Size(193, 25);
            lblSpawnRateText.TabIndex = 2;
            lblSpawnRateText.Text = "Spawn Rate (in seconds)";
            // 
            // txtSpawnSecs
            // 
            txtSpawnSecs.Location = new Point(200, 48);
            txtSpawnSecs.Name = "txtSpawnSecs";
            txtSpawnSecs.Size = new Size(121, 23);
            txtSpawnSecs.TabIndex = 3;
            txtSpawnSecs.Text = "0";
            txtSpawnSecs.TextAlign = HorizontalAlignment.Right;
            // 
            // lblItem
            // 
            lblItem.BackColor = Color.Transparent;
            lblItem.Location = new Point(8, 80);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(41, 25);
            lblItem.TabIndex = 4;
            lblItem.Text = "Item";
            // 
            // lblItemName
            // 
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Location = new Point(56, 80);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(265, 25);
            lblItemName.TabIndex = 5;
            // 
            // lblNumText
            // 
            lblNumText.BackColor = Color.Transparent;
            lblNumText.Location = new Point(8, 112);
            lblNumText.Name = "lblNumText";
            lblNumText.Size = new Size(57, 25);
            lblNumText.TabIndex = 6;
            lblNumText.Text = "Num";
            // 
            // scrlNum
            // 
            scrlNum.Location = new Point(64, 112);
            scrlNum.Maximum = 255;
            scrlNum.Name = "scrlNum";
            scrlNum.Size = new Size(217, 17);
            scrlNum.TabIndex = 7;
            scrlNum.Value = 1;
            // 
            // lblNum
            // 
            lblNum.BackColor = Color.Transparent;
            lblNum.Location = new Point(288, 112);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(33, 25);
            lblNum.TabIndex = 8;
            lblNum.Text = "0";
            lblNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValueText
            // 
            lblValueText.BackColor = Color.Transparent;
            lblValueText.Location = new Point(8, 144);
            lblValueText.Name = "lblValueText";
            lblValueText.Size = new Size(49, 25);
            lblValueText.TabIndex = 9;
            lblValueText.Text = "Value";
            // 
            // scrlValue
            // 
            scrlValue.Location = new Point(64, 144);
            scrlValue.Maximum = 255;
            scrlValue.Name = "scrlValue";
            scrlValue.Size = new Size(217, 17);
            scrlValue.TabIndex = 10;
            scrlValue.Value = 1;
            // 
            // lblValue
            // 
            lblValue.BackColor = Color.Transparent;
            lblValue.Location = new Point(288, 144);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(33, 25);
            lblValue.TabIndex = 11;
            lblValue.Text = "0";
            lblValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picSprites
            // 
            picSprites.BackColor = Color.Black;
            picSprites.Location = new Point(8, 624);
            picSprites.Name = "picSprites";
            picSprites.Size = new Size(32, 32);
            picSprites.TabIndex = 33;
            picSprites.TabStop = false;
            // 
            // NpcEditorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(357, 454);
            ControlBox = false;
            Controls.Add(lblMagic);
            Controls.Add(lblSpeed);
            Controls.Add(lblDefense);
            Controls.Add(lblStrength);
            Controls.Add(lblRange);
            Controls.Add(lblBehaviorText);
            Controls.Add(lblMagicText);
            Controls.Add(lblSpeedText);
            Controls.Add(lblDefenseText);
            Controls.Add(lblStrengthText);
            Controls.Add(lblRangeText);
            Controls.Add(lblNameText);
            Controls.Add(txtName);
            Controls.Add(lblSayText);
            Controls.Add(txtAttackSay);
            Controls.Add(lblAvatarText);
            Controls.Add(scrlAvatar);
            Controls.Add(lblAvatar);
            Controls.Add(scrlRange);
            Controls.Add(scrlStrength);
            Controls.Add(scrlDefense);
            Controls.Add(scrlSpeed);
            Controls.Add(scrlMagic);
            Controls.Add(picAvatar);
            Controls.Add(cmbBehavior);
            Controls.Add(fraDrop);
            Controls.Add(lblStartHPText);
            Controls.Add(lblStartHP);
            Controls.Add(lblExpGivenText);
            Controls.Add(lblExpGiven);
            Controls.Add(cmdSave);
            Controls.Add(cmdBack);
            Controls.Add(cmdCancel);
            Controls.Add(picSprites);
            Font = new Font("Tahoma", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NpcEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Npc Editor";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            fraDrop.ResumeLayout(false);
            fraDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSprites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdBack;
        private Button cmdCancel;
        private Button cmdSave;

        private TextBox txtName;
        private TextBox txtAttackSay;

        private ComboBox cmbBehavior;

        private HScrollBar scrlAvatar;
        private HScrollBar scrlRange;
        private HScrollBar scrlStrength;
        private HScrollBar scrlDefense;
        private HScrollBar scrlSpeed;
        private HScrollBar scrlMagic;

        private Label lblAvatarText, lblRangeText, lblStrengthText, lblDefenseText, lblSpeedText, lblMagicText, lblBehaviorText;
        private Label lblNameText, lblSayText;

        private Label lblAvatar, lblRange, lblStrength, lblDefense, lblSpeed, lblMagic;

        private Label lblStartHPText, lblStartHP;
        private Label lblExpGivenText, lblExpGiven;

        private PictureBox picAvatar;

        private GroupBox fraDrop;
        private Label lblDropChanceText, lblSpawnRateText, lblItem, lblItemName, lblNumText, lblValueText;
        private TextBox txtChance, txtSpawnSecs;
        private HScrollBar scrlNum, scrlValue;
        private Label lblNum, lblValue;

        private PictureBox picSprites;
    }
}