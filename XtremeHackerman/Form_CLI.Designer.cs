namespace XtremeHackerman
{
    partial class Form_CLI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CLI));
            this.cliText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cliText
            // 
            this.cliText.BackColor = System.Drawing.Color.Black;
            this.cliText.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliText.ForeColor = System.Drawing.Color.White;
            this.cliText.Location = new System.Drawing.Point(0, 0);
            this.cliText.Multiline = true;
            this.cliText.Name = "cliText";
            this.cliText.Size = new System.Drawing.Size(801, 450);
            this.cliText.TabIndex = 0;
            this.cliText.TextChanged += new System.EventHandler(this.cliText_TextChanged);
            this.cliText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cliText_KeyDown);
            // 
            // Form_CLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cliText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CLI";
            this.Text = "C:\\WINDOWS\\System32\\command.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cliText;
    }
}