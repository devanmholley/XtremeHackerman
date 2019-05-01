namespace XtremeHackerman
{
    partial class Form_Ransomware
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ransomware));
	    this.label_Warning = new System.Windows.Forms.Label();
	    this.Label_Destroy_Warning = new System.Windows.Forms.Label();
	    this.TB_Ransomeware_Description = new System.Windows.Forms.TextBox();
	    this.PB_Ransom_Icon = new System.Windows.Forms.PictureBox();
	    this.Label_date = new System.Windows.Forms.Label();
	    this.Btn_Next_Ransom = new System.Windows.Forms.Button();
	    this.RightPanel = new System.Windows.Forms.Panel();
	    this.LeftPanel = new System.Windows.Forms.Panel();
	    ((System.ComponentModel.ISupportInitialize)(this.PB_Ransom_Icon)).BeginInit();
	    this.RightPanel.SuspendLayout();
	    this.LeftPanel.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // label_Warning
	    // 
	    this.label_Warning.Dock = System.Windows.Forms.DockStyle.Top;
	    this.label_Warning.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.label_Warning.ForeColor = System.Drawing.Color.White;
	    this.label_Warning.Location = new System.Drawing.Point(0, 0);
	    this.label_Warning.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.label_Warning.Name = "label_Warning";
	    this.label_Warning.Size = new System.Drawing.Size(1936, 150);
	    this.label_Warning.TabIndex = 0;
	    this.label_Warning.Text = "Your personal files are encrypted!";
	    this.label_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // Label_Destroy_Warning
	    // 
	    this.Label_Destroy_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	    this.Label_Destroy_Warning.AutoSize = true;
	    this.Label_Destroy_Warning.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Label_Destroy_Warning.ForeColor = System.Drawing.Color.White;
	    this.Label_Destroy_Warning.Location = new System.Drawing.Point(163, 1219);
	    this.Label_Destroy_Warning.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.Label_Destroy_Warning.Name = "Label_Destroy_Warning";
	    this.Label_Destroy_Warning.Size = new System.Drawing.Size(966, 76);
	    this.Label_Destroy_Warning.TabIndex = 2;
	    this.Label_Destroy_Warning.Text = "The private key will be destroyed on:";
	    this.Label_Destroy_Warning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    // 
	    // TB_Ransomeware_Description
	    // 
	    this.TB_Ransomeware_Description.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
	    this.TB_Ransomeware_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
	    this.TB_Ransomeware_Description.BackColor = System.Drawing.Color.White;
	    this.TB_Ransomeware_Description.Enabled = false;
	    this.TB_Ransomeware_Description.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.TB_Ransomeware_Description.HideSelection = false;
	    this.TB_Ransomeware_Description.Location = new System.Drawing.Point(32, 172);
	    this.TB_Ransomeware_Description.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.TB_Ransomeware_Description.Multiline = true;
	    this.TB_Ransomeware_Description.Name = "TB_Ransomeware_Description";
	    this.TB_Ransomeware_Description.ReadOnly = true;
	    this.TB_Ransomeware_Description.ShortcutsEnabled = false;
	    this.TB_Ransomeware_Description.Size = new System.Drawing.Size(1865, 1339);
	    this.TB_Ransomeware_Description.TabIndex = 3;
	    this.TB_Ransomeware_Description.TabStop = false;
	    this.TB_Ransomeware_Description.Text = resources.GetString("TB_Ransomeware_Description.Text");
	    // 
	    // PB_Ransom_Icon
	    // 
	    this.PB_Ransom_Icon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Ransomware_Icon;
	    this.PB_Ransom_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.PB_Ransom_Icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Ransom_Icon.InitialImage")));
	    this.PB_Ransom_Icon.Location = new System.Drawing.Point(35, 31);
	    this.PB_Ransom_Icon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.PB_Ransom_Icon.Name = "PB_Ransom_Icon";
	    this.PB_Ransom_Icon.Size = new System.Drawing.Size(1232, 1116);
	    this.PB_Ransom_Icon.TabIndex = 1;
	    this.PB_Ransom_Icon.TabStop = false;
	    // 
	    // Label_date
	    // 
	    this.Label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	    this.Label_date.AutoSize = true;
	    this.Label_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Label_date.ForeColor = System.Drawing.Color.White;
	    this.Label_date.Location = new System.Drawing.Point(387, 1340);
	    this.Label_date.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.Label_date.Name = "Label_date";
	    this.Label_date.Size = new System.Drawing.Size(484, 55);
	    this.Label_date.TabIndex = 5;
	    this.Label_date.Text = "4/4/2019 10:44:43 AM";
	    this.Label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // Btn_Next_Ransom
	    // 
	    this.Btn_Next_Ransom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
	    this.Btn_Next_Ransom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Btn_Next_Ransom.Location = new System.Drawing.Point(1569, 1551);
	    this.Btn_Next_Ransom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Btn_Next_Ransom.Name = "Btn_Next_Ransom";
	    this.Btn_Next_Ransom.Size = new System.Drawing.Size(328, 117);
	    this.Btn_Next_Ransom.TabIndex = 7;
	    this.Btn_Next_Ransom.Text = "Next";
	    this.Btn_Next_Ransom.UseVisualStyleBackColor = true;
	    this.Btn_Next_Ransom.Click += new System.EventHandler(this.Btn_Next_Ransom_Click);
	    // 
	    // RightPanel
	    // 
	    this.RightPanel.Controls.Add(this.Btn_Next_Ransom);
	    this.RightPanel.Controls.Add(this.TB_Ransomeware_Description);
	    this.RightPanel.Controls.Add(this.label_Warning);
	    this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.RightPanel.Location = new System.Drawing.Point(1277, 0);
	    this.RightPanel.Name = "RightPanel";
	    this.RightPanel.Size = new System.Drawing.Size(1936, 1712);
	    this.RightPanel.TabIndex = 8;
	    // 
	    // LeftPanel
	    // 
	    this.LeftPanel.Controls.Add(this.Label_date);
	    this.LeftPanel.Controls.Add(this.Label_Destroy_Warning);
	    this.LeftPanel.Controls.Add(this.PB_Ransom_Icon);
	    this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
	    this.LeftPanel.Location = new System.Drawing.Point(0, 0);
	    this.LeftPanel.Name = "LeftPanel";
	    this.LeftPanel.Size = new System.Drawing.Size(1277, 1712);
	    this.LeftPanel.TabIndex = 0;
	    // 
	    // Form_Ransomware
	    // 
	    this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackColor = System.Drawing.Color.Red;
	    this.ClientSize = new System.Drawing.Size(3213, 1712);
	    this.ControlBox = false;
	    this.Controls.Add(this.RightPanel);
	    this.Controls.Add(this.LeftPanel);
	    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.MaximizeBox = false;
	    this.MinimizeBox = false;
	    this.Name = "Form_Ransomware";
	    this.ShowIcon = false;
	    this.Text = "Haha! Gotcha!";
	    this.TopMost = true;
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    ((System.ComponentModel.ISupportInitialize)(this.PB_Ransom_Icon)).EndInit();
	    this.RightPanel.ResumeLayout(false);
	    this.RightPanel.PerformLayout();
	    this.LeftPanel.ResumeLayout(false);
	    this.LeftPanel.PerformLayout();
	    this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.PictureBox PB_Ransom_Icon;
        private System.Windows.Forms.Label Label_Destroy_Warning;
        private System.Windows.Forms.TextBox TB_Ransomeware_Description;
        private System.Windows.Forms.Label Label_date;
        private System.Windows.Forms.Button Btn_Next_Ransom;
	private System.Windows.Forms.Panel RightPanel;
	private System.Windows.Forms.Panel LeftPanel;
    }
}