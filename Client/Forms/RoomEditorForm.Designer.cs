using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    partial class RoomEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        // Top-level
        private Button cmdSave;
        private Button cmdCancel;
        private ComboBox cmbColor;
        private TextBox txtColor;

        // Frames
        private GroupBox fraRoomDesc;
        private GroupBox fraNPCs;
        private GroupBox fraItems;
        private GroupBox fraRoomLinks;
        private GroupBox fraBootSettings;
        private GroupBox fraMapSettings;

        // Room Description
        private TextBox txtName;
        private TextBox txtShortDesc;
        private TextBox txtLongDesc;
        private TextBox txtExitDesc;
        private Label lblRoomName;
        private Label lblShortDesc;
        private Label lblLongDesc;
        private Label lblExitDescription;

        // NPCs (5)
        private ComboBox cmbNpc1;
        private ComboBox cmbNpc2;
        private ComboBox cmbNpc3;
        private ComboBox cmbNpc4;
        private ComboBox cmbNpc5;

        // Items (5)
        private ComboBox cmbItem1;
        private ComboBox cmbItem2;
        private ComboBox cmbItem3;
        private ComboBox cmbItem4;
        private ComboBox cmbItem5;
        private TextBox txtAmount1;
        private TextBox txtAmount2;
        private TextBox txtAmount3;
        private TextBox txtAmount4;
        private TextBox txtAmount5;

        // Room Links
        private TextBox txtNorth;
        private TextBox txtSouth;
        private TextBox txtEast;
        private TextBox txtWest;
        private TextBox txtUp;
        private TextBox txtDown;
        private Label lblRoom;

        // Boot Settings
        private TextBox txtBootRoom;
        private Label lblBootRoom;

        // Map Settings
        private ComboBox cmbMoral;
        private ComboBox cmbShop;
        private Label lblMoral;
        private Label lblShop;
        private Label lblMusicLabel;
        private Label lblMusic;
        private Button cmdBrowse;
        private Button cmdRemove;
        private Button cmdPlay;
        private Button cmdStop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmdSave = new Button();
            cmdCancel = new Button();
            cmbColor = new ComboBox();
            txtColor = new TextBox();
            fraRoomDesc = new GroupBox();
            txtName = new TextBox();
            txtShortDesc = new TextBox();
            txtLongDesc = new TextBox();
            txtExitDesc = new TextBox();
            lblRoomName = new Label();
            lblShortDesc = new Label();
            lblLongDesc = new Label();
            lblExitDescription = new Label();
            fraNPCs = new GroupBox();
            cmbNpc1 = new ComboBox();
            cmbNpc2 = new ComboBox();
            cmbNpc3 = new ComboBox();
            cmbNpc4 = new ComboBox();
            cmbNpc5 = new ComboBox();
            fraItems = new GroupBox();
            cmbItem1 = new ComboBox();
            cmbItem2 = new ComboBox();
            cmbItem3 = new ComboBox();
            cmbItem4 = new ComboBox();
            cmbItem5 = new ComboBox();
            txtAmount1 = new TextBox();
            txtAmount2 = new TextBox();
            txtAmount3 = new TextBox();
            txtAmount4 = new TextBox();
            txtAmount5 = new TextBox();
            fraRoomLinks = new GroupBox();
            txtNorth = new TextBox();
            txtSouth = new TextBox();
            txtEast = new TextBox();
            txtWest = new TextBox();
            txtUp = new TextBox();
            txtDown = new TextBox();
            lblRoom = new Label();
            fraBootSettings = new GroupBox();
            txtBootRoom = new TextBox();
            lblBootRoom = new Label();
            fraMapSettings = new GroupBox();
            cmbMoral = new ComboBox();
            cmbShop = new ComboBox();
            lblMoral = new Label();
            lblShop = new Label();
            lblMusicLabel = new Label();
            cmdBrowse = new Button();
            cmdRemove = new Button();
            lblMusic = new Label();
            cmdPlay = new Button();
            cmdStop = new Button();
            fraRoomDesc.SuspendLayout();
            fraNPCs.SuspendLayout();
            fraItems.SuspendLayout();
            fraRoomLinks.SuspendLayout();
            fraBootSettings.SuspendLayout();
            fraMapSettings.SuspendLayout();
            SuspendLayout();
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(504, 432);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(265, 25);
            cmdSave.TabIndex = 0;
            cmdSave.Text = "Save Room";
            // 
            // cmdCancel
            // 
            cmdCancel.Location = new Point(504, 472);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(265, 25);
            cmdCancel.TabIndex = 1;
            cmdCancel.Text = "Cancel";
            // 
            // cmbColor
            // 
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.Location = new Point(224, 472);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(121, 24);
            cmbColor.TabIndex = 41;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(352, 472);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(137, 23);
            txtColor.TabIndex = 42;
            // 
            // fraRoomDesc
            // 
            fraRoomDesc.Controls.Add(txtName);
            fraRoomDesc.Controls.Add(txtShortDesc);
            fraRoomDesc.Controls.Add(txtLongDesc);
            fraRoomDesc.Controls.Add(txtExitDesc);
            fraRoomDesc.Controls.Add(lblRoomName);
            fraRoomDesc.Controls.Add(lblShortDesc);
            fraRoomDesc.Controls.Add(lblLongDesc);
            fraRoomDesc.Controls.Add(lblExitDescription);
            fraRoomDesc.Location = new Point(8, 8);
            fraRoomDesc.Name = "fraRoomDesc";
            fraRoomDesc.Size = new Size(481, 297);
            fraRoomDesc.TabIndex = 0;
            fraRoomDesc.TabStop = false;
            fraRoomDesc.Text = "Room Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 23);
            txtName.TabIndex = 29;
            // 
            // txtShortDesc
            // 
            txtShortDesc.Location = new Point(16, 80);
            txtShortDesc.MaxLength = 256;
            txtShortDesc.Multiline = true;
            txtShortDesc.Name = "txtShortDesc";
            txtShortDesc.Size = new Size(433, 49);
            txtShortDesc.TabIndex = 25;
            // 
            // txtLongDesc
            // 
            txtLongDesc.Location = new Point(16, 152);
            txtLongDesc.MaxLength = 512;
            txtLongDesc.Multiline = true;
            txtLongDesc.Name = "txtLongDesc";
            txtLongDesc.Size = new Size(433, 73);
            txtLongDesc.TabIndex = 26;
            // 
            // txtExitDesc
            // 
            txtExitDesc.Location = new Point(16, 248);
            txtExitDesc.MaxLength = 128;
            txtExitDesc.Multiline = true;
            txtExitDesc.Name = "txtExitDesc";
            txtExitDesc.Size = new Size(433, 41);
            txtExitDesc.TabIndex = 39;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(16, 32);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(82, 16);
            lblRoomName.TabIndex = 40;
            lblRoomName.Text = "Room Name:";
            // 
            // lblShortDesc
            // 
            lblShortDesc.AutoSize = true;
            lblShortDesc.Location = new Point(16, 64);
            lblShortDesc.Name = "lblShortDesc";
            lblShortDesc.Size = new Size(110, 16);
            lblShortDesc.TabIndex = 41;
            lblShortDesc.Text = "Short Description:";
            // 
            // lblLongDesc
            // 
            lblLongDesc.AutoSize = true;
            lblLongDesc.Location = new Point(16, 136);
            lblLongDesc.Name = "lblLongDesc";
            lblLongDesc.Size = new Size(106, 16);
            lblLongDesc.TabIndex = 42;
            lblLongDesc.Text = "Long Description:";
            // 
            // lblExitDescription
            // 
            lblExitDescription.AutoSize = true;
            lblExitDescription.Location = new Point(16, 232);
            lblExitDescription.Name = "lblExitDescription";
            lblExitDescription.Size = new Size(99, 16);
            lblExitDescription.TabIndex = 43;
            lblExitDescription.Text = "Exit Description:";
            // 
            // fraNPCs
            // 
            fraNPCs.Controls.Add(cmbNpc1);
            fraNPCs.Controls.Add(cmbNpc2);
            fraNPCs.Controls.Add(cmbNpc3);
            fraNPCs.Controls.Add(cmbNpc4);
            fraNPCs.Controls.Add(cmbNpc5);
            fraNPCs.Location = new Point(496, 8);
            fraNPCs.Name = "fraNPCs";
            fraNPCs.Size = new Size(281, 185);
            fraNPCs.TabIndex = 1;
            fraNPCs.TabStop = false;
            fraNPCs.Text = "NPCs";
            // 
            // cmbNpc1
            // 
            cmbNpc1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNpc1.Location = new Point(8, 24);
            cmbNpc1.Name = "cmbNpc1";
            cmbNpc1.Size = new Size(265, 24);
            cmbNpc1.TabIndex = 19;
            // 
            // cmbNpc2
            // 
            cmbNpc2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNpc2.Location = new Point(8, 56);
            cmbNpc2.Name = "cmbNpc2";
            cmbNpc2.Size = new Size(265, 24);
            cmbNpc2.TabIndex = 20;
            // 
            // cmbNpc3
            // 
            cmbNpc3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNpc3.Location = new Point(8, 88);
            cmbNpc3.Name = "cmbNpc3";
            cmbNpc3.Size = new Size(265, 24);
            cmbNpc3.TabIndex = 21;
            // 
            // cmbNpc4
            // 
            cmbNpc4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNpc4.Location = new Point(8, 120);
            cmbNpc4.Name = "cmbNpc4";
            cmbNpc4.Size = new Size(265, 24);
            cmbNpc4.TabIndex = 22;
            // 
            // cmbNpc5
            // 
            cmbNpc5.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNpc5.Location = new Point(8, 152);
            cmbNpc5.Name = "cmbNpc5";
            cmbNpc5.Size = new Size(265, 24);
            cmbNpc5.TabIndex = 23;
            // 
            // fraItems
            // 
            fraItems.Controls.Add(cmbItem1);
            fraItems.Controls.Add(cmbItem2);
            fraItems.Controls.Add(cmbItem3);
            fraItems.Controls.Add(cmbItem4);
            fraItems.Controls.Add(cmbItem5);
            fraItems.Controls.Add(txtAmount1);
            fraItems.Controls.Add(txtAmount2);
            fraItems.Controls.Add(txtAmount3);
            fraItems.Controls.Add(txtAmount4);
            fraItems.Controls.Add(txtAmount5);
            fraItems.Location = new Point(496, 200);
            fraItems.Name = "fraItems";
            fraItems.Size = new Size(281, 185);
            fraItems.TabIndex = 2;
            fraItems.TabStop = false;
            fraItems.Text = "Items";
            // 
            // cmbItem1
            // 
            cmbItem1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem1.Location = new Point(8, 24);
            cmbItem1.Name = "cmbItem1";
            cmbItem1.Size = new Size(193, 24);
            cmbItem1.TabIndex = 32;
            // 
            // cmbItem2
            // 
            cmbItem2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem2.Location = new Point(8, 56);
            cmbItem2.Name = "cmbItem2";
            cmbItem2.Size = new Size(193, 24);
            cmbItem2.TabIndex = 33;
            // 
            // cmbItem3
            // 
            cmbItem3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem3.Location = new Point(8, 88);
            cmbItem3.Name = "cmbItem3";
            cmbItem3.Size = new Size(193, 24);
            cmbItem3.TabIndex = 34;
            // 
            // cmbItem4
            // 
            cmbItem4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem4.Location = new Point(8, 120);
            cmbItem4.Name = "cmbItem4";
            cmbItem4.Size = new Size(193, 24);
            cmbItem4.TabIndex = 35;
            // 
            // cmbItem5
            // 
            cmbItem5.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem5.Location = new Point(8, 152);
            cmbItem5.Name = "cmbItem5";
            cmbItem5.Size = new Size(193, 24);
            cmbItem5.TabIndex = 36;
            // 
            // txtAmount1
            // 
            txtAmount1.Enabled = false;
            txtAmount1.Location = new Point(216, 24);
            txtAmount1.Name = "txtAmount1";
            txtAmount1.Size = new Size(57, 23);
            txtAmount1.TabIndex = 43;
            txtAmount1.Text = "0";
            // 
            // txtAmount2
            // 
            txtAmount2.Enabled = false;
            txtAmount2.Location = new Point(216, 56);
            txtAmount2.Name = "txtAmount2";
            txtAmount2.Size = new Size(57, 23);
            txtAmount2.TabIndex = 44;
            txtAmount2.Text = "0";
            // 
            // txtAmount3
            // 
            txtAmount3.Enabled = false;
            txtAmount3.Location = new Point(216, 88);
            txtAmount3.Name = "txtAmount3";
            txtAmount3.Size = new Size(57, 23);
            txtAmount3.TabIndex = 46;
            txtAmount3.Text = "0";
            // 
            // txtAmount4
            // 
            txtAmount4.Enabled = false;
            txtAmount4.Location = new Point(216, 120);
            txtAmount4.Name = "txtAmount4";
            txtAmount4.Size = new Size(57, 23);
            txtAmount4.TabIndex = 47;
            txtAmount4.Text = "0";
            // 
            // txtAmount5
            // 
            txtAmount5.Enabled = false;
            txtAmount5.Location = new Point(216, 152);
            txtAmount5.Name = "txtAmount5";
            txtAmount5.Size = new Size(57, 23);
            txtAmount5.TabIndex = 45;
            txtAmount5.Text = "0";
            // 
            // fraRoomLinks
            // 
            fraRoomLinks.Controls.Add(txtNorth);
            fraRoomLinks.Controls.Add(txtSouth);
            fraRoomLinks.Controls.Add(txtEast);
            fraRoomLinks.Controls.Add(txtWest);
            fraRoomLinks.Controls.Add(txtUp);
            fraRoomLinks.Controls.Add(txtDown);
            fraRoomLinks.Controls.Add(lblRoom);
            fraRoomLinks.Location = new Point(8, 312);
            fraRoomLinks.Name = "fraRoomLinks";
            fraRoomLinks.Size = new Size(193, 113);
            fraRoomLinks.TabIndex = 3;
            fraRoomLinks.TabStop = false;
            fraRoomLinks.Text = "Room Links";
            // 
            // txtNorth
            // 
            txtNorth.Location = new Point(56, 32);
            txtNorth.Name = "txtNorth";
            txtNorth.Size = new Size(33, 23);
            txtNorth.TabIndex = 3;
            txtNorth.Text = "0";
            txtNorth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSouth
            // 
            txtSouth.Location = new Point(56, 80);
            txtSouth.Name = "txtSouth";
            txtSouth.Size = new Size(33, 23);
            txtSouth.TabIndex = 4;
            txtSouth.Text = "0";
            txtSouth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEast
            // 
            txtEast.Location = new Point(96, 56);
            txtEast.Name = "txtEast";
            txtEast.Size = new Size(33, 23);
            txtEast.TabIndex = 5;
            txtEast.Text = "0";
            txtEast.TextAlign = HorizontalAlignment.Right;
            // 
            // txtWest
            // 
            txtWest.Location = new Point(16, 56);
            txtWest.Name = "txtWest";
            txtWest.Size = new Size(33, 23);
            txtWest.TabIndex = 6;
            txtWest.Text = "0";
            txtWest.TextAlign = HorizontalAlignment.Right;
            // 
            // txtUp
            // 
            txtUp.Enabled = false;
            txtUp.Location = new Point(144, 32);
            txtUp.Name = "txtUp";
            txtUp.Size = new Size(33, 23);
            txtUp.TabIndex = 37;
            txtUp.Text = "0";
            txtUp.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDown
            // 
            txtDown.Enabled = false;
            txtDown.Location = new Point(144, 80);
            txtDown.Name = "txtDown";
            txtDown.Size = new Size(33, 23);
            txtDown.TabIndex = 38;
            txtDown.Text = "0";
            txtDown.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRoom
            // 
            lblRoom.Location = new Point(8, 16);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(161, 17);
            lblRoom.TabIndex = 39;
            // 
            // fraBootSettings
            // 
            fraBootSettings.Controls.Add(txtBootRoom);
            fraBootSettings.Controls.Add(lblBootRoom);
            fraBootSettings.Location = new Point(8, 432);
            fraBootSettings.Name = "fraBootSettings";
            fraBootSettings.Size = new Size(193, 65);
            fraBootSettings.TabIndex = 4;
            fraBootSettings.TabStop = false;
            fraBootSettings.Text = "Boot Settings";
            // 
            // txtBootRoom
            // 
            txtBootRoom.Location = new Point(96, 24);
            txtBootRoom.Name = "txtBootRoom";
            txtBootRoom.Size = new Size(49, 23);
            txtBootRoom.TabIndex = 15;
            txtBootRoom.Text = "0";
            txtBootRoom.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBootRoom
            // 
            lblBootRoom.AutoSize = true;
            lblBootRoom.Location = new Point(16, 24);
            lblBootRoom.Name = "lblBootRoom";
            lblBootRoom.Size = new Size(69, 16);
            lblBootRoom.TabIndex = 16;
            lblBootRoom.Text = "Boot Room";
            // 
            // fraMapSettings
            // 
            fraMapSettings.Controls.Add(cmbMoral);
            fraMapSettings.Controls.Add(cmbShop);
            fraMapSettings.Controls.Add(lblMoral);
            fraMapSettings.Controls.Add(lblShop);
            fraMapSettings.Controls.Add(lblMusicLabel);
            fraMapSettings.Controls.Add(cmdBrowse);
            fraMapSettings.Controls.Add(cmdRemove);
            fraMapSettings.Controls.Add(lblMusic);
            fraMapSettings.Controls.Add(cmdPlay);
            fraMapSettings.Controls.Add(cmdStop);
            fraMapSettings.Location = new Point(224, 312);
            fraMapSettings.Name = "fraMapSettings";
            fraMapSettings.Size = new Size(265, 153);
            fraMapSettings.TabIndex = 5;
            fraMapSettings.TabStop = false;
            fraMapSettings.Text = "Room Settings";
            // 
            // cmbMoral
            // 
            cmbMoral.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMoral.Location = new Point(48, 24);
            cmbMoral.Name = "cmbMoral";
            cmbMoral.Size = new Size(161, 24);
            cmbMoral.TabIndex = 9;
            // 
            // cmbShop
            // 
            cmbShop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbShop.Location = new Point(48, 56);
            cmbShop.Name = "cmbShop";
            cmbShop.Size = new Size(161, 24);
            cmbShop.TabIndex = 10;
            // 
            // lblMoral
            // 
            lblMoral.AutoSize = true;
            lblMoral.Location = new Point(8, 24);
            lblMoral.Name = "lblMoral";
            lblMoral.Size = new Size(39, 16);
            lblMoral.TabIndex = 11;
            lblMoral.Text = "Moral";
            // 
            // lblShop
            // 
            lblShop.AutoSize = true;
            lblShop.Location = new Point(8, 56);
            lblShop.Name = "lblShop";
            lblShop.Size = new Size(36, 16);
            lblShop.TabIndex = 12;
            lblShop.Text = "Shop";
            // 
            // lblMusicLabel
            // 
            lblMusicLabel.AutoSize = true;
            lblMusicLabel.Location = new Point(8, 88);
            lblMusicLabel.Name = "lblMusicLabel";
            lblMusicLabel.Size = new Size(39, 16);
            lblMusicLabel.TabIndex = 13;
            lblMusicLabel.Text = "Music";
            // 
            // cmdBrowse
            // 
            cmdBrowse.Font = new Font("Tahoma", 8.25F);
            cmdBrowse.Location = new Point(48, 88);
            cmdBrowse.Name = "cmdBrowse";
            cmdBrowse.Size = new Size(89, 20);
            cmdBrowse.TabIndex = 50;
            cmdBrowse.Text = "Browse...";
            // 
            // cmdRemove
            // 
            cmdRemove.Font = new Font("Tahoma", 8.25F);
            cmdRemove.Location = new Point(144, 88);
            cmdRemove.Name = "cmdRemove";
            cmdRemove.Size = new Size(89, 20);
            cmdRemove.TabIndex = 52;
            cmdRemove.Text = "Remove";
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.Location = new Point(8, 128);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(68, 16);
            lblMusic.TabIndex = 53;
            lblMusic.Text = "Music.mp3";
            // 
            // cmdPlay
            // 
            cmdPlay.Font = new Font("Tahoma", 8.25F);
            cmdPlay.Location = new Point(139, 128);
            cmdPlay.Name = "cmdPlay";
            cmdPlay.Size = new Size(57, 20);
            cmdPlay.TabIndex = 48;
            cmdPlay.Text = "Play";
            // 
            // cmdStop
            // 
            cmdStop.Font = new Font("Tahoma", 8.25F);
            cmdStop.Location = new Point(200, 128);
            cmdStop.Name = "cmdStop";
            cmdStop.Size = new Size(57, 20);
            cmdStop.TabIndex = 49;
            cmdStop.Text = "Stop";
            // 
            // RoomEditorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(781, 505);
            ControlBox = false;
            Controls.Add(fraRoomDesc);
            Controls.Add(fraNPCs);
            Controls.Add(fraItems);
            Controls.Add(fraRoomLinks);
            Controls.Add(fraBootSettings);
            Controls.Add(fraMapSettings);
            Controls.Add(cmbColor);
            Controls.Add(txtColor);
            Controls.Add(cmdSave);
            Controls.Add(cmdCancel);
            Font = new Font("Tahoma", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoomEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Editor";
            fraRoomDesc.ResumeLayout(false);
            fraRoomDesc.PerformLayout();
            fraNPCs.ResumeLayout(false);
            fraItems.ResumeLayout(false);
            fraItems.PerformLayout();
            fraRoomLinks.ResumeLayout(false);
            fraRoomLinks.PerformLayout();
            fraBootSettings.ResumeLayout(false);
            fraBootSettings.PerformLayout();
            fraMapSettings.ResumeLayout(false);
            fraMapSettings.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}