namespace XtremeHackerman
{
    partial class Form_HackerTerminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.HackerTerminal_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HackerTerminal_TXT
            // 
            this.HackerTerminal_TXT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HackerTerminal_TXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HackerTerminal_TXT.Dock = System.Windows.Forms.DockStyle.Top;
            this.HackerTerminal_TXT.ForeColor = System.Drawing.Color.White;
            this.HackerTerminal_TXT.Location = new System.Drawing.Point(0, 0);
            this.HackerTerminal_TXT.Multiline = true;
            this.HackerTerminal_TXT.Name = "HackerTerminal_TXT";
            this.HackerTerminal_TXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HackerTerminal_TXT.Size = new System.Drawing.Size(933, 507);
            this.HackerTerminal_TXT.TabIndex = 0;
            this.HackerTerminal_TXT.TextChanged += new System.EventHandler(this.HackerTerminal_TXT_TextChanged);
            this.HackerTerminal_TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TerminalTxt_KeyDown);
            // 
            // Form_HackerTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.HackerTerminal_TXT);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form_HackerTerminal";
            this.Opacity = 0.75D;
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox HackerTerminal_TXT;
    }
}