using System;
using System.Windows.Forms;
using System.Drawing;

namespace Client.Forms
{
    partial class SendGetDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Tahoma", 9F);
            lblStatus.ForeColor = Color.Goldenrod;
            lblStatus.Location = new Point(9, 13);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(253, 15);
            lblStatus.TabIndex = 0;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SendGetDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Loading;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(269, 40);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SendGetDataForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SendGetDataForm";
            ResumeLayout(false);
        }

        #endregion
    }
}