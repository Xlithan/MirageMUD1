namespace Client.Forms
{
    partial class DebugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Button btnClear;

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

        private void InitializeComponent()
        {
            txtDebug = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDebug
            // 
            txtDebug.BackColor = Color.White;
            txtDebug.Font = new Font("Consolas", 9F);
            txtDebug.ForeColor = Color.Black;
            txtDebug.Location = new Point(12, 12);
            txtDebug.Multiline = true;
            txtDebug.Name = "txtDebug";
            txtDebug.ReadOnly = true;
            txtDebug.ScrollBars = ScrollBars.Vertical;
            txtDebug.Size = new Size(460, 300);
            txtDebug.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 320);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            // 
            // DebugForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(txtDebug);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DebugForm";
            Text = "Debug Window";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}