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
            this.LogoutButton.Location = new System.Drawing.Point(0, 422);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(105, 39);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.Logout_Button);
            // 
            // FirewallSplitContainer
            // 
            this.FirewallSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirewallSplitContainer.Location = new System.Drawing.Point(0, 0);
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
            this.FirewallSplitContainer.Size = new System.Drawing.Size(728, 461);
            this.FirewallSplitContainer.SplitterDistance = 105;
            this.FirewallSplitContainer.TabIndex = 3;
            this.FirewallSplitContainer.Visible = false;
            // 
            // webTab
            // 
            this.webTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.webTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webTab.Location = new System.Drawing.Point(0, 111);
            this.webTab.Name = "webTab";
            this.webTab.Size = new System.Drawing.Size(105, 36);
            this.webTab.TabIndex = 1;
            this.webTab.Text = "Web Access";
            this.webTab.UseVisualStyleBackColor = true;
            this.webTab.Click += new System.EventHandler(this.webTab_Click);
            // 
            // ipTab
            // 
            this.ipTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTab.Location = new System.Drawing.Point(0, 75);
            this.ipTab.Name = "ipTab";
            this.ipTab.Size = new System.Drawing.Size(105, 36);
            this.ipTab.TabIndex = 3;
            this.ipTab.Text = "Block IPs";
            this.ipTab.UseVisualStyleBackColor = true;
            this.ipTab.Click += new System.EventHandler(this.ipTab_Click);
            // 
            // domainTab
            // 
            this.domainTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.domainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainTab.Location = new System.Drawing.Point(0, 39);
            this.domainTab.Name = "domainTab";
            this.domainTab.Size = new System.Drawing.Size(105, 36);
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
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(105, 39);
            this.homeButton.TabIndex = 5;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // webaccessPanel
            // 
            this.webaccessPanel.Controls.Add(this.webmessageLabel);
            this.webaccessPanel.Controls.Add(this.webPanelAccess2);
            this.webaccessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webaccessPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webaccessPanel.Location = new System.Drawing.Point(0, 0);
            this.webaccessPanel.Name = "webaccessPanel";
            this.webaccessPanel.Size = new System.Drawing.Size(619, 461);
            this.webaccessPanel.TabIndex = 6;
            // 
            // webmessageLabel
            // 
            this.webmessageLabel.AutoSize = true;
            this.webmessageLabel.Location = new System.Drawing.Point(142, 53);
            this.webmessageLabel.Name = "webmessageLabel";
            this.webmessageLabel.Size = new System.Drawing.Size(353, 25);
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
            this.webPanelAccess2.Location = new System.Drawing.Point(72, 90);
            this.webPanelAccess2.Name = "webPanelAccess2";
            this.webPanelAccess2.Size = new System.Drawing.Size(538, 261);
            this.webPanelAccess2.TabIndex = 0;
            // 
            // addWebButton
            // 
            this.addWebButton.BackColor = System.Drawing.SystemColors.Control;
            this.addWebButton.Location = new System.Drawing.Point(440, 4);
            this.addWebButton.Name = "addWebButton";
            this.addWebButton.Size = new System.Drawing.Size(75, 32);
            this.addWebButton.TabIndex = 6;
            this.addWebButton.Text = "Add:";
            this.addWebButton.UseVisualStyleBackColor = false;
            // 
            // blockedWebsTB
            // 
            this.blockedWebsTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.blockedWebsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blockedWebsTB.Location = new System.Drawing.Point(292, 38);
            this.blockedWebsTB.Multiline = true;
            this.blockedWebsTB.Name = "blockedWebsTB";
            this.blockedWebsTB.Size = new System.Drawing.Size(197, 183);
            this.blockedWebsTB.TabIndex = 5;
            // 
            // waccessTextEntry
            // 
            this.waccessTextEntry.Location = new System.Drawing.Point(334, 3);
            this.waccessTextEntry.Name = "waccessTextEntry";
            this.waccessTextEntry.Size = new System.Drawing.Size(100, 31);
            this.waccessTextEntry.TabIndex = 4;
            // 
            // blacklistWebLabel
            // 
            this.blacklistWebLabel.AutoSize = true;
            this.blacklistWebLabel.Location = new System.Drawing.Point(212, 5);
            this.blacklistWebLabel.Name = "blacklistWebLabel";
            this.blacklistWebLabel.Size = new System.Drawing.Size(122, 25);
            this.blacklistWebLabel.TabIndex = 3;
            this.blacklistWebLabel.Text = "Blacklisted:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 178);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "VirusTotals.com\r\n";
            // 
            // clearedWebLabel
            // 
            this.clearedWebLabel.AutoSize = true;
            this.clearedWebLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clearedWebLabel.Location = new System.Drawing.Point(3, 11);
            this.clearedWebLabel.Name = "clearedWebLabel";
            this.clearedWebLabel.Size = new System.Drawing.Size(147, 25);
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
            this.blockIPPanel.Name = "blockIPPanel";
            this.blockIPPanel.Size = new System.Drawing.Size(619, 461);
            this.blockIPPanel.TabIndex = 7;
            // 
            // addIPButton
            // 
            this.addIPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addIPButton.Location = new System.Drawing.Point(394, 88);
            this.addIPButton.Name = "addIPButton";
            this.addIPButton.Size = new System.Drawing.Size(28, 23);
            this.addIPButton.TabIndex = 1;
            this.addIPButton.Text = "Add";
            this.addIPButton.UseVisualStyleBackColor = true;
            this.addIPButton.Click += new System.EventHandler(this.addIPButton_Click);
            // 
            // blockedIPsTB
            // 
            this.blockedIPsTB.AcceptsReturn = true;
            this.blockedIPsTB.Location = new System.Drawing.Point(257, 161);
            this.blockedIPsTB.Multiline = true;
            this.blockedIPsTB.Name = "blockedIPsTB";
            this.blockedIPsTB.ReadOnly = true;
            this.blockedIPsTB.Size = new System.Drawing.Size(286, 277);
            this.blockedIPsTB.TabIndex = 4;
            this.blockedIPsTB.Text = "\r\n";
            // 
            // ipYeahweblocked
            // 
            this.ipYeahweblocked.AutoSize = true;
            this.ipYeahweblocked.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ipYeahweblocked.Location = new System.Drawing.Point(286, 116);
            this.ipYeahweblocked.Name = "ipYeahweblocked";
            this.ipYeahweblocked.Size = new System.Drawing.Size(82, 13);
            this.ipYeahweblocked.TabIndex = 3;
            this.ipYeahweblocked.Text = "BlackListed IPS";
            // 
            // ipEntry
            // 
            this.ipEntry.Location = new System.Drawing.Point(270, 92);
            this.ipEntry.Name = "ipEntry";
            this.ipEntry.Size = new System.Drawing.Size(118, 20);
            this.ipEntry.TabIndex = 0;
            // 
            // blockIP
            // 
            this.blockIP.AutoSize = true;
            this.blockIP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.blockIP.Location = new System.Drawing.Point(297, 62);
            this.blockIP.Name = "blockIP";
            this.blockIP.Size = new System.Drawing.Size(119, 13);
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
            this.DomainPanel.Name = "DomainPanel";
            this.DomainPanel.Size = new System.Drawing.Size(619, 461);
            this.DomainPanel.TabIndex = 2;
            // 
            // domainADD
            // 
            this.domainADD.Location = new System.Drawing.Point(313, 101);
            this.domainADD.Name = "domainADD";
            this.domainADD.Size = new System.Drawing.Size(75, 23);
            this.domainADD.TabIndex = 5;
            this.domainADD.Text = "Add";
            this.domainADD.UseVisualStyleBackColor = true;
            this.domainADD.Click += new System.EventHandler(this.addDomainButton_Click);
            // 
            // blockedDomainsTB
            // 
            this.blockedDomainsTB.BackColor = System.Drawing.SystemColors.Control;
            this.blockedDomainsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockedDomainsTB.Location = new System.Drawing.Point(40, 128);
            this.blockedDomainsTB.Multiline = true;
            this.blockedDomainsTB.Name = "blockedDomainsTB";
            this.blockedDomainsTB.Size = new System.Drawing.Size(227, 200);
            this.blockedDomainsTB.TabIndex = 4;
            // 
            // domainEntry
            // 
            this.domainEntry.Location = new System.Drawing.Point(40, 101);
            this.domainEntry.Name = "domainEntry";
            this.domainEntry.Size = new System.Drawing.Size(200, 20);
            this.domainEntry.TabIndex = 3;
            // 
            // labelManageAdd
            // 
            this.labelManageAdd.AutoSize = true;
            this.labelManageAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelManageAdd.Location = new System.Drawing.Point(40, 62);
            this.labelManageAdd.Name = "labelManageAdd";
            this.labelManageAdd.Size = new System.Drawing.Size(106, 15);
            this.labelManageAdd.TabIndex = 2;
            this.labelManageAdd.Text = "Add Domains below:";
            // 
            // discMessage
            // 
            this.discMessage.AutoSize = true;
            this.discMessage.Location = new System.Drawing.Point(2, 4);
            this.discMessage.Name = "discMessage";
            this.discMessage.Size = new System.Drawing.Size(374, 13);
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
            this.HomePanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(619, 461);
            this.HomePanel.TabIndex = 4;
            // 
            // homeInstructions
            // 
            this.homeInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeInstructions.Location = new System.Drawing.Point(127, 79);
            this.homeInstructions.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.homeInstructions.Multiline = true;
            this.homeInstructions.Name = "homeInstructions";
            this.homeInstructions.ReadOnly = true;
            this.homeInstructions.Size = new System.Drawing.Size(378, 298);
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
            this.welcomeMessagelabel.Location = new System.Drawing.Point(230, 41);
            this.welcomeMessagelabel.Name = "welcomeMessagelabel";
            this.welcomeMessagelabel.Size = new System.Drawing.Size(173, 26);
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
            this.LandingPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LandingPanel.Name = "LandingPanel";
            this.LandingPanel.Size = new System.Drawing.Size(728, 461);
            this.LandingPanel.TabIndex = 8;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(327, 291);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(74, 37);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // password_field
            // 
            this.password_field.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_field.Location = new System.Drawing.Point(361, 232);
            this.password_field.Name = "password_field";
            this.password_field.Size = new System.Drawing.Size(141, 20);
            this.password_field.TabIndex = 3;
            // 
            // username_field
            // 
            this.username_field.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_field.Location = new System.Drawing.Point(361, 193);
            this.username_field.Name = "username_field";
            this.username_field.Size = new System.Drawing.Size(141, 20);
            this.username_field.TabIndex = 2;
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.ForeColor = System.Drawing.Color.White;
            this.PasswordLBL.Location = new System.Drawing.Point(241, 223);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(114, 26);
            this.PasswordLBL.TabIndex = 6;
            this.PasswordLBL.Text = "Password:";
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLBL.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLBL.ForeColor = System.Drawing.Color.White;
            this.UsernameLBL.Location = new System.Drawing.Point(241, 185);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(124, 26);
            this.UsernameLBL.TabIndex = 5;
            this.UsernameLBL.Text = "Username:";
            // 
            // Form_Firewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 461);
            this.Controls.Add(this.FirewallSplitContainer);
            this.Controls.Add(this.LandingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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