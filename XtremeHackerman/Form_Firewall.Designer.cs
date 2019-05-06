namespace XtremeHackerman
{
    partial class Form_Firewall
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Firewall));
	    this.LogoutButton = new System.Windows.Forms.Button();
	    this.FirewallSplitContainer = new System.Windows.Forms.SplitContainer();
	    this.webTab = new System.Windows.Forms.Button();
	    this.ipTab = new System.Windows.Forms.Button();
	    this.domainTab = new System.Windows.Forms.Button();
	    this.homeButton = new System.Windows.Forms.Button();
	    this.webaccessPanel = new System.Windows.Forms.Panel();
	    this.webmessageLabel = new System.Windows.Forms.Label();
	    this.webPanelAccess2 = new System.Windows.Forms.Panel();
	    this.addWebButton = new System.Windows.Forms.Button();
	    this.blockedWebsTB = new System.Windows.Forms.TextBox();
	    this.waccessTextEntry = new System.Windows.Forms.TextBox();
	    this.blacklistWebLabel = new System.Windows.Forms.Label();
	    this.textBox1 = new System.Windows.Forms.TextBox();
	    this.clearedWebLabel = new System.Windows.Forms.Label();
	    this.blockIPPanel = new System.Windows.Forms.Panel();
	    this.addIPButton = new System.Windows.Forms.Button();
	    this.blockedIPsTB = new System.Windows.Forms.TextBox();
	    this.ipYeahweblocked = new System.Windows.Forms.Label();
	    this.ipEntry = new System.Windows.Forms.TextBox();
	    this.blockIP = new System.Windows.Forms.Label();
	    this.DomainPanel = new System.Windows.Forms.Panel();
	    this.domainADD = new System.Windows.Forms.Button();
	    this.blockedDomainsTB = new System.Windows.Forms.TextBox();
	    this.domainEntry = new System.Windows.Forms.TextBox();
	    this.labelManageAdd = new System.Windows.Forms.Label();
	    this.discMessage = new System.Windows.Forms.Label();
	    this.HomePanel = new System.Windows.Forms.Panel();
	    this.homeInstructions = new System.Windows.Forms.TextBox();
	    this.welcomeMessagelabel = new System.Windows.Forms.Label();
	    this.LandingPanel = new System.Windows.Forms.Panel();
	    this.loginButton = new System.Windows.Forms.Button();
	    this.password_field = new System.Windows.Forms.TextBox();
	    this.username_field = new System.Windows.Forms.TextBox();
	    this.PasswordLBL = new System.Windows.Forms.Label();
	    this.UsernameLBL = new System.Windows.Forms.Label();
	    ((System.ComponentModel.ISupportInitialize)(this.FirewallSplitContainer)).BeginInit();
	    this.FirewallSplitContainer.Panel1.SuspendLayout();
	    this.FirewallSplitContainer.Panel2.SuspendLayout();
	    this.FirewallSplitContainer.SuspendLayout();
	    this.webaccessPanel.SuspendLayout();
	    this.webPanelAccess2.SuspendLayout();
	    this.blockIPPanel.SuspendLayout();
	    this.DomainPanel.SuspendLayout();
	    this.HomePanel.SuspendLayout();
	    this.LandingPanel.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // LogoutButton
	    // 
	    this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.LogoutButton.Location = new System.Drawing.Point(0, 1114);
	    this.LogoutButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.LogoutButton.Name = "LogoutButton";
	    this.LogoutButton.Size = new System.Drawing.Size(400, 93);
	    this.LogoutButton.TabIndex = 2;
	    this.LogoutButton.Text = "Logout";
	    this.LogoutButton.UseVisualStyleBackColor = true;
	    this.LogoutButton.Click += new System.EventHandler(this.Logout_Button);
	    // 
	    // FirewallSplitContainer
	    // 
	    this.FirewallSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.FirewallSplitContainer.Location = new System.Drawing.Point(0, 0);
	    this.FirewallSplitContainer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.FirewallSplitContainer.Name = "FirewallSplitContainer";
	    // 
	    // FirewallSplitContainer.Panel1
	    // 
	    this.FirewallSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.webTab);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.ipTab);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.domainTab);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.homeButton);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.LogoutButton);
	    // 
	    // FirewallSplitContainer.Panel2
	    // 
	    this.FirewallSplitContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirewallSplitContainer.Panel2.BackgroundImage")));
	    this.FirewallSplitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.webaccessPanel);
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.blockIPPanel);
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.DomainPanel);
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.HomePanel);
	    this.FirewallSplitContainer.Panel2.Tag = "homePagefire";
	    this.FirewallSplitContainer.Size = new System.Drawing.Size(2752, 1207);
	    this.FirewallSplitContainer.SplitterDistance = 400;
	    this.FirewallSplitContainer.SplitterWidth = 11;
	    this.FirewallSplitContainer.TabIndex = 3;
	    this.FirewallSplitContainer.Visible = false;
	    // 
	    // webTab
	    // 
	    this.webTab.Dock = System.Windows.Forms.DockStyle.Top;
	    this.webTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.webTab.Location = new System.Drawing.Point(0, 267);
	    this.webTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webTab.Name = "webTab";
	    this.webTab.Size = new System.Drawing.Size(400, 87);
	    this.webTab.TabIndex = 1;
	    this.webTab.Text = "Web Access";
	    this.webTab.UseVisualStyleBackColor = true;
	    this.webTab.Click += new System.EventHandler(this.webTab_Click);
	    // 
	    // ipTab
	    // 
	    this.ipTab.Dock = System.Windows.Forms.DockStyle.Top;
	    this.ipTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.ipTab.Location = new System.Drawing.Point(0, 180);
	    this.ipTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.ipTab.Name = "ipTab";
	    this.ipTab.Size = new System.Drawing.Size(400, 87);
	    this.ipTab.TabIndex = 3;
	    this.ipTab.Text = "Block IPs";
	    this.ipTab.UseVisualStyleBackColor = true;
	    this.ipTab.Click += new System.EventHandler(this.ipTab_Click);
	    // 
	    // domainTab
	    // 
	    this.domainTab.Dock = System.Windows.Forms.DockStyle.Top;
	    this.domainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.domainTab.Location = new System.Drawing.Point(0, 93);
	    this.domainTab.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.domainTab.Name = "domainTab";
	    this.domainTab.Size = new System.Drawing.Size(400, 87);
	    this.domainTab.TabIndex = 0;
	    this.domainTab.Text = "Block Domains";
	    this.domainTab.UseVisualStyleBackColor = true;
	    this.domainTab.Click += new System.EventHandler(this.domainTab_Click);
	    // 
	    // homeButton
	    // 
	    this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
	    this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	    this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
	    this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.homeButton.Location = new System.Drawing.Point(0, 0);
	    this.homeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.homeButton.Name = "homeButton";
	    this.homeButton.Size = new System.Drawing.Size(400, 93);
	    this.homeButton.TabIndex = 5;
	    this.homeButton.UseVisualStyleBackColor = true;
	    this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
	    // 
	    // webaccessPanel
	    // 
	    this.webaccessPanel.Controls.Add(this.webmessageLabel);
	    this.webaccessPanel.Controls.Add(this.webPanelAccess2);
	    this.webaccessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.webaccessPanel.Location = new System.Drawing.Point(0, 0);
	    this.webaccessPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webaccessPanel.Name = "webaccessPanel";
	    this.webaccessPanel.Size = new System.Drawing.Size(2341, 1207);
	    this.webaccessPanel.TabIndex = 6;
	    // 
	    // webmessageLabel
	    // 
	    this.webmessageLabel.AutoSize = true;
	    this.webmessageLabel.Location = new System.Drawing.Point(1160, 176);
	    this.webmessageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.webmessageLabel.Name = "webmessageLabel";
	    this.webmessageLabel.Size = new System.Drawing.Size(461, 32);
	    this.webmessageLabel.TabIndex = 1;
	    this.webmessageLabel.Text = "Add sites users cannot go to below.";
	    // 
	    // webPanelAccess2
	    // 
	    this.webPanelAccess2.BackColor = System.Drawing.SystemColors.Control;
	    this.webPanelAccess2.Controls.Add(this.addWebButton);
	    this.webPanelAccess2.Controls.Add(this.blockedWebsTB);
	    this.webPanelAccess2.Controls.Add(this.waccessTextEntry);
	    this.webPanelAccess2.Controls.Add(this.blacklistWebLabel);
	    this.webPanelAccess2.Controls.Add(this.textBox1);
	    this.webPanelAccess2.Controls.Add(this.clearedWebLabel);
	    this.webPanelAccess2.Location = new System.Drawing.Point(192, 215);
	    this.webPanelAccess2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webPanelAccess2.Name = "webPanelAccess2";
	    this.webPanelAccess2.Size = new System.Drawing.Size(1435, 622);
	    this.webPanelAccess2.TabIndex = 0;
	    // 
	    // addWebButton
	    // 
	    this.addWebButton.BackColor = System.Drawing.SystemColors.Control;
	    this.addWebButton.Location = new System.Drawing.Point(1173, 26);
	    this.addWebButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.addWebButton.Name = "addWebButton";
	    this.addWebButton.Size = new System.Drawing.Size(200, 55);
	    this.addWebButton.TabIndex = 6;
	    this.addWebButton.Text = "Add:";
	    this.addWebButton.UseVisualStyleBackColor = false;
	    // 
	    // blockedWebsTB
	    // 
	    this.blockedWebsTB.BackColor = System.Drawing.SystemColors.ScrollBar;
	    this.blockedWebsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.blockedWebsTB.Location = new System.Drawing.Point(720, 88);
	    this.blockedWebsTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockedWebsTB.Multiline = true;
	    this.blockedWebsTB.Name = "blockedWebsTB";
	    this.blockedWebsTB.Size = new System.Drawing.Size(376, 427);
	    this.blockedWebsTB.TabIndex = 5;
	    // 
	    // waccessTextEntry
	    // 
	    this.waccessTextEntry.Location = new System.Drawing.Point(891, 29);
	    this.waccessTextEntry.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.waccessTextEntry.Name = "waccessTextEntry";
	    this.waccessTextEntry.Size = new System.Drawing.Size(260, 38);
	    this.waccessTextEntry.TabIndex = 4;
	    // 
	    // blacklistWebLabel
	    // 
	    this.blacklistWebLabel.AutoSize = true;
	    this.blacklistWebLabel.Location = new System.Drawing.Point(712, 36);
	    this.blacklistWebLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.blacklistWebLabel.Name = "blacklistWebLabel";
	    this.blacklistWebLabel.Size = new System.Drawing.Size(161, 32);
	    this.blacklistWebLabel.TabIndex = 3;
	    this.blacklistWebLabel.Text = "Blacklisted:";
	    // 
	    // textBox1
	    // 
	    this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
	    this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.textBox1.Location = new System.Drawing.Point(16, 91);
	    this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.textBox1.Multiline = true;
	    this.textBox1.Name = "textBox1";
	    this.textBox1.Size = new System.Drawing.Size(349, 424);
	    this.textBox1.TabIndex = 1;
	    this.textBox1.Text = "VirusTotals.com\r\n";
	    // 
	    // clearedWebLabel
	    // 
	    this.clearedWebLabel.AutoSize = true;
	    this.clearedWebLabel.BackColor = System.Drawing.SystemColors.Control;
	    this.clearedWebLabel.Location = new System.Drawing.Point(8, 26);
	    this.clearedWebLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.clearedWebLabel.Name = "clearedWebLabel";
	    this.clearedWebLabel.Size = new System.Drawing.Size(194, 32);
	    this.clearedWebLabel.TabIndex = 0;
	    this.clearedWebLabel.Text = "Cleared Sites:";
	    // 
	    // blockIPPanel
	    // 
	    this.blockIPPanel.BackColor = System.Drawing.SystemColors.ControlDark;
	    this.blockIPPanel.Controls.Add(this.addIPButton);
	    this.blockIPPanel.Controls.Add(this.blockedIPsTB);
	    this.blockIPPanel.Controls.Add(this.ipYeahweblocked);
	    this.blockIPPanel.Controls.Add(this.ipEntry);
	    this.blockIPPanel.Controls.Add(this.blockIP);
	    this.blockIPPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.blockIPPanel.Location = new System.Drawing.Point(0, 0);
	    this.blockIPPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockIPPanel.Name = "blockIPPanel";
	    this.blockIPPanel.Size = new System.Drawing.Size(2341, 1207);
	    this.blockIPPanel.TabIndex = 7;
	    // 
	    // addIPButton
	    // 
	    this.addIPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
	    this.addIPButton.Location = new System.Drawing.Point(1051, 211);
	    this.addIPButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.addIPButton.Name = "addIPButton";
	    this.addIPButton.Size = new System.Drawing.Size(75, 55);
	    this.addIPButton.TabIndex = 1;
	    this.addIPButton.Text = "Add";
	    this.addIPButton.UseVisualStyleBackColor = true;
	    this.addIPButton.Click += new System.EventHandler(this.addIPButton_Click);
	    // 
	    // blockedIPsTB
	    // 
	    this.blockedIPsTB.AcceptsReturn = true;
	    this.blockedIPsTB.Location = new System.Drawing.Point(685, 385);
	    this.blockedIPsTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockedIPsTB.Multiline = true;
	    this.blockedIPsTB.Name = "blockedIPsTB";
	    this.blockedIPsTB.ReadOnly = true;
	    this.blockedIPsTB.Size = new System.Drawing.Size(755, 654);
	    this.blockedIPsTB.TabIndex = 4;
	    this.blockedIPsTB.Text = "\r\n";
	    // 
	    // ipYeahweblocked
	    // 
	    this.ipYeahweblocked.AutoSize = true;
	    this.ipYeahweblocked.BackColor = System.Drawing.SystemColors.ControlLight;
	    this.ipYeahweblocked.Location = new System.Drawing.Point(763, 277);
	    this.ipYeahweblocked.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.ipYeahweblocked.Name = "ipYeahweblocked";
	    this.ipYeahweblocked.Size = new System.Drawing.Size(214, 32);
	    this.ipYeahweblocked.TabIndex = 3;
	    this.ipYeahweblocked.Text = "BlackListed IPS";
	    // 
	    // ipEntry
	    // 
	    this.ipEntry.Location = new System.Drawing.Point(719, 220);
	    this.ipEntry.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.ipEntry.Name = "ipEntry";
	    this.ipEntry.Size = new System.Drawing.Size(308, 38);
	    this.ipEntry.TabIndex = 0;
	    // 
	    // blockIP
	    // 
	    this.blockIP.AutoSize = true;
	    this.blockIP.BackColor = System.Drawing.SystemColors.ActiveBorder;
	    this.blockIP.Location = new System.Drawing.Point(792, 148);
	    this.blockIP.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.blockIP.Name = "blockIP";
	    this.blockIP.Size = new System.Drawing.Size(308, 32);
	    this.blockIP.TabIndex = 6;
	    this.blockIP.Text = "Add IPs to block below:";
	    // 
	    // DomainPanel
	    // 
	    this.DomainPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.DomainPanel.Controls.Add(this.domainADD);
	    this.DomainPanel.Controls.Add(this.blockedDomainsTB);
	    this.DomainPanel.Controls.Add(this.domainEntry);
	    this.DomainPanel.Controls.Add(this.labelManageAdd);
	    this.DomainPanel.Controls.Add(this.discMessage);
	    this.DomainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.DomainPanel.Location = new System.Drawing.Point(0, 0);
	    this.DomainPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.DomainPanel.Name = "DomainPanel";
	    this.DomainPanel.Size = new System.Drawing.Size(2341, 1207);
	    this.DomainPanel.TabIndex = 2;
	    // 
	    // domainADD
	    // 
	    this.domainADD.Location = new System.Drawing.Point(835, 241);
	    this.domainADD.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.domainADD.Name = "domainADD";
	    this.domainADD.Size = new System.Drawing.Size(200, 55);
	    this.domainADD.TabIndex = 5;
	    this.domainADD.Text = "Add";
	    this.domainADD.UseVisualStyleBackColor = true;
	    this.domainADD.Click += new System.EventHandler(this.addDomainButton_Click);
	    // 
	    // blockedDomainsTB
	    // 
	    this.blockedDomainsTB.BackColor = System.Drawing.SystemColors.Control;
	    this.blockedDomainsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	    this.blockedDomainsTB.Location = new System.Drawing.Point(107, 305);
	    this.blockedDomainsTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockedDomainsTB.Multiline = true;
	    this.blockedDomainsTB.Name = "blockedDomainsTB";
	    this.blockedDomainsTB.Size = new System.Drawing.Size(603, 475);
	    this.blockedDomainsTB.TabIndex = 4;
	    // 
	    // domainEntry
	    // 
	    this.domainEntry.Location = new System.Drawing.Point(107, 241);
	    this.domainEntry.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.domainEntry.Name = "domainEntry";
	    this.domainEntry.Size = new System.Drawing.Size(527, 38);
	    this.domainEntry.TabIndex = 3;
	    // 
	    // labelManageAdd
	    // 
	    this.labelManageAdd.AutoSize = true;
	    this.labelManageAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
	    this.labelManageAdd.Location = new System.Drawing.Point(107, 148);
	    this.labelManageAdd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.labelManageAdd.Name = "labelManageAdd";
	    this.labelManageAdd.Size = new System.Drawing.Size(277, 34);
	    this.labelManageAdd.TabIndex = 2;
	    this.labelManageAdd.Text = "Add Domains below:";
	    // 
	    // discMessage
	    // 
	    this.discMessage.AutoSize = true;
	    this.discMessage.Location = new System.Drawing.Point(5, 9);
	    this.discMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.discMessage.Name = "discMessage";
	    this.discMessage.Size = new System.Drawing.Size(1009, 32);
	    this.discMessage.TabIndex = 1;
	    this.discMessage.Text = "Disclaimer: Adding Domains to this page will blacklist the domain until removal.";
	    // 
	    // HomePanel
	    // 
	    this.HomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePanel.BackgroundImage")));
	    this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.HomePanel.Controls.Add(this.homeInstructions);
	    this.HomePanel.Controls.Add(this.welcomeMessagelabel);
	    this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.HomePanel.Location = new System.Drawing.Point(0, 0);
	    this.HomePanel.Name = "HomePanel";
	    this.HomePanel.Size = new System.Drawing.Size(2341, 1207);
	    this.HomePanel.TabIndex = 4;
	    // 
	    // homeInstructions
	    // 
	    this.homeInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.homeInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.homeInstructions.Location = new System.Drawing.Point(685, 244);
	    this.homeInstructions.Multiline = true;
	    this.homeInstructions.Name = "homeInstructions";
	    this.homeInstructions.ReadOnly = true;
	    this.homeInstructions.Size = new System.Drawing.Size(1000, 706);
	    this.homeInstructions.TabIndex = 2;
	    this.homeInstructions.Text = resources.GetString("homeInstructions.Text");
	    this.homeInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	    // 
	    // welcomeMessagelabel
	    // 
	    this.welcomeMessagelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.welcomeMessagelabel.AutoSize = true;
	    this.welcomeMessagelabel.BackColor = System.Drawing.Color.Transparent;
	    this.welcomeMessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.welcomeMessagelabel.ForeColor = System.Drawing.Color.Transparent;
	    this.welcomeMessagelabel.Location = new System.Drawing.Point(959, 153);
	    this.welcomeMessagelabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.welcomeMessagelabel.Name = "welcomeMessagelabel";
	    this.welcomeMessagelabel.Size = new System.Drawing.Size(412, 61);
	    this.welcomeMessagelabel.TabIndex = 1;
	    this.welcomeMessagelabel.Text = "Welcome Admin";
	    // 
	    // LandingPanel
	    // 
	    this.LandingPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
	    this.LandingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LandingPanel.BackgroundImage")));
	    this.LandingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.LandingPanel.Controls.Add(this.loginButton);
	    this.LandingPanel.Controls.Add(this.password_field);
	    this.LandingPanel.Controls.Add(this.username_field);
	    this.LandingPanel.Controls.Add(this.PasswordLBL);
	    this.LandingPanel.Controls.Add(this.UsernameLBL);
	    this.LandingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.LandingPanel.Location = new System.Drawing.Point(0, 0);
	    this.LandingPanel.Name = "LandingPanel";
	    this.LandingPanel.Size = new System.Drawing.Size(2752, 1207);
	    this.LandingPanel.TabIndex = 8;
	    // 
	    // loginButton
	    // 
	    this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
	    this.loginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
	    this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.loginButton.Location = new System.Drawing.Point(1277, 748);
	    this.loginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.loginButton.Name = "loginButton";
	    this.loginButton.Size = new System.Drawing.Size(198, 89);
	    this.loginButton.TabIndex = 4;
	    this.loginButton.Text = "Login";
	    this.loginButton.UseVisualStyleBackColor = false;
	    this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
	    // 
	    // password_field
	    // 
	    this.password_field.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.password_field.Location = new System.Drawing.Point(1368, 607);
	    this.password_field.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.password_field.Name = "password_field";
	    this.password_field.Size = new System.Drawing.Size(369, 38);
	    this.password_field.TabIndex = 3;
	    // 
	    // username_field
	    // 
	    this.username_field.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.username_field.Location = new System.Drawing.Point(1368, 516);
	    this.username_field.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.username_field.Name = "username_field";
	    this.username_field.Size = new System.Drawing.Size(369, 38);
	    this.username_field.TabIndex = 2;
	    // 
	    // PasswordLBL
	    // 
	    this.PasswordLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.PasswordLBL.AutoSize = true;
	    this.PasswordLBL.BackColor = System.Drawing.Color.Transparent;
	    this.PasswordLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.PasswordLBL.ForeColor = System.Drawing.Color.White;
	    this.PasswordLBL.Location = new System.Drawing.Point(1049, 587);
	    this.PasswordLBL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.PasswordLBL.Name = "PasswordLBL";
	    this.PasswordLBL.Size = new System.Drawing.Size(274, 61);
	    this.PasswordLBL.TabIndex = 6;
	    this.PasswordLBL.Text = "Password:";
	    // 
	    // UsernameLBL
	    // 
	    this.UsernameLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.UsernameLBL.BackColor = System.Drawing.Color.Transparent;
	    this.UsernameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.UsernameLBL.ForeColor = System.Drawing.Color.White;
	    this.UsernameLBL.Location = new System.Drawing.Point(1047, 497);
	    this.UsernameLBL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.UsernameLBL.Name = "UsernameLBL";
	    this.UsernameLBL.Size = new System.Drawing.Size(331, 63);
	    this.UsernameLBL.TabIndex = 5;
	    this.UsernameLBL.Text = "Username:";
	    // 
	    // Form_Firewall
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(2752, 1207);
	    this.Controls.Add(this.FirewallSplitContainer);
	    this.Controls.Add(this.LandingPanel);
	    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_Firewall";
	    this.Text = "Form1";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.Load += new System.EventHandler(this.Firewall_Load);
	    this.FirewallSplitContainer.Panel1.ResumeLayout(false);
	    this.FirewallSplitContainer.Panel2.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.FirewallSplitContainer)).EndInit();
	    this.FirewallSplitContainer.ResumeLayout(false);
	    this.webaccessPanel.ResumeLayout(false);
	    this.webaccessPanel.PerformLayout();
	    this.webPanelAccess2.ResumeLayout(false);
	    this.webPanelAccess2.PerformLayout();
	    this.blockIPPanel.ResumeLayout(false);
	    this.blockIPPanel.PerformLayout();
	    this.DomainPanel.ResumeLayout(false);
	    this.DomainPanel.PerformLayout();
	    this.HomePanel.ResumeLayout(false);
	    this.HomePanel.PerformLayout();
	    this.LandingPanel.ResumeLayout(false);
	    this.LandingPanel.PerformLayout();
	    this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.SplitContainer FirewallSplitContainer;
        private System.Windows.Forms.Label welcomeMessagelabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel blockIPPanel;
        private System.Windows.Forms.Label blockIP;
        private System.Windows.Forms.Button addIPButton;
        private System.Windows.Forms.TextBox ipEntry;
        private System.Windows.Forms.Label ipYeahweblocked;
        private System.Windows.Forms.TextBox blockedIPsTB;
        private System.Windows.Forms.Panel DomainPanel;
        private System.Windows.Forms.Button webTab;
        private System.Windows.Forms.Button domainTab;
        private System.Windows.Forms.Label discMessage;
        private System.Windows.Forms.Label labelManageAdd;
        private System.Windows.Forms.Button domainADD;
        private System.Windows.Forms.TextBox blockedDomainsTB;
        private System.Windows.Forms.TextBox domainEntry;
        private System.Windows.Forms.Panel webaccessPanel;
        private System.Windows.Forms.Label webmessageLabel;
        private System.Windows.Forms.Panel webPanelAccess2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label clearedWebLabel;
        private System.Windows.Forms.Label blacklistWebLabel;
        private System.Windows.Forms.Button addWebButton;
        private System.Windows.Forms.TextBox blockedWebsTB;
        private System.Windows.Forms.TextBox waccessTextEntry;
	private System.Windows.Forms.Panel LandingPanel;
	private System.Windows.Forms.Label PasswordLBL;
	private System.Windows.Forms.Label UsernameLBL;
	private System.Windows.Forms.Button loginButton;
	private System.Windows.Forms.TextBox password_field;
	private System.Windows.Forms.TextBox username_field;
	private System.Windows.Forms.Button ipTab;
	private System.Windows.Forms.Panel HomePanel;
	private System.Windows.Forms.TextBox homeInstructions;
    }
}