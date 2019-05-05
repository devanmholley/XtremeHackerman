namespace XtremeHackerman
{
    partial class Form_InternetBrowser
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InternetBrowser));
	    this.toolStrip1 = new System.Windows.Forms.ToolStrip();
	    this.Back = new System.Windows.Forms.ToolStripButton();
	    this.Forward = new System.Windows.Forms.ToolStripButton();
	    this.Refresh = new System.Windows.Forms.ToolStripButton();
	    this.Home = new System.Windows.Forms.ToolStripButton();
	    this.AddressBar = new System.Windows.Forms.ToolStripTextBox();
	    this.Search = new System.Windows.Forms.ToolStripButton();
	    this.Bookmarks = new System.Windows.Forms.ToolStripDropDownButton();
	    this.companyFirewallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.virusTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.errorLabel = new System.Windows.Forms.Label();
	    this.WebsitePanel = new System.Windows.Forms.Panel();
	    this.errorIcon = new System.Windows.Forms.PictureBox();
	    this.ErrorPanel = new System.Windows.Forms.Panel();
	    this.toolStrip1.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
	    this.ErrorPanel.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // toolStrip1
	    // 
	    this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.Refresh,
            this.Home,
            this.AddressBar,
            this.Search,
            this.Bookmarks});
	    this.toolStrip1.Location = new System.Drawing.Point(0, 0);
	    this.toolStrip1.Name = "toolStrip1";
	    this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.toolStrip1.Size = new System.Drawing.Size(2155, 48);
	    this.toolStrip1.TabIndex = 0;
	    this.toolStrip1.Text = "toolStrip1";
	    // 
	    // Back
	    // 
	    this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
	    this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.Back.Name = "Back";
	    this.Back.Size = new System.Drawing.Size(44, 45);
	    this.Back.Text = "Click to go backwards";
	    this.Back.Click += new System.EventHandler(this.Back_Click);
	    // 
	    // Forward
	    // 
	    this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.Forward.Image = ((System.Drawing.Image)(resources.GetObject("Forward.Image")));
	    this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.Forward.Name = "Forward";
	    this.Forward.Size = new System.Drawing.Size(44, 45);
	    this.Forward.Text = "Click to go forward";
	    this.Forward.Click += new System.EventHandler(this.Forward_Click);
	    // 
	    // Refresh
	    // 
	    this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
	    this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.Refresh.Name = "Refresh";
	    this.Refresh.Size = new System.Drawing.Size(44, 45);
	    this.Refresh.Text = "Refresh";
	    this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
	    // 
	    // Home
	    // 
	    this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
	    this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.Home.Name = "Home";
	    this.Home.Size = new System.Drawing.Size(44, 45);
	    this.Home.Text = "Home";
	    this.Home.Click += new System.EventHandler(this.Home_Click);
	    // 
	    // AddressBar
	    // 
	    this.AddressBar.Name = "AddressBar";
	    this.AddressBar.Size = new System.Drawing.Size(700, 48);
	    // 
	    // Search
	    // 
	    this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
	    this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.Search.Name = "Search";
	    this.Search.Size = new System.Drawing.Size(44, 45);
	    this.Search.Text = "Go";
	    this.Search.Click += new System.EventHandler(this.Search_Click);
	    // 
	    // Bookmarks
	    // 
	    this.Bookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.Bookmarks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyFirewallToolStripMenuItem,
            this.virusTotalToolStripMenuItem});
	    this.Bookmarks.Image = ((System.Drawing.Image)(resources.GetObject("Bookmarks.Image")));
	    this.Bookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.Bookmarks.Name = "Bookmarks";
	    this.Bookmarks.Size = new System.Drawing.Size(66, 45);
	    this.Bookmarks.Text = "Bookmarks";
	    // 
	    // companyFirewallToolStripMenuItem
	    // 
	    this.companyFirewallToolStripMenuItem.Name = "companyFirewallToolStripMenuItem";
	    this.companyFirewallToolStripMenuItem.Size = new System.Drawing.Size(347, 46);
	    this.companyFirewallToolStripMenuItem.Text = "Manage Firewall";
	    this.companyFirewallToolStripMenuItem.Click += new System.EventHandler(this.companyFirewallToolStripMenuItem_Click);
	    // 
	    // virusTotalToolStripMenuItem
	    // 
	    this.virusTotalToolStripMenuItem.Name = "virusTotalToolStripMenuItem";
	    this.virusTotalToolStripMenuItem.Size = new System.Drawing.Size(347, 46);
	    this.virusTotalToolStripMenuItem.Text = "VirusTotals.com";
	    this.virusTotalToolStripMenuItem.Click += new System.EventHandler(this.virusTotalToolStripMenuItem_Click);
	    // 
	    // errorLabel
	    // 
	    this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.errorLabel.AutoSize = true;
	    this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.errorLabel.Location = new System.Drawing.Point(865, 290);
	    this.errorLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.errorLabel.Name = "errorLabel";
	    this.errorLabel.Size = new System.Drawing.Size(421, 122);
	    this.errorLabel.TabIndex = 1;
	    this.errorLabel.Text = "404 Error\r\nPage Not Found\r\n";
	    this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // WebsitePanel
	    // 
	    this.WebsitePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.WebsitePanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.WebsitePanel.Location = new System.Drawing.Point(0, 48);
	    this.WebsitePanel.Name = "WebsitePanel";
	    this.WebsitePanel.Size = new System.Drawing.Size(2155, 1070);
	    this.WebsitePanel.TabIndex = 8;
	    this.WebsitePanel.Visible = false;
	    // 
	    // errorIcon
	    // 
	    this.errorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("errorIcon.BackgroundImage")));
	    this.errorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.errorIcon.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.errorIcon.Location = new System.Drawing.Point(0, 0);
	    this.errorIcon.Name = "errorIcon";
	    this.errorIcon.Size = new System.Drawing.Size(2155, 1070);
	    this.errorIcon.TabIndex = 9;
	    this.errorIcon.TabStop = false;
	    // 
	    // ErrorPanel
	    // 
	    this.ErrorPanel.Controls.Add(this.errorLabel);
	    this.ErrorPanel.Controls.Add(this.errorIcon);
	    this.ErrorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.ErrorPanel.Location = new System.Drawing.Point(0, 48);
	    this.ErrorPanel.Name = "ErrorPanel";
	    this.ErrorPanel.Size = new System.Drawing.Size(2155, 1070);
	    this.ErrorPanel.TabIndex = 10;
	    this.ErrorPanel.Visible = false;
	    // 
	    // Form_InternetBrowser
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
	    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.ClientSize = new System.Drawing.Size(2155, 1118);
	    this.Controls.Add(this.WebsitePanel);
	    this.Controls.Add(this.ErrorPanel);
	    this.Controls.Add(this.toolStrip1);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_InternetBrowser";
	    this.Text = "InternetBrowser";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.toolStrip1.ResumeLayout(false);
	    this.toolStrip1.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
	    this.ErrorPanel.ResumeLayout(false);
	    this.ErrorPanel.PerformLayout();
	    this.ResumeLayout(false);
	    this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Forward;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripDropDownButton Bookmarks;
        private System.Windows.Forms.ToolStripMenuItem companyFirewallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virusTotalToolStripMenuItem;
        private System.Windows.Forms.Label errorLabel;
	private System.Windows.Forms.Panel WebsitePanel;
	private System.Windows.Forms.PictureBox errorIcon;
	private System.Windows.Forms.Panel ErrorPanel;
	public System.Windows.Forms.ToolStripTextBox AddressBar;
	public System.Windows.Forms.ToolStripButton Search;
    }
}