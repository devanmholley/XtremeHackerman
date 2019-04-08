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
            this.antivirusControls_pnl = new System.Windows.Forms.Panel();
            this.antivirusScan_BTN = new System.Windows.Forms.Button();
            this.AntivirusStart_PNL = new System.Windows.Forms.Panel();
            this.AntivirusWelcome_LBL = new System.Windows.Forms.Label();
            this.antivirusControls_pnl.SuspendLayout();
            this.AntivirusStart_PNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // antivirusControls_pnl
            // 
            this.antivirusControls_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.antivirusControls_pnl.Controls.Add(this.antivirusScan_BTN);
            this.antivirusControls_pnl.Location = new System.Drawing.Point(16, 50);
            this.antivirusControls_pnl.Name = "antivirusControls_pnl";
            this.antivirusControls_pnl.Size = new System.Drawing.Size(162, 323);
            this.antivirusControls_pnl.TabIndex = 0;
            // 
            // antivirusScan_BTN
            // 
            this.antivirusScan_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.antivirusScan_BTN.FlatAppearance.BorderSize = 0;
            this.antivirusScan_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.antivirusScan_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.antivirusScan_BTN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antivirusScan_BTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.antivirusScan_BTN.Location = new System.Drawing.Point(16, 28);
            this.antivirusScan_BTN.Name = "antivirusScan_BTN";
            this.antivirusScan_BTN.Size = new System.Drawing.Size(63, 30);
            this.antivirusScan_BTN.TabIndex = 0;
            this.antivirusScan_BTN.Text = "Scan";
            this.antivirusScan_BTN.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.antivirusScan_BTN.UseVisualStyleBackColor = true;
            this.antivirusScan_BTN.Click += new System.EventHandler(this.antivirusScan_BTN_Click);
            // 
            // AntivirusStart_PNL
            // 
            this.AntivirusStart_PNL.Controls.Add(this.AntivirusWelcome_LBL);
            this.AntivirusStart_PNL.Location = new System.Drawing.Point(207, 50);
            this.AntivirusStart_PNL.Name = "AntivirusStart_PNL";
            this.AntivirusStart_PNL.Size = new System.Drawing.Size(561, 323);
            this.AntivirusStart_PNL.TabIndex = 1;
            // 
            // AntivirusWelcome_LBL
            // 
            this.AntivirusWelcome_LBL.AutoSize = true;
            this.AntivirusWelcome_LBL.Font = new System.Drawing.Font("Meiryo UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntivirusWelcome_LBL.Location = new System.Drawing.Point(39, 28);
            this.AntivirusWelcome_LBL.Name = "AntivirusWelcome_LBL";
            this.AntivirusWelcome_LBL.Size = new System.Drawing.Size(487, 85);
            this.AntivirusWelcome_LBL.TabIndex = 0;
            this.AntivirusWelcome_LBL.Text = "Best Antivirus";
            // 
            // Form_Anitvirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AntivirusStart_PNL);
            this.Controls.Add(this.antivirusControls_pnl);
            this.Name = "Form_Anitvirus";
            this.Text = "Form1";
            this.antivirusControls_pnl.ResumeLayout(false);
            this.AntivirusStart_PNL.ResumeLayout(false);
            this.AntivirusStart_PNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel antivirusControls_pnl;
        private System.Windows.Forms.Button antivirusScan_BTN;
        private System.Windows.Forms.Panel AntivirusStart_PNL;
        private System.Windows.Forms.Label AntivirusWelcome_LBL;
    }
}