﻿namespace XtremeHackerman
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
	    this.webpageUsage = new System.Windows.Forms.Button();
	    this.blockedIps = new System.Windows.Forms.Button();
	    this.domainSwitch = new System.Windows.Forms.Button();
	    this.homeButton = new System.Windows.Forms.Button();
	    this.webaccessPanel = new System.Windows.Forms.Panel();
	    this.webmessageLabel = new System.Windows.Forms.Label();
	    this.webPanelAccess2 = new System.Windows.Forms.Panel();
	    this.waccessInBtn = new System.Windows.Forms.Button();
	    this.waccessBLEntry = new System.Windows.Forms.TextBox();
	    this.waccessTextEntry = new System.Windows.Forms.TextBox();
	    this.blacklistWebLabel = new System.Windows.Forms.Label();
	    this.webaccessBtnMedian = new System.Windows.Forms.Button();
	    this.textBox1 = new System.Windows.Forms.TextBox();
	    this.clearedWebLabel = new System.Windows.Forms.Label();
	    this.DomainPanel = new System.Windows.Forms.Panel();
	    this.domainADD = new System.Windows.Forms.Button();
	    this.domainEntered = new System.Windows.Forms.TextBox();
	    this.domainEntry = new System.Windows.Forms.TextBox();
	    this.labelManageAdd = new System.Windows.Forms.Label();
	    this.discMessage = new System.Windows.Forms.Label();
	    this.blockIPPanel = new System.Windows.Forms.Panel();
	    this.rightArrowforip = new System.Windows.Forms.Button();
	    this.testipWindow = new System.Windows.Forms.TextBox();
	    this.ipYeahweblocked = new System.Windows.Forms.Label();
	    this.ipEntry = new System.Windows.Forms.TextBox();
	    this.blockIP = new System.Windows.Forms.Label();
	    this.HomePanel = new System.Windows.Forms.Panel();
	    this.welcomeMessagelabel = new System.Windows.Forms.Label();
	    this.LandingPanel = new System.Windows.Forms.Panel();
	    this.label2 = new System.Windows.Forms.Label();
	    this.label1 = new System.Windows.Forms.Label();
	    this.loginButton = new System.Windows.Forms.Button();
	    this.password_field = new System.Windows.Forms.TextBox();
	    this.username_field = new System.Windows.Forms.TextBox();
	    ((System.ComponentModel.ISupportInitialize)(this.FirewallSplitContainer)).BeginInit();
	    this.FirewallSplitContainer.Panel1.SuspendLayout();
	    this.FirewallSplitContainer.Panel2.SuspendLayout();
	    this.FirewallSplitContainer.SuspendLayout();
	    this.webaccessPanel.SuspendLayout();
	    this.webPanelAccess2.SuspendLayout();
	    this.DomainPanel.SuspendLayout();
	    this.blockIPPanel.SuspendLayout();
	    this.HomePanel.SuspendLayout();
	    this.LandingPanel.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // LogoutButton
	    // 
	    this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.LogoutButton.Location = new System.Drawing.Point(0, 1114);
	    this.LogoutButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.LogoutButton.Name = "LogoutButton";
	    this.LogoutButton.Size = new System.Drawing.Size(241, 93);
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
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.webpageUsage);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.blockedIps);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.domainSwitch);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.homeButton);
	    this.FirewallSplitContainer.Panel1.Controls.Add(this.LogoutButton);
	    // 
	    // FirewallSplitContainer.Panel2
	    // 
	    this.FirewallSplitContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirewallSplitContainer.Panel2.BackgroundImage")));
	    this.FirewallSplitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.webaccessPanel);
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.DomainPanel);
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.blockIPPanel);
	    this.FirewallSplitContainer.Panel2.Controls.Add(this.HomePanel);
	    this.FirewallSplitContainer.Panel2.Tag = "homePagefire";
	    this.FirewallSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
	    this.FirewallSplitContainer.Size = new System.Drawing.Size(2752, 1207);
	    this.FirewallSplitContainer.SplitterDistance = 241;
	    this.FirewallSplitContainer.SplitterWidth = 11;
	    this.FirewallSplitContainer.TabIndex = 3;
	    this.FirewallSplitContainer.Visible = false;
	    // 
	    // webpageUsage
	    // 
	    this.webpageUsage.Dock = System.Windows.Forms.DockStyle.Top;
	    this.webpageUsage.Location = new System.Drawing.Point(0, 203);
	    this.webpageUsage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webpageUsage.Name = "webpageUsage";
	    this.webpageUsage.Size = new System.Drawing.Size(241, 55);
	    this.webpageUsage.TabIndex = 1;
	    this.webpageUsage.Text = "Web Access";
	    this.webpageUsage.UseVisualStyleBackColor = true;
	    this.webpageUsage.Click += new System.EventHandler(this.webpageUsage_Click);
	    // 
	    // blockedIps
	    // 
	    this.blockedIps.Dock = System.Windows.Forms.DockStyle.Top;
	    this.blockedIps.Location = new System.Drawing.Point(0, 148);
	    this.blockedIps.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockedIps.Name = "blockedIps";
	    this.blockedIps.Size = new System.Drawing.Size(241, 55);
	    this.blockedIps.TabIndex = 3;
	    this.blockedIps.Text = "Block IPs";
	    this.blockedIps.UseVisualStyleBackColor = true;
	    this.blockedIps.Click += new System.EventHandler(this.blockedIps_Click);
	    // 
	    // domainSwitch
	    // 
	    this.domainSwitch.Dock = System.Windows.Forms.DockStyle.Top;
	    this.domainSwitch.Location = new System.Drawing.Point(0, 93);
	    this.domainSwitch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.domainSwitch.Name = "domainSwitch";
	    this.domainSwitch.Size = new System.Drawing.Size(241, 55);
	    this.domainSwitch.TabIndex = 0;
	    this.domainSwitch.Text = "Domain";
	    this.domainSwitch.UseVisualStyleBackColor = true;
	    this.domainSwitch.Click += new System.EventHandler(this.domainSwitch_Click);
	    // 
	    // homeButton
	    // 
	    this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
	    this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	    this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
	    this.homeButton.Location = new System.Drawing.Point(0, 0);
	    this.homeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.homeButton.Name = "homeButton";
	    this.homeButton.Size = new System.Drawing.Size(241, 93);
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
	    this.webaccessPanel.Size = new System.Drawing.Size(2500, 1207);
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
	    this.webPanelAccess2.Controls.Add(this.waccessInBtn);
	    this.webPanelAccess2.Controls.Add(this.waccessBLEntry);
	    this.webPanelAccess2.Controls.Add(this.waccessTextEntry);
	    this.webPanelAccess2.Controls.Add(this.blacklistWebLabel);
	    this.webPanelAccess2.Controls.Add(this.webaccessBtnMedian);
	    this.webPanelAccess2.Controls.Add(this.textBox1);
	    this.webPanelAccess2.Controls.Add(this.clearedWebLabel);
	    this.webPanelAccess2.Location = new System.Drawing.Point(192, 215);
	    this.webPanelAccess2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webPanelAccess2.Name = "webPanelAccess2";
	    this.webPanelAccess2.Size = new System.Drawing.Size(1435, 622);
	    this.webPanelAccess2.TabIndex = 0;
	    // 
	    // waccessInBtn
	    // 
	    this.waccessInBtn.BackColor = System.Drawing.SystemColors.Control;
	    this.waccessInBtn.Location = new System.Drawing.Point(1173, 26);
	    this.waccessInBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.waccessInBtn.Name = "waccessInBtn";
	    this.waccessInBtn.Size = new System.Drawing.Size(200, 55);
	    this.waccessInBtn.TabIndex = 6;
	    this.waccessInBtn.Text = "Add:";
	    this.waccessInBtn.UseVisualStyleBackColor = false;
	    this.waccessInBtn.Click += new System.EventHandler(this.waccessInBtn_Click);
	    // 
	    // waccessBLEntry
	    // 
	    this.waccessBLEntry.BackColor = System.Drawing.SystemColors.ScrollBar;
	    this.waccessBLEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.waccessBLEntry.Location = new System.Drawing.Point(720, 88);
	    this.waccessBLEntry.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.waccessBLEntry.Multiline = true;
	    this.waccessBLEntry.Name = "waccessBLEntry";
	    this.waccessBLEntry.Size = new System.Drawing.Size(376, 427);
	    this.waccessBLEntry.TabIndex = 5;
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
	    // webaccessBtnMedian
	    // 
	    this.webaccessBtnMedian.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
	    this.webaccessBtnMedian.Location = new System.Drawing.Point(627, 0);
	    this.webaccessBtnMedian.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webaccessBtnMedian.Name = "webaccessBtnMedian";
	    this.webaccessBtnMedian.Size = new System.Drawing.Size(40, 622);
	    this.webaccessBtnMedian.TabIndex = 2;
	    this.webaccessBtnMedian.UseVisualStyleBackColor = true;
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
	    this.textBox1.Text = "VirusTotals.com\r\n<filler>\r\n<filler>";
	    // 
	    // clearedWebLabel
	    // 
	    this.clearedWebLabel.AutoSize = true;
	    this.clearedWebLabel.BackColor = System.Drawing.SystemColors.Control;
	    this.clearedWebLabel.Location = new System.Drawing.Point(8, 26);
	    this.clearedWebLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.clearedWebLabel.Name = "clearedWebLabel";
	    this.clearedWebLabel.Size = new System.Drawing.Size(123, 32);
	    this.clearedWebLabel.TabIndex = 0;
	    this.clearedWebLabel.Text = "Cleared:";
	    // 
	    // DomainPanel
	    // 
	    this.DomainPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.DomainPanel.Controls.Add(this.domainADD);
	    this.DomainPanel.Controls.Add(this.domainEntered);
	    this.DomainPanel.Controls.Add(this.domainEntry);
	    this.DomainPanel.Controls.Add(this.labelManageAdd);
	    this.DomainPanel.Controls.Add(this.discMessage);
	    this.DomainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.DomainPanel.Location = new System.Drawing.Point(0, 0);
	    this.DomainPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.DomainPanel.Name = "DomainPanel";
	    this.DomainPanel.Size = new System.Drawing.Size(2500, 1207);
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
	    this.domainADD.Click += new System.EventHandler(this.domainADD_Click);
	    // 
	    // domainEntered
	    // 
	    this.domainEntered.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.domainEntered.BorderStyle = System.Windows.Forms.BorderStyle.None;
	    this.domainEntered.Location = new System.Drawing.Point(107, 305);
	    this.domainEntered.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.domainEntered.Multiline = true;
	    this.domainEntered.Name = "domainEntered";
	    this.domainEntered.Size = new System.Drawing.Size(603, 475);
	    this.domainEntered.TabIndex = 4;
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
	    // blockIPPanel
	    // 
	    this.blockIPPanel.BackColor = System.Drawing.SystemColors.ControlDark;
	    this.blockIPPanel.Controls.Add(this.rightArrowforip);
	    this.blockIPPanel.Controls.Add(this.testipWindow);
	    this.blockIPPanel.Controls.Add(this.ipYeahweblocked);
	    this.blockIPPanel.Controls.Add(this.ipEntry);
	    this.blockIPPanel.Controls.Add(this.blockIP);
	    this.blockIPPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.blockIPPanel.Location = new System.Drawing.Point(0, 0);
	    this.blockIPPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockIPPanel.Name = "blockIPPanel";
	    this.blockIPPanel.Size = new System.Drawing.Size(2500, 1207);
	    this.blockIPPanel.TabIndex = 7;
	    // 
	    // rightArrowforip
	    // 
	    this.rightArrowforip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
	    this.rightArrowforip.Location = new System.Drawing.Point(1051, 211);
	    this.rightArrowforip.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.rightArrowforip.Name = "rightArrowforip";
	    this.rightArrowforip.Size = new System.Drawing.Size(75, 55);
	    this.rightArrowforip.TabIndex = 1;
	    this.rightArrowforip.Text = "Add";
	    this.rightArrowforip.UseVisualStyleBackColor = true;
	    this.rightArrowforip.Click += new System.EventHandler(this.rightArrowforip_Click);
	    // 
	    // testipWindow
	    // 
	    this.testipWindow.AcceptsReturn = true;
	    this.testipWindow.Location = new System.Drawing.Point(685, 385);
	    this.testipWindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.testipWindow.Multiline = true;
	    this.testipWindow.Name = "testipWindow";
	    this.testipWindow.ReadOnly = true;
	    this.testipWindow.Size = new System.Drawing.Size(755, 654);
	    this.testipWindow.TabIndex = 4;
	    this.testipWindow.Text = "\r\n";
	    this.testipWindow.TextChanged += new System.EventHandler(this.testipWindow_TextChanged);
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
	    this.ipYeahweblocked.Click += new System.EventHandler(this.ipYeahweblocked_Click);
	    // 
	    // ipEntry
	    // 
	    this.ipEntry.Location = new System.Drawing.Point(719, 220);
	    this.ipEntry.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.ipEntry.Name = "ipEntry";
	    this.ipEntry.Size = new System.Drawing.Size(308, 38);
	    this.ipEntry.TabIndex = 0;
	    this.ipEntry.TextChanged += new System.EventHandler(this.ipEntry_TextChanged);
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
	    this.blockIP.Click += new System.EventHandler(this.blockIP_Click);
	    // 
	    // HomePanel
	    // 
	    this.HomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePanel.BackgroundImage")));
	    this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.HomePanel.Controls.Add(this.welcomeMessagelabel);
	    this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.HomePanel.Location = new System.Drawing.Point(0, 0);
	    this.HomePanel.Name = "HomePanel";
	    this.HomePanel.Size = new System.Drawing.Size(2500, 1207);
	    this.HomePanel.TabIndex = 4;
	    // 
	    // welcomeMessagelabel
	    // 
	    this.welcomeMessagelabel.AutoSize = true;
	    this.welcomeMessagelabel.Location = new System.Drawing.Point(1240, 410);
	    this.welcomeMessagelabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.welcomeMessagelabel.Name = "welcomeMessagelabel";
	    this.welcomeMessagelabel.Size = new System.Drawing.Size(309, 32);
	    this.welcomeMessagelabel.TabIndex = 1;
	    this.welcomeMessagelabel.Text = "Welcome Mr. Anderson";
	    // 
	    // LandingPanel
	    // 
	    this.LandingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LandingPanel.BackgroundImage")));
	    this.LandingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.LandingPanel.Controls.Add(this.label2);
	    this.LandingPanel.Controls.Add(this.label1);
	    this.LandingPanel.Controls.Add(this.loginButton);
	    this.LandingPanel.Controls.Add(this.password_field);
	    this.LandingPanel.Controls.Add(this.username_field);
	    this.LandingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.LandingPanel.Location = new System.Drawing.Point(0, 0);
	    this.LandingPanel.Name = "LandingPanel";
	    this.LandingPanel.Size = new System.Drawing.Size(2752, 1207);
	    this.LandingPanel.TabIndex = 8;
	    // 
	    // label2
	    // 
	    this.label2.AutoSize = true;
	    this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
	    this.label2.Location = new System.Drawing.Point(1528, 701);
	    this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.label2.Name = "label2";
	    this.label2.Size = new System.Drawing.Size(147, 32);
	    this.label2.TabIndex = 6;
	    this.label2.Text = "Password:";
	    // 
	    // label1
	    // 
	    this.label1.AutoSize = true;
	    this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
	    this.label1.Location = new System.Drawing.Point(1520, 599);
	    this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.label1.Name = "label1";
	    this.label1.Size = new System.Drawing.Size(153, 32);
	    this.label1.TabIndex = 5;
	    this.label1.Text = "Username:";
	    // 
	    // loginButton
	    // 
	    this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
	    this.loginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
	    this.loginButton.Location = new System.Drawing.Point(1424, 827);
	    this.loginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.loginButton.Name = "loginButton";
	    this.loginButton.Size = new System.Drawing.Size(200, 55);
	    this.loginButton.TabIndex = 4;
	    this.loginButton.Text = "Login";
	    this.loginButton.UseVisualStyleBackColor = false;
	    this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
	    // 
	    // password_field
	    // 
	    this.password_field.Location = new System.Drawing.Point(1424, 737);
	    this.password_field.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.password_field.Name = "password_field";
	    this.password_field.Size = new System.Drawing.Size(369, 38);
	    this.password_field.TabIndex = 3;
	    // 
	    // username_field
	    // 
	    this.username_field.Location = new System.Drawing.Point(1424, 637);
	    this.username_field.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.username_field.Name = "username_field";
	    this.username_field.Size = new System.Drawing.Size(369, 38);
	    this.username_field.TabIndex = 2;
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
	    this.DomainPanel.ResumeLayout(false);
	    this.DomainPanel.PerformLayout();
	    this.blockIPPanel.ResumeLayout(false);
	    this.blockIPPanel.PerformLayout();
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
        private System.Windows.Forms.Button rightArrowforip;
        private System.Windows.Forms.TextBox ipEntry;
        private System.Windows.Forms.Label ipYeahweblocked;
        private System.Windows.Forms.TextBox testipWindow;
        private System.Windows.Forms.Panel DomainPanel;
        private System.Windows.Forms.Button webpageUsage;
        private System.Windows.Forms.Button domainSwitch;
        private System.Windows.Forms.Label discMessage;
        private System.Windows.Forms.Label labelManageAdd;
        private System.Windows.Forms.Button domainADD;
        private System.Windows.Forms.TextBox domainEntered;
        private System.Windows.Forms.TextBox domainEntry;
        private System.Windows.Forms.Panel webaccessPanel;
        private System.Windows.Forms.Label webmessageLabel;
        private System.Windows.Forms.Panel webPanelAccess2;
        private System.Windows.Forms.Button webaccessBtnMedian;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label clearedWebLabel;
        private System.Windows.Forms.Label blacklistWebLabel;
        private System.Windows.Forms.Button waccessInBtn;
        private System.Windows.Forms.TextBox waccessBLEntry;
        private System.Windows.Forms.TextBox waccessTextEntry;
	private System.Windows.Forms.Panel LandingPanel;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Button loginButton;
	private System.Windows.Forms.TextBox password_field;
	private System.Windows.Forms.TextBox username_field;
	private System.Windows.Forms.Button blockedIps;
	private System.Windows.Forms.Panel HomePanel;
    }
}