namespace XtremeHackerman
{
    partial class Form_Anitvirus
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
            this.antivirusScan_BTN = new System.Windows.Forms.Button();
            this.AntivirusStart_PNL = new System.Windows.Forms.Panel();
            this.AntivirusWelcome_LBL = new System.Windows.Forms.Label();
            this.AntiVirus_scanPNL = new System.Windows.Forms.Panel();
            this.Antivirus_ScanTXT = new System.Windows.Forms.Label();
            this.AntivirusStart_PNL.SuspendLayout();
            this.AntiVirus_scanPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // antivirusScan_BTN
            // 
            this.antivirusScan_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.antivirusScan_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.antivirusScan_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.antivirusScan_BTN.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antivirusScan_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.antivirusScan_BTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.antivirusScan_BTN.Location = new System.Drawing.Point(218, 169);
            this.antivirusScan_BTN.Name = "antivirusScan_BTN";
            this.antivirusScan_BTN.Size = new System.Drawing.Size(114, 60);
            this.antivirusScan_BTN.TabIndex = 0;
            this.antivirusScan_BTN.Text = "Scan";
            this.antivirusScan_BTN.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.antivirusScan_BTN.UseVisualStyleBackColor = true;
            this.antivirusScan_BTN.Click += new System.EventHandler(this.antivirusScan_BTN_Click);
            // 
            // AntivirusStart_PNL
            // 
            this.AntivirusStart_PNL.Controls.Add(this.antivirusScan_BTN);
            this.AntivirusStart_PNL.Controls.Add(this.AntivirusWelcome_LBL);
            this.AntivirusStart_PNL.Location = new System.Drawing.Point(37, 18);
            this.AntivirusStart_PNL.Name = "AntivirusStart_PNL";
            this.AntivirusStart_PNL.Size = new System.Drawing.Size(561, 323);
            this.AntivirusStart_PNL.TabIndex = 1;
            // 
            // AntivirusWelcome_LBL
            // 
            this.AntivirusWelcome_LBL.AutoSize = true;
            this.AntivirusWelcome_LBL.Font = new System.Drawing.Font("Meiryo UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntivirusWelcome_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AntivirusWelcome_LBL.Location = new System.Drawing.Point(39, 28);
            this.AntivirusWelcome_LBL.Name = "AntivirusWelcome_LBL";
            this.AntivirusWelcome_LBL.Size = new System.Drawing.Size(487, 85);
            this.AntivirusWelcome_LBL.TabIndex = 0;
            this.AntivirusWelcome_LBL.Text = "Best Antivirus";
            // 
            // AntiVirus_scanPNL
            // 
            this.AntiVirus_scanPNL.Controls.Add(this.Antivirus_ScanTXT);
            this.AntiVirus_scanPNL.Controls.Add(this.AntivirusStart_PNL);
            this.AntiVirus_scanPNL.Enabled = false;
            this.AntiVirus_scanPNL.Location = new System.Drawing.Point(74, 28);
            this.AntiVirus_scanPNL.Name = "AntiVirus_scanPNL";
            this.AntiVirus_scanPNL.Size = new System.Drawing.Size(651, 366);
            this.AntiVirus_scanPNL.TabIndex = 2;
            this.AntiVirus_scanPNL.Visible = false;
            // 
            // Antivirus_ScanTXT
            // 
            this.Antivirus_ScanTXT.AutoSize = true;
            this.Antivirus_ScanTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antivirus_ScanTXT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Antivirus_ScanTXT.Location = new System.Drawing.Point(22, 18);
            this.Antivirus_ScanTXT.Name = "Antivirus_ScanTXT";
            this.Antivirus_ScanTXT.Size = new System.Drawing.Size(120, 25);
            this.Antivirus_ScanTXT.TabIndex = 2;
            this.Antivirus_ScanTXT.Text = "Scanning...";
            this.Antivirus_ScanTXT.Visible = false;
            this.Antivirus_ScanTXT.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Anitvirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AntiVirus_scanPNL);
            this.Name = "Form_Anitvirus";
            this.Text = "Form1";
            this.AntivirusStart_PNL.ResumeLayout(false);
            this.AntivirusStart_PNL.PerformLayout();
            this.AntiVirus_scanPNL.ResumeLayout(false);
            this.AntiVirus_scanPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button antivirusScan_BTN;
        private System.Windows.Forms.Panel AntivirusStart_PNL;
        private System.Windows.Forms.Label AntivirusWelcome_LBL;
        private System.Windows.Forms.Panel AntiVirus_scanPNL;
        private System.Windows.Forms.Label Antivirus_ScanTXT;
    }
}