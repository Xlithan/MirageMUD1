using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class TrainingForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbStat;
        private Label Label2;
        private Label Label11;
        private Label lblCancel;
        private Label lblTrain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbStat = new ComboBox();
            Label2 = new Label();
            Label11 = new Label();
            lblCancel = new Label();
            lblTrain = new Label();
            SuspendLayout();
            // 
            // cmbStat
            // 
            cmbStat.BackColor = Color.White;
            cmbStat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStat.Font = new Font("Tahoma", 9.75F);
            cmbStat.ForeColor = Color.Black;
            cmbStat.Location = new Point(216, 144);
            cmbStat.Name = "cmbStat";
            cmbStat.Size = new Size(265, 24);
            cmbStat.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Tahoma", 9.75F);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(216, 120);
            Label2.Name = "Label2";
            Label2.Size = new Size(225, 17);
            Label2.TabIndex = 4;
            Label2.Text = "What stat would you like to train?";
            // 
            // Label11
            // 
            Label11.BackColor = Color.Transparent;
            Label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(272, 16);
            Label11.Name = "Label11";
            Label11.Size = new Size(169, 25);
            Label11.TabIndex = 3;
            Label11.Text = "Training";
            Label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCancel
            // 
            lblCancel.BackColor = Color.Transparent;
            lblCancel.Font = new Font("Tahoma", 9.75F);
            lblCancel.ForeColor = Color.White;
            lblCancel.Location = new Point(424, 272);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(61, 17);
            lblCancel.TabIndex = 2;
            lblCancel.Text = "Cancel";
            lblCancel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrain
            // 
            lblTrain.BackColor = Color.Transparent;
            lblTrain.Font = new Font("Tahoma", 9.75F);
            lblTrain.ForeColor = Color.White;
            lblTrain.Location = new Point(320, 176);
            lblTrain.Name = "lblTrain";
            lblTrain.Size = new Size(61, 17);
            lblTrain.TabIndex = 1;
            lblTrain.Text = "Train";
            lblTrain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrainingForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.menu;
            ClientSize = new Size(500, 300);
            ControlBox = false;
            Controls.Add(cmbStat);
            Controls.Add(Label2);
            Controls.Add(Label11);
            Controls.Add(lblCancel);
            Controls.Add(lblTrain);
            Font = new Font("Arial", 12F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainingForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Training";
            ResumeLayout(false);
        }

        #endregion
    }
}