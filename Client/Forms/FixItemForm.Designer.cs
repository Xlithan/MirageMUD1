namespace Client.Forms
{
    partial class FixItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbItem;
        private Label lblTitle;
        private Label lblItemCaption;
        private Label lblFix;
        private Label lblCancel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixItemForm));
            cmbItem = new ComboBox();
            lblTitle = new Label();
            lblItemCaption = new Label();
            lblFix = new Label();
            lblCancel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.Location = new Point(271, 95);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(207, 23);
            cmbItem.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(208, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fix Item";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemCaption
            // 
            lblItemCaption.BackColor = Color.Transparent;
            lblItemCaption.ForeColor = Color.White;
            lblItemCaption.Location = new Point(205, 93);
            lblItemCaption.Name = "lblItemCaption";
            lblItemCaption.Size = new Size(60, 24);
            lblItemCaption.TabIndex = 1;
            lblItemCaption.Text = "Item :";
            lblItemCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFix
            // 
            lblFix.BackColor = Color.Transparent;
            lblFix.ForeColor = Color.White;
            lblFix.Location = new Point(300, 135);
            lblFix.Name = "lblFix";
            lblFix.Size = new Size(90, 20);
            lblFix.TabIndex = 2;
            lblFix.Text = "Fix";
            lblFix.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCancel
            // 
            lblCancel.BackColor = Color.Transparent;
            lblCancel.ForeColor = Color.White;
            lblCancel.Location = new Point(408, 268);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(80, 20);
            lblCancel.TabIndex = 3;
            lblCancel.Text = "Cancel";
            lblCancel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 58);
            label1.Name = "label1";
            label1.Size = new Size(211, 24);
            label1.TabIndex = 4;
            label1.Text = "Please select the item you wish to fix.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FixItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 300);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblItemCaption);
            Controls.Add(cmbItem);
            Controls.Add(lblFix);
            Controls.Add(lblCancel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FixItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fix Item";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}