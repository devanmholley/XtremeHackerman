namespace XtremeHackerman
{
    partial class Form_AntivirusScans
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
            this.MalwareDetected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MalwareDetected
            // 
            this.MalwareDetected.FormattingEnabled = true;
            this.MalwareDetected.Location = new System.Drawing.Point(1, 0);
            this.MalwareDetected.Name = "MalwareDetected";
            this.MalwareDetected.Size = new System.Drawing.Size(559, 485);
            this.MalwareDetected.TabIndex = 0;
            // 
            // Form_AntivirusScans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 485);
            this.Controls.Add(this.MalwareDetected);
            this.Name = "Form_AntivirusScans";
            this.Text = "Form_AntivirusScans";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MalwareDetected;
    }
}