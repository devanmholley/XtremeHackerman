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
	    this.malwareListBox = new System.Windows.Forms.ListBox();
	    this.Header_LBL = new System.Windows.Forms.Label();
	    this.removeButton = new System.Windows.Forms.Button();
	    this.AntivirusStart_PNL.SuspendLayout();
	    this.AntiVirus_scanPNL.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // antivirusScan_BTN
	    // 
	    this.antivirusScan_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.antivirusScan_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
	    this.antivirusScan_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
	    this.antivirusScan_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.antivirusScan_BTN.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.antivirusScan_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
	    this.antivirusScan_BTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
	    this.antivirusScan_BTN.Location = new System.Drawing.Point(936, 607);
	    this.antivirusScan_BTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.antivirusScan_BTN.Name = "antivirusScan_BTN";
	    this.antivirusScan_BTN.Size = new System.Drawing.Size(304, 143);
	    this.antivirusScan_BTN.TabIndex = 0;
	    this.antivirusScan_BTN.Text = "Scan";
	    this.antivirusScan_BTN.UseVisualStyleBackColor = true;
	    this.antivirusScan_BTN.Click += new System.EventHandler(this.antivirusScan_BTN_Click);
	    // 
	    // AntivirusStart_PNL
	    // 
	    this.AntivirusStart_PNL.Controls.Add(this.antivirusScan_BTN);
	    this.AntivirusStart_PNL.Controls.Add(this.AntivirusWelcome_LBL);
	    this.AntivirusStart_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.AntivirusStart_PNL.Location = new System.Drawing.Point(0, 0);
	    this.AntivirusStart_PNL.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.AntivirusStart_PNL.Name = "AntivirusStart_PNL";
	    this.AntivirusStart_PNL.Size = new System.Drawing.Size(2133, 1073);
	    this.AntivirusStart_PNL.TabIndex = 1;
	    // 
	    // AntivirusWelcome_LBL
	    // 
	    this.AntivirusWelcome_LBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
	    this.AntivirusWelcome_LBL.AutoSize = true;
	    this.AntivirusWelcome_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.AntivirusWelcome_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
	    this.AntivirusWelcome_LBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
	    this.AntivirusWelcome_LBL.Location = new System.Drawing.Point(489, 9);
	    this.AntivirusWelcome_LBL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.AntivirusWelcome_LBL.Name = "AntivirusWelcome_LBL";
	    this.AntivirusWelcome_LBL.Size = new System.Drawing.Size(1099, 189);
	    this.AntivirusWelcome_LBL.TabIndex = 0;
	    this.AntivirusWelcome_LBL.Text = "Best Antivirus";
	    this.AntivirusWelcome_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // AntiVirus_scanPNL
	    // 
	    this.AntiVirus_scanPNL.Controls.Add(this.malwareListBox);
	    this.AntiVirus_scanPNL.Controls.Add(this.Header_LBL);
	    this.AntiVirus_scanPNL.Controls.Add(this.removeButton);
	    this.AntiVirus_scanPNL.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.AntiVirus_scanPNL.ForeColor = System.Drawing.Color.White;
	    this.AntiVirus_scanPNL.Location = new System.Drawing.Point(0, 0);
	    this.AntiVirus_scanPNL.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.AntiVirus_scanPNL.Name = "AntiVirus_scanPNL";
	    this.AntiVirus_scanPNL.Size = new System.Drawing.Size(2133, 1073);
	    this.AntiVirus_scanPNL.TabIndex = 2;
	    // 
	    // malwareListBox
	    // 
	    this.malwareListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
	    this.malwareListBox.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.malwareListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.malwareListBox.ForeColor = System.Drawing.Color.White;
	    this.malwareListBox.FormattingEnabled = true;
	    this.malwareListBox.ItemHeight = 61;
	    this.malwareListBox.Location = new System.Drawing.Point(0, 78);
	    this.malwareListBox.Name = "malwareListBox";
	    this.malwareListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
	    this.malwareListBox.Size = new System.Drawing.Size(2133, 935);
	    this.malwareListBox.TabIndex = 2;
	    // 
	    // Header_LBL
	    // 
	    this.Header_LBL.AutoSize = true;
	    this.Header_LBL.Dock = System.Windows.Forms.DockStyle.Top;
	    this.Header_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Header_LBL.ForeColor = System.Drawing.Color.White;
	    this.Header_LBL.Location = new System.Drawing.Point(0, 0);
	    this.Header_LBL.Name = "Header_LBL";
	    this.Header_LBL.Size = new System.Drawing.Size(496, 78);
	    this.Header_LBL.TabIndex = 0;
	    this.Header_LBL.Text = "Threats Found:";
	    this.Header_LBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    // 
	    // removeButton
	    // 
	    this.removeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.removeButton.ForeColor = System.Drawing.Color.Black;
	    this.removeButton.Location = new System.Drawing.Point(0, 1013);
	    this.removeButton.Name = "removeButton";
	    this.removeButton.Size = new System.Drawing.Size(2133, 60);
	    this.removeButton.TabIndex = 1;
	    this.removeButton.Text = "Remove All Threats";
	    this.removeButton.UseVisualStyleBackColor = true;
	    this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
	    // 
	    // Form_Anitvirus
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
	    this.ClientSize = new System.Drawing.Size(2133, 1073);
	    this.Controls.Add(this.AntivirusStart_PNL);
	    this.Controls.Add(this.AntiVirus_scanPNL);
	    this.ForeColor = System.Drawing.Color.White;
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_Anitvirus";
	    this.Text = "Antivirus";
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
	private System.Windows.Forms.Label Header_LBL;
	private System.Windows.Forms.Button removeButton;
	private System.Windows.Forms.ListBox malwareListBox;
    }
}