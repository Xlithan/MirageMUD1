using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class TradeForm
    {
        private System.ComponentModel.IContainer components = null;

        private ListBox lstTrade;
        private Label Label11;
        private Label lblCancel;
        private Label lblDeal;
        private Label lblFixItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstTrade = new ListBox();
            Label11 = new Label();
            lblCancel = new Label();
            lblDeal = new Label();
            lblFixItem = new Label();
            SuspendLayout();
            // 
            // lstTrade
            // 
            lstTrade.BackColor = Color.White;
            lstTrade.BorderStyle = BorderStyle.FixedSingle;
            lstTrade.Font = new Font("Arial", 8.25F);
            lstTrade.ForeColor = Color.Black;
            lstTrade.ItemHeight = 14;
            lstTrade.Location = new Point(240, 48);
            lstTrade.Name = "lstTrade";
            lstTrade.Size = new Size(217, 128);
            lstTrade.TabIndex = 0;
            // 
            // Label11
            // 
            Label11.BackColor = Color.Transparent;
            Label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(264, 16);
            Label11.Name = "Label11";
            Label11.Size = new Size(169, 25);
            Label11.TabIndex = 4;
            Label11.Text = "Trade";
            Label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCancel
            // 
            lblCancel.BackColor = Color.Transparent;
            lblCancel.Font = new Font("Tahoma", 9.75F);
            lblCancel.ForeColor = Color.White;
            lblCancel.Location = new Point(416, 272);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(61, 17);
            lblCancel.TabIndex = 3;
            lblCancel.Text = "Cancel";
            lblCancel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeal
            // 
            lblDeal.BackColor = Color.Transparent;
            lblDeal.Font = new Font("Tahoma", 9.75F);
            lblDeal.ForeColor = Color.White;
            lblDeal.Location = new Point(224, 192);
            lblDeal.Name = "lblDeal";
            lblDeal.Size = new Size(61, 17);
            lblDeal.TabIndex = 2;
            lblDeal.Text = "Deal";
            lblDeal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFixItem
            // 
            lblFixItem.BackColor = Color.Transparent;
            lblFixItem.Font = new Font("Tahoma", 9.75F);
            lblFixItem.ForeColor = Color.White;
            lblFixItem.Location = new Point(400, 192);
            lblFixItem.Name = "lblFixItem";
            lblFixItem.Size = new Size(61, 17);
            lblFixItem.TabIndex = 1;
            lblFixItem.Text = "Fix Item";
            lblFixItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TradeForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.menu;
            ClientSize = new Size(500, 300);
            ControlBox = false;
            Controls.Add(lstTrade);
            Controls.Add(Label11);
            Controls.Add(lblCancel);
            Controls.Add(lblDeal);
            Controls.Add(lblFixItem);
            Font = new Font("Arial", 12F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TradeForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trade";
            ResumeLayout(false);
        }

        #endregion
    }
}