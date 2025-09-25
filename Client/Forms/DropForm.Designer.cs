namespace Client.Forms
{
    partial class DropForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblDropPrompt;
        private System.Windows.Forms.TextBox txtDropAmount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

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
            lblDropPrompt = new Label();
            txtDropAmount = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblDropPrompt
            // 
            lblDropPrompt.Location = new Point(12, 15);
            lblDropPrompt.Name = "lblDropPrompt";
            lblDropPrompt.Size = new Size(103, 20);
            lblDropPrompt.TabIndex = 0;
            lblDropPrompt.Text = "Amount to Drop:";
            // 
            // txtDropAmount
            // 
            txtDropAmount.Location = new Point(121, 12);
            txtDropAmount.Name = "txtDropAmount";
            txtDropAmount.Size = new Size(147, 23);
            txtDropAmount.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 55);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(148, 55);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            // 
            // DropForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 90);
            Controls.Add(lblDropPrompt);
            Controls.Add(txtDropAmount);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DropForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Drop Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}