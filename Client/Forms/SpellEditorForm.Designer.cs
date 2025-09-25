using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class SpellEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button cmdBack;
        private Button cmdSave;
        private Button cmdCancel;
        private TextBox txtName;
        private Label Label1;

        private GroupBox FraData;
        private HScrollBar scrlMPReq;
        private HScrollBar scrlLevelReq;
        private Label lblMPReq;
        private Label lblMP;
        private Label lblLevel;
        private Label lblLevelReq;

        private GroupBox FraPic;
        private HScrollBar scrlFrame;
        private HScrollBar scrlPic;
        private PictureBox picPic;
        private Label lblFrame;
        private Label lblFrameNum;
        private Label lblSpell;
        private Label lblSpellNum;

        private ComboBox cmbClassReq;

        private GroupBox fraGiveItem;
        private HScrollBar scrlItemValue;
        private HScrollBar scrlItemNum;
        private Label lblItemValue;
        private Label Label5;
        private Label lblItemNum;
        private Label Label2;

        private ComboBox cmbType;

        private GroupBox fraVitals;
        private HScrollBar scrlVitalMod;
        private Label Label4;
        private Label lblVitalMod;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmdBack = new Button();
            cmdSave = new Button();
            cmdCancel = new Button();
            txtName = new TextBox();
            Label1 = new Label();
            FraData = new GroupBox();
            lblLevel = new Label();
            scrlLevelReq = new HScrollBar();
            lblLevelReq = new Label();
            lblMP = new Label();
            scrlMPReq = new HScrollBar();
            lblMPReq = new Label();
            FraPic = new GroupBox();
            lblSpell = new Label();
            scrlPic = new HScrollBar();
            lblSpellNum = new Label();
            lblFrame = new Label();
            scrlFrame = new HScrollBar();
            lblFrameNum = new Label();
            picPic = new PictureBox();
            cmbClassReq = new ComboBox();
            fraGiveItem = new GroupBox();
            Label2 = new Label();
            scrlItemNum = new HScrollBar();
            lblItemNum = new Label();
            Label5 = new Label();
            scrlItemValue = new HScrollBar();
            lblItemValue = new Label();
            cmbType = new ComboBox();
            fraVitals = new GroupBox();
            Label4 = new Label();
            scrlVitalMod = new HScrollBar();
            lblVitalMod = new Label();
            FraData.SuspendLayout();
            FraPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPic).BeginInit();
            fraGiveItem.SuspendLayout();
            fraVitals.SuspendLayout();
            SuspendLayout();
            // 
            // cmdBack
            // 
            cmdBack.Location = new Point(120, 392);
            cmdBack.Name = "cmdBack";
            cmdBack.Size = new Size(97, 23);
            cmdBack.TabIndex = 9;
            cmdBack.Text = "Back to Index";
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(8, 392);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(89, 23);
            cmdSave.TabIndex = 8;
            cmdSave.Text = "Save";
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(232, 392);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(89, 23);
            cmdCancel.TabIndex = 10;
            cmdCancel.Text = "Cancel";
            // 
            // txtName
            // 
            txtName.Location = new Point(67, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(254, 23);
            txtName.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.Location = new Point(8, 8);
            Label1.Name = "Label1";
            Label1.Size = new Size(53, 23);
            Label1.TabIndex = 0;
            Label1.Text = "Name";
            // 
            // FraData
            // 
            FraData.Controls.Add(lblLevel);
            FraData.Controls.Add(scrlLevelReq);
            FraData.Controls.Add(lblLevelReq);
            FraData.Controls.Add(lblMP);
            FraData.Controls.Add(scrlMPReq);
            FraData.Controls.Add(lblMPReq);
            FraData.Location = new Point(8, 72);
            FraData.Name = "FraData";
            FraData.Size = new Size(313, 85);
            FraData.TabIndex = 3;
            FraData.TabStop = false;
            FraData.Text = "Data";
            // 
            // lblLevel
            // 
            lblLevel.Location = new Point(8, 28);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(100, 23);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "Level";
            // 
            // scrlLevelReq
            // 
            scrlLevelReq.Location = new Point(64, 28);
            scrlLevelReq.Maximum = 255;
            scrlLevelReq.Minimum = 1;
            scrlLevelReq.Name = "scrlLevelReq";
            scrlLevelReq.Size = new Size(205, 17);
            scrlLevelReq.TabIndex = 1;
            scrlLevelReq.Value = 1;
            // 
            // lblLevelReq
            // 
            lblLevelReq.Location = new Point(276, 28);
            lblLevelReq.Name = "lblLevelReq";
            lblLevelReq.Size = new Size(29, 17);
            lblLevelReq.TabIndex = 2;
            lblLevelReq.Text = "1";
            lblLevelReq.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMP
            // 
            lblMP.Location = new Point(8, 52);
            lblMP.Name = "lblMP";
            lblMP.Size = new Size(100, 23);
            lblMP.TabIndex = 3;
            lblMP.Text = "MP";
            // 
            // scrlMPReq
            // 
            scrlMPReq.Location = new Point(64, 52);
            scrlMPReq.Maximum = 1000;
            scrlMPReq.Name = "scrlMPReq";
            scrlMPReq.Size = new Size(205, 17);
            scrlMPReq.TabIndex = 4;
            // 
            // lblMPReq
            // 
            lblMPReq.Location = new Point(276, 52);
            lblMPReq.Name = "lblMPReq";
            lblMPReq.Size = new Size(29, 17);
            lblMPReq.TabIndex = 5;
            lblMPReq.Text = "0";
            lblMPReq.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FraPic
            // 
            FraPic.Controls.Add(lblSpell);
            FraPic.Controls.Add(scrlPic);
            FraPic.Controls.Add(lblSpellNum);
            FraPic.Controls.Add(lblFrame);
            FraPic.Controls.Add(scrlFrame);
            FraPic.Controls.Add(lblFrameNum);
            FraPic.Controls.Add(picPic);
            FraPic.Location = new Point(8, 168);
            FraPic.Name = "FraPic";
            FraPic.Size = new Size(313, 73);
            FraPic.TabIndex = 4;
            FraPic.TabStop = false;
            FraPic.Text = "Spell Animation";
            // 
            // lblSpell
            // 
            lblSpell.Location = new Point(8, 24);
            lblSpell.Name = "lblSpell";
            lblSpell.Size = new Size(100, 23);
            lblSpell.TabIndex = 0;
            lblSpell.Text = "Spell";
            // 
            // scrlPic
            // 
            scrlPic.Location = new Point(64, 24);
            scrlPic.Maximum = 255;
            scrlPic.Name = "scrlPic";
            scrlPic.Size = new Size(162, 17);
            scrlPic.TabIndex = 1;
            scrlPic.Value = 1;
            // 
            // lblSpellNum
            // 
            lblSpellNum.Location = new Point(229, 24);
            lblSpellNum.Name = "lblSpellNum";
            lblSpellNum.Size = new Size(29, 17);
            lblSpellNum.TabIndex = 2;
            lblSpellNum.Text = "0";
            lblSpellNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFrame
            // 
            lblFrame.Location = new Point(8, 48);
            lblFrame.Name = "lblFrame";
            lblFrame.Size = new Size(100, 23);
            lblFrame.TabIndex = 3;
            lblFrame.Text = "Frame";
            // 
            // scrlFrame
            // 
            scrlFrame.Location = new Point(64, 48);
            scrlFrame.Maximum = 255;
            scrlFrame.Name = "scrlFrame";
            scrlFrame.Size = new Size(162, 17);
            scrlFrame.TabIndex = 4;
            scrlFrame.Value = 1;
            // 
            // lblFrameNum
            // 
            lblFrameNum.Location = new Point(229, 48);
            lblFrameNum.Name = "lblFrameNum";
            lblFrameNum.Size = new Size(29, 17);
            lblFrameNum.TabIndex = 5;
            lblFrameNum.Text = "0";
            lblFrameNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picPic
            // 
            picPic.BackColor = Color.Black;
            picPic.Location = new Point(275, 24);
            picPic.Name = "picPic";
            picPic.Size = new Size(32, 32);
            picPic.TabIndex = 6;
            picPic.TabStop = false;
            // 
            // cmbClassReq
            // 
            cmbClassReq.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassReq.Location = new Point(8, 40);
            cmbClassReq.Name = "cmbClassReq";
            cmbClassReq.Size = new Size(313, 24);
            cmbClassReq.TabIndex = 2;
            // 
            // fraGiveItem
            // 
            fraGiveItem.Controls.Add(Label2);
            fraGiveItem.Controls.Add(scrlItemNum);
            fraGiveItem.Controls.Add(lblItemNum);
            fraGiveItem.Controls.Add(Label5);
            fraGiveItem.Controls.Add(scrlItemValue);
            fraGiveItem.Controls.Add(lblItemValue);
            fraGiveItem.Location = new Point(8, 280);
            fraGiveItem.Name = "fraGiveItem";
            fraGiveItem.Size = new Size(313, 85);
            fraGiveItem.TabIndex = 6;
            fraGiveItem.TabStop = false;
            fraGiveItem.Text = "Give Item";
            fraGiveItem.Visible = false;
            // 
            // Label2
            // 
            Label2.Location = new Point(8, 24);
            Label2.Name = "Label2";
            Label2.Size = new Size(100, 23);
            Label2.TabIndex = 0;
            Label2.Text = "Item";
            // 
            // scrlItemNum
            // 
            scrlItemNum.Location = new Point(64, 24);
            scrlItemNum.Maximum = 255;
            scrlItemNum.Minimum = 1;
            scrlItemNum.Name = "scrlItemNum";
            scrlItemNum.Size = new Size(177, 17);
            scrlItemNum.TabIndex = 1;
            scrlItemNum.Value = 1;
            // 
            // lblItemNum
            // 
            lblItemNum.Location = new Point(248, 24);
            lblItemNum.Name = "lblItemNum";
            lblItemNum.Size = new Size(29, 17);
            lblItemNum.TabIndex = 2;
            lblItemNum.Text = "1";
            lblItemNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.Location = new Point(8, 52);
            Label5.Name = "Label5";
            Label5.Size = new Size(100, 23);
            Label5.TabIndex = 3;
            Label5.Text = "Value";
            // 
            // scrlItemValue
            // 
            scrlItemValue.Location = new Point(64, 52);
            scrlItemValue.Name = "scrlItemValue";
            scrlItemValue.Size = new Size(177, 17);
            scrlItemValue.TabIndex = 4;
            // 
            // lblItemValue
            // 
            lblItemValue.Location = new Point(248, 52);
            lblItemValue.Name = "lblItemValue";
            lblItemValue.Size = new Size(29, 17);
            lblItemValue.TabIndex = 5;
            lblItemValue.Text = "0";
            lblItemValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(8, 248);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(313, 24);
            cmbType.TabIndex = 5;
            // 
            // fraVitals
            // 
            fraVitals.Controls.Add(Label4);
            fraVitals.Controls.Add(scrlVitalMod);
            fraVitals.Controls.Add(lblVitalMod);
            fraVitals.Location = new Point(8, 280);
            fraVitals.Name = "fraVitals";
            fraVitals.Size = new Size(313, 85);
            fraVitals.TabIndex = 7;
            fraVitals.TabStop = false;
            fraVitals.Text = "Vitals Data";
            fraVitals.Visible = false;
            // 
            // Label4
            // 
            Label4.Location = new Point(8, 24);
            Label4.Name = "Label4";
            Label4.Size = new Size(100, 23);
            Label4.TabIndex = 0;
            Label4.Text = "Vital Mod";
            // 
            // scrlVitalMod
            // 
            scrlVitalMod.Location = new Point(96, 24);
            scrlVitalMod.Maximum = 255;
            scrlVitalMod.Name = "scrlVitalMod";
            scrlVitalMod.Size = new Size(177, 17);
            scrlVitalMod.TabIndex = 1;
            scrlVitalMod.Value = 1;
            // 
            // lblVitalMod
            // 
            lblVitalMod.Location = new Point(280, 24);
            lblVitalMod.Name = "lblVitalMod";
            lblVitalMod.Size = new Size(29, 17);
            lblVitalMod.TabIndex = 2;
            lblVitalMod.Text = "1";
            lblVitalMod.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SpellEditorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(337, 429);
            ControlBox = false;
            Controls.Add(Label1);
            Controls.Add(txtName);
            Controls.Add(cmbClassReq);
            Controls.Add(FraData);
            Controls.Add(FraPic);
            Controls.Add(cmbType);
            Controls.Add(fraGiveItem);
            Controls.Add(fraVitals);
            Controls.Add(cmdSave);
            Controls.Add(cmdBack);
            Controls.Add(cmdCancel);
            Font = new Font("Tahoma", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpellEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spell Editor";
            FraData.ResumeLayout(false);
            FraPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPic).EndInit();
            fraGiveItem.ResumeLayout(false);
            fraVitals.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}