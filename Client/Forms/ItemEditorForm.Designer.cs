namespace Client.Forms
{
    partial class ItemEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Button cmdBack;
        private PictureBox picItems;
        private PictureBox picPic;
        private HScrollBar scrlPic;
        private Button cmdCancel;
        private Button cmdSave;
        private TextBox txtName;
        private ComboBox cmbType;
        private GroupBox fraSpell;
        private HScrollBar scrlSpell;
        private Label lblSpellName;
        private Label lblSpellNumCaption;
        private Label lblSpellNameCaption;
        private Label lblSpell;
        private GroupBox fraVitals;
        private HScrollBar scrlVitalMod;
        private Label lblVitalMod;
        private Label lblVitalModCaption;
        private GroupBox fraEquipment;
        private HScrollBar scrlStrength;
        private HScrollBar scrlDurability;
        private Label lblStrength;
        private Label lblDurability;
        private Label lblStrengthCaption;
        private Label lblDurabilityCaption;
        private Label lblPic;
        private Label lblPicCaption;
        private Label lblNameCaption;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdBack = new Button();
            picItems = new PictureBox();
            picPic = new PictureBox();
            scrlPic = new HScrollBar();
            cmdCancel = new Button();
            cmdSave = new Button();
            txtName = new TextBox();
            cmbType = new ComboBox();
            fraSpell = new GroupBox();
            scrlSpell = new HScrollBar();
            lblSpellName = new Label();
            lblSpellNameCaption = new Label();
            lblSpellNumCaption = new Label();
            lblSpell = new Label();
            fraVitals = new GroupBox();
            scrlVitalMod = new HScrollBar();
            lblVitalMod = new Label();
            lblVitalModCaption = new Label();
            fraEquipment = new GroupBox();
            scrlStrength = new HScrollBar();
            scrlDurability = new HScrollBar();
            lblStrength = new Label();
            lblDurability = new Label();
            lblStrengthCaption = new Label();
            lblDurabilityCaption = new Label();
            lblPic = new Label();
            lblPicCaption = new Label();
            lblNameCaption = new Label();
            ((System.ComponentModel.ISupportInitialize)picItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPic).BeginInit();
            fraSpell.SuspendLayout();
            fraVitals.SuspendLayout();
            fraEquipment.SuspendLayout();
            SuspendLayout();
            // 
            // cmdBack
            // 
            cmdBack.Location = new Point(120, 232);
            cmdBack.Name = "cmdBack";
            cmdBack.Size = new Size(97, 25);
            cmdBack.TabIndex = 0;
            cmdBack.Text = "Back to Index";
            cmdBack.UseVisualStyleBackColor = true;
            // 
            // picItems
            // 
            picItems.BackColor = Color.Black;
            picItems.Location = new Point(8, 296);
            picItems.Name = "picItems";
            picItems.Size = new Size(32, 32);
            picItems.TabIndex = 1;
            picItems.TabStop = false;
            // 
            // picPic
            // 
            picPic.BackColor = Color.Black;
            picPic.Location = new Point(296, 38);
            picPic.Name = "picPic";
            picPic.Size = new Size(48, 48);
            picPic.TabIndex = 2;
            picPic.TabStop = false;
            // 
            // scrlPic
            // 
            scrlPic.Location = new Point(64, 40);
            scrlPic.Maximum = 255;
            scrlPic.Name = "scrlPic";
            scrlPic.Size = new Size(193, 17);
            scrlPic.TabIndex = 0;
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(232, 232);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(97, 25);
            cmdCancel.TabIndex = 3;
            cmdCancel.Text = "Cancel";
            cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(8, 232);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(97, 25);
            cmdSave.TabIndex = 4;
            cmdSave.Text = "Save";
            cmdSave.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 0;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(8, 96);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(321, 23);
            cmbType.TabIndex = 1;
            // 
            // fraSpell
            // 
            fraSpell.Controls.Add(scrlSpell);
            fraSpell.Controls.Add(lblSpellName);
            fraSpell.Controls.Add(lblSpellNameCaption);
            fraSpell.Controls.Add(lblSpellNumCaption);
            fraSpell.Controls.Add(lblSpell);
            fraSpell.Location = new Point(8, 128);
            fraSpell.Name = "fraSpell";
            fraSpell.Size = new Size(321, 97);
            fraSpell.TabIndex = 5;
            fraSpell.TabStop = false;
            fraSpell.Text = "Spell Data";
            fraSpell.Visible = false;
            // 
            // scrlSpell
            // 
            scrlSpell.Location = new Point(88, 56);
            scrlSpell.Maximum = 255;
            scrlSpell.Minimum = 1;
            scrlSpell.Name = "scrlSpell";
            scrlSpell.Size = new Size(193, 17);
            scrlSpell.TabIndex = 0;
            scrlSpell.Value = 1;
            // 
            // lblSpellName
            // 
            lblSpellName.BackColor = Color.Transparent;
            lblSpellName.Location = new Point(88, 24);
            lblSpellName.Name = "lblSpellName";
            lblSpellName.Size = new Size(225, 17);
            lblSpellName.TabIndex = 1;
            // 
            // lblSpellNameCaption
            // 
            lblSpellNameCaption.BackColor = Color.Transparent;
            lblSpellNameCaption.Location = new Point(8, 24);
            lblSpellNameCaption.Name = "lblSpellNameCaption";
            lblSpellNameCaption.Size = new Size(100, 23);
            lblSpellNameCaption.TabIndex = 2;
            lblSpellNameCaption.Text = "Name";
            // 
            // lblSpellNumCaption
            // 
            lblSpellNumCaption.BackColor = Color.Transparent;
            lblSpellNumCaption.Location = new Point(8, 56);
            lblSpellNumCaption.Name = "lblSpellNumCaption";
            lblSpellNumCaption.Size = new Size(100, 23);
            lblSpellNumCaption.TabIndex = 3;
            lblSpellNumCaption.Text = "Num";
            // 
            // lblSpell
            // 
            lblSpell.BackColor = Color.Transparent;
            lblSpell.Location = new Point(280, 56);
            lblSpell.Name = "lblSpell";
            lblSpell.Size = new Size(33, 17);
            lblSpell.TabIndex = 4;
            lblSpell.Text = "1";
            lblSpell.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fraVitals
            // 
            fraVitals.Controls.Add(scrlVitalMod);
            fraVitals.Controls.Add(lblVitalMod);
            fraVitals.Controls.Add(lblVitalModCaption);
            fraVitals.Location = new Point(8, 128);
            fraVitals.Name = "fraVitals";
            fraVitals.Size = new Size(321, 97);
            fraVitals.TabIndex = 6;
            fraVitals.TabStop = false;
            fraVitals.Text = "Vitals Data";
            fraVitals.Visible = false;
            // 
            // scrlVitalMod
            // 
            scrlVitalMod.Location = new Point(88, 24);
            scrlVitalMod.Maximum = 255;
            scrlVitalMod.Name = "scrlVitalMod";
            scrlVitalMod.Size = new Size(193, 17);
            scrlVitalMod.TabIndex = 0;
            scrlVitalMod.Value = 1;
            // 
            // lblVitalMod
            // 
            lblVitalMod.BackColor = Color.Transparent;
            lblVitalMod.Location = new Point(280, 24);
            lblVitalMod.Name = "lblVitalMod";
            lblVitalMod.Size = new Size(33, 17);
            lblVitalMod.TabIndex = 1;
            lblVitalMod.Text = "1";
            lblVitalMod.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVitalModCaption
            // 
            lblVitalModCaption.BackColor = Color.Transparent;
            lblVitalModCaption.Location = new Point(8, 24);
            lblVitalModCaption.Name = "lblVitalModCaption";
            lblVitalModCaption.Size = new Size(100, 23);
            lblVitalModCaption.TabIndex = 2;
            lblVitalModCaption.Text = "Vital Mod";
            // 
            // fraEquipment
            // 
            fraEquipment.Controls.Add(scrlStrength);
            fraEquipment.Controls.Add(scrlDurability);
            fraEquipment.Controls.Add(lblStrength);
            fraEquipment.Controls.Add(lblDurability);
            fraEquipment.Controls.Add(lblStrengthCaption);
            fraEquipment.Controls.Add(lblDurabilityCaption);
            fraEquipment.Location = new Point(8, 128);
            fraEquipment.Name = "fraEquipment";
            fraEquipment.Size = new Size(321, 97);
            fraEquipment.TabIndex = 7;
            fraEquipment.TabStop = false;
            fraEquipment.Text = "Equipment Data";
            fraEquipment.Visible = false;
            // 
            // scrlStrength
            // 
            scrlStrength.Location = new Point(88, 64);
            scrlStrength.Maximum = 255;
            scrlStrength.Name = "scrlStrength";
            scrlStrength.Size = new Size(193, 17);
            scrlStrength.TabIndex = 0;
            scrlStrength.Value = 1;
            // 
            // scrlDurability
            // 
            scrlDurability.Location = new Point(88, 32);
            scrlDurability.Maximum = 2000;
            scrlDurability.Name = "scrlDurability";
            scrlDurability.Size = new Size(193, 17);
            scrlDurability.TabIndex = 1;
            scrlDurability.Value = 50;
            // 
            // lblStrength
            // 
            lblStrength.BackColor = Color.Transparent;
            lblStrength.Location = new Point(280, 64);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(33, 17);
            lblStrength.TabIndex = 2;
            lblStrength.Text = "1";
            lblStrength.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDurability
            // 
            lblDurability.BackColor = Color.Transparent;
            lblDurability.Location = new Point(280, 32);
            lblDurability.Name = "lblDurability";
            lblDurability.Size = new Size(33, 17);
            lblDurability.TabIndex = 3;
            lblDurability.Text = "50";
            lblDurability.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStrengthCaption
            // 
            lblStrengthCaption.BackColor = Color.Transparent;
            lblStrengthCaption.Location = new Point(8, 64);
            lblStrengthCaption.Name = "lblStrengthCaption";
            lblStrengthCaption.Size = new Size(100, 23);
            lblStrengthCaption.TabIndex = 4;
            lblStrengthCaption.Text = "Strength";
            // 
            // lblDurabilityCaption
            // 
            lblDurabilityCaption.BackColor = Color.Transparent;
            lblDurabilityCaption.Location = new Point(8, 32);
            lblDurabilityCaption.Name = "lblDurabilityCaption";
            lblDurabilityCaption.Size = new Size(100, 23);
            lblDurabilityCaption.TabIndex = 5;
            lblDurabilityCaption.Text = "Durability";
            // 
            // lblPic
            // 
            lblPic.BackColor = Color.Transparent;
            lblPic.Location = new Point(256, 40);
            lblPic.Name = "lblPic";
            lblPic.Size = new Size(33, 17);
            lblPic.TabIndex = 8;
            lblPic.Text = "0";
            lblPic.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPicCaption
            // 
            lblPicCaption.BackColor = Color.Transparent;
            lblPicCaption.Location = new Point(8, 40);
            lblPicCaption.Name = "lblPicCaption";
            lblPicCaption.Size = new Size(100, 23);
            lblPicCaption.TabIndex = 9;
            lblPicCaption.Text = "Pic";
            // 
            // lblNameCaption
            // 
            lblNameCaption.BackColor = Color.Transparent;
            lblNameCaption.Location = new Point(8, 8);
            lblNameCaption.Name = "lblNameCaption";
            lblNameCaption.Size = new Size(100, 23);
            lblNameCaption.TabIndex = 10;
            lblNameCaption.Text = "Name";
            // 
            // ItemEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 265);
            Controls.Add(cmdBack);
            Controls.Add(picItems);
            Controls.Add(picPic);
            Controls.Add(scrlPic);
            Controls.Add(cmdCancel);
            Controls.Add(cmdSave);
            Controls.Add(txtName);
            Controls.Add(cmbType);
            Controls.Add(fraSpell);
            Controls.Add(fraVitals);
            Controls.Add(fraEquipment);
            Controls.Add(lblPic);
            Controls.Add(lblPicCaption);
            Controls.Add(lblNameCaption);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Editor";
            ((System.ComponentModel.ISupportInitialize)picItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPic).EndInit();
            fraSpell.ResumeLayout(false);
            fraVitals.ResumeLayout(false);
            fraEquipment.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}