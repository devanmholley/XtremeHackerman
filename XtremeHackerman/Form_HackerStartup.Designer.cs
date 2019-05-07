namespace XtremeHackerman
{
    partial class Form_HackerStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HackerStartup));
            this.Hacker_WelcomeTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hacker_WelcomeTXT
            // 
            this.Hacker_WelcomeTXT.BackColor = System.Drawing.SystemColors.ControlText;
            this.Hacker_WelcomeTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hacker_WelcomeTXT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hacker_WelcomeTXT.ForeColor = System.Drawing.SystemColors.Window;
            this.Hacker_WelcomeTXT.Location = new System.Drawing.Point(15, 12);
            this.Hacker_WelcomeTXT.Multiline = true;
            this.Hacker_WelcomeTXT.Name = "Hacker_WelcomeTXT";
            this.Hacker_WelcomeTXT.ReadOnly = true;
            this.Hacker_WelcomeTXT.Size = new System.Drawing.Size(762, 322);
            this.Hacker_WelcomeTXT.TabIndex = 0;
            this.Hacker_WelcomeTXT.Text = resources.GetString("Hacker_WelcomeTXT.Text");
            this.Hacker_WelcomeTXT.TextChanged += new System.EventHandler(this.Hacker_WelcomeTXT_TextChanged);
            // 
            // Form_HackerStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hacker_WelcomeTXT);
            this.Name = "Form_HackerStartup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hacker_WelcomeTXT;
    }
}