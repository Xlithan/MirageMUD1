using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class ShopEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button cmdBack;
        private Button cmdUpdate;
        private Button cmdSave;
        private Button cmdCancel;
        private CheckBox chkFixesItems;
        private TextBox txtItemGetValue;
        private ComboBox cmbItemGet;
        private TextBox txtItemGiveValue;
        private ComboBox cmbItemGive;
        private ListBox lstTradeItem;
        private TextBox txtLeaveSay;
        private TextBox txtName;
        private TextBox txtJoinSay;
        private Label lblValueGet;
        private Label lblItemGet;
        private Label lblValueGive;
        private Label lblItemGive;
        private Label lblLeaveSay;
        private Label lblName;
        private Label lblJoinSay;

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
            cmdUpdate = new Button();
            cmdSave = new Button();
            cmdCancel = new Button();
            chkFixesItems = new CheckBox();
            txtItemGetValue = new TextBox();
            cmbItemGet = new ComboBox();
            txtItemGiveValue = new TextBox();
            cmbItemGive = new ComboBox();
            lstTradeItem = new ListBox();
            txtLeaveSay = new TextBox();
            txtName = new TextBox();
            txtJoinSay = new TextBox();
            lblValueGet = new Label();
            lblItemGet = new Label();
            lblValueGive = new Label();
            lblItemGive = new Label();
            lblLeaveSay = new Label();
            lblName = new Label();
            lblJoinSay = new Label();
            SuspendLayout();
            // 
            // cmdBack
            // 
            cmdBack.Location = new Point(128, 400);
            cmdBack.Name = "cmdBack";
            cmdBack.Size = new Size(113, 25);
            cmdBack.TabIndex = 18;
            cmdBack.Text = "Back To Index";
            // 
            // cmdUpdate
            // 
            cmdUpdate.Location = new Point(184, 232);
            cmdUpdate.Name = "cmdUpdate";
            cmdUpdate.Size = new Size(169, 23);
            cmdUpdate.TabIndex = 15;
            cmdUpdate.Text = "Update";
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(8, 400);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(113, 25);
            cmdSave.TabIndex = 17;
            cmdSave.Text = "Save";
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(240, 400);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(113, 25);
            cmdCancel.TabIndex = 19;
            cmdCancel.Text = "Cancel";
            // 
            // chkFixesItems
            // 
            chkFixesItems.Location = new Point(8, 104);
            chkFixesItems.Name = "chkFixesItems";
            chkFixesItems.Size = new Size(345, 25);
            chkFixesItems.TabIndex = 6;
            chkFixesItems.Text = "Fixes Items";
            // 
            // txtItemGetValue
            // 
            txtItemGetValue.Location = new Point(88, 232);
            txtItemGetValue.Name = "txtItemGetValue";
            txtItemGetValue.Size = new Size(89, 23);
            txtItemGetValue.TabIndex = 14;
            txtItemGetValue.Text = "1";
            txtItemGetValue.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbItemGet
            // 
            cmbItemGet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemGet.Location = new Point(88, 200);
            cmbItemGet.Name = "cmbItemGet";
            cmbItemGet.Size = new Size(265, 24);
            cmbItemGet.TabIndex = 12;
            // 
            // txtItemGiveValue
            // 
            txtItemGiveValue.Location = new Point(88, 168);
            txtItemGiveValue.Name = "txtItemGiveValue";
            txtItemGiveValue.Size = new Size(89, 23);
            txtItemGiveValue.TabIndex = 10;
            txtItemGiveValue.Text = "1";
            txtItemGiveValue.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbItemGive
            // 
            cmbItemGive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemGive.Location = new Point(88, 136);
            cmbItemGive.Name = "cmbItemGive";
            cmbItemGive.Size = new Size(265, 24);
            cmbItemGive.TabIndex = 8;
            // 
            // lstTradeItem
            // 
            lstTradeItem.Location = new Point(8, 264);
            lstTradeItem.Name = "lstTradeItem";
            lstTradeItem.Size = new Size(345, 132);
            lstTradeItem.TabIndex = 16;
            // 
            // txtLeaveSay
            // 
            txtLeaveSay.Location = new Point(88, 72);
            txtLeaveSay.Name = "txtLeaveSay";
            txtLeaveSay.Size = new Size(265, 23);
            txtLeaveSay.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 23);
            txtName.TabIndex = 1;
            // 
            // txtJoinSay
            // 
            txtJoinSay.Location = new Point(88, 40);
            txtJoinSay.Name = "txtJoinSay";
            txtJoinSay.Size = new Size(265, 23);
            txtJoinSay.TabIndex = 3;
            // 
            // lblValueGet
            // 
            lblValueGet.BackColor = Color.Transparent;
            lblValueGet.Location = new Point(8, 232);
            lblValueGet.Name = "lblValueGet";
            lblValueGet.Size = new Size(73, 25);
            lblValueGet.TabIndex = 13;
            lblValueGet.Text = "Value";
            // 
            // lblItemGet
            // 
            lblItemGet.BackColor = Color.Transparent;
            lblItemGet.Location = new Point(8, 200);
            lblItemGet.Name = "lblItemGet";
            lblItemGet.Size = new Size(73, 25);
            lblItemGet.TabIndex = 11;
            lblItemGet.Text = "Item Get";
            // 
            // lblValueGive
            // 
            lblValueGive.BackColor = Color.Transparent;
            lblValueGive.Location = new Point(8, 168);
            lblValueGive.Name = "lblValueGive";
            lblValueGive.Size = new Size(73, 25);
            lblValueGive.TabIndex = 9;
            lblValueGive.Text = "Value";
            // 
            // lblItemGive
            // 
            lblItemGive.BackColor = Color.Transparent;
            lblItemGive.Location = new Point(8, 136);
            lblItemGive.Name = "lblItemGive";
            lblItemGive.Size = new Size(73, 25);
            lblItemGive.TabIndex = 7;
            lblItemGive.Text = "Item Give";
            // 
            // lblLeaveSay
            // 
            lblLeaveSay.BackColor = Color.Transparent;
            lblLeaveSay.Location = new Point(8, 72);
            lblLeaveSay.Name = "lblLeaveSay";
            lblLeaveSay.Size = new Size(73, 25);
            lblLeaveSay.TabIndex = 4;
            lblLeaveSay.Text = "Leave Say";
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Location = new Point(8, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblJoinSay
            // 
            lblJoinSay.BackColor = Color.Transparent;
            lblJoinSay.Location = new Point(8, 40);
            lblJoinSay.Name = "lblJoinSay";
            lblJoinSay.Size = new Size(73, 25);
            lblJoinSay.TabIndex = 2;
            lblJoinSay.Text = "Join Say";
            // 
            // ShopEditorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(369, 457);
            ControlBox = false;
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblJoinSay);
            Controls.Add(txtJoinSay);
            Controls.Add(lblLeaveSay);
            Controls.Add(txtLeaveSay);
            Controls.Add(chkFixesItems);
            Controls.Add(lblItemGive);
            Controls.Add(cmbItemGive);
            Controls.Add(lblValueGive);
            Controls.Add(txtItemGiveValue);
            Controls.Add(lblItemGet);
            Controls.Add(cmbItemGet);
            Controls.Add(lblValueGet);
            Controls.Add(txtItemGetValue);
            Controls.Add(cmdUpdate);
            Controls.Add(lstTradeItem);
            Controls.Add(cmdSave);
            Controls.Add(cmdBack);
            Controls.Add(cmdCancel);
            Font = new Font("Tahoma", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShopEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}