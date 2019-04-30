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
	    this.button1 = new System.Windows.Forms.Button();
	    this.splitContainer1 = new System.Windows.Forms.SplitContainer();
	    this.toolStrip1 = new System.Windows.Forms.ToolStrip();
	    this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
	    this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.managePage = new System.Windows.Forms.Panel();
	    this.homeButton2 = new System.Windows.Forms.Button();
	    this.emailDomainWindow = new System.Windows.Forms.Panel();
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
	    this.domainADD = new System.Windows.Forms.Button();
	    this.domainEntered = new System.Windows.Forms.TextBox();
	    this.domainEntry = new System.Windows.Forms.TextBox();
	    this.labelManageAdd = new System.Windows.Forms.Label();
	    this.discMessage = new System.Windows.Forms.Label();
	    this.webpageUsage = new System.Windows.Forms.Button();
	    this.domainSwitch = new System.Windows.Forms.Button();
	    this.blockIPwindow = new System.Windows.Forms.Panel();
	    this.testipWindow = new System.Windows.Forms.TextBox();
	    this.ipYeahweblocked = new System.Windows.Forms.Label();
	    this.pageMedian = new System.Windows.Forms.Button();
	    this.rightArrowforip = new System.Windows.Forms.Button();
	    this.ipEntry = new System.Windows.Forms.TextBox();
	    this.blockIP = new System.Windows.Forms.Label();
	    this.homeButton1perm = new System.Windows.Forms.Button();
	    this.permissionsPage = new System.Windows.Forms.PictureBox();
	    this.welcomeMessagelabel = new System.Windows.Forms.Label();
	    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
	    this.splitContainer1.Panel1.SuspendLayout();
	    this.splitContainer1.Panel2.SuspendLayout();
	    this.splitContainer1.SuspendLayout();
	    this.toolStrip1.SuspendLayout();
	    this.managePage.SuspendLayout();
	    this.emailDomainWindow.SuspendLayout();
	    this.webaccessPanel.SuspendLayout();
	    this.webPanelAccess2.SuspendLayout();
	    this.blockIPwindow.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.permissionsPage)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // button1
	    // 
	    this.button1.Location = new System.Drawing.Point(0, 1104);
	    this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button1.Name = "button1";
	    this.button1.Size = new System.Drawing.Size(235, 93);
	    this.button1.TabIndex = 2;
	    this.button1.Text = "Logout";
	    this.button1.UseVisualStyleBackColor = true;
	    this.button1.Click += new System.EventHandler(this.Logout_Button);
	    // 
	    // splitContainer1
	    // 
	    this.splitContainer1.Location = new System.Drawing.Point(-3, -2);
	    this.splitContainer1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.splitContainer1.Name = "splitContainer1";
	    // 
	    // splitContainer1.Panel1
	    // 
	    this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
	    this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
	    this.splitContainer1.Panel1.Controls.Add(this.button1);
	    // 
	    // splitContainer1.Panel2
	    // 
	    this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
	    this.splitContainer1.Panel2.Controls.Add(this.managePage);
	    this.splitContainer1.Panel2.Controls.Add(this.blockIPwindow);
	    this.splitContainer1.Panel2.Controls.Add(this.blockIP);
	    this.splitContainer1.Panel2.Controls.Add(this.homeButton1perm);
	    this.splitContainer1.Panel2.Controls.Add(this.permissionsPage);
	    this.splitContainer1.Panel2.Controls.Add(this.welcomeMessagelabel);
	    this.splitContainer1.Panel2.Tag = "homePagefire";
	    this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
	    this.splitContainer1.Size = new System.Drawing.Size(2757, 1197);
	    this.splitContainer1.SplitterDistance = 242;
	    this.splitContainer1.SplitterWidth = 11;
	    this.splitContainer1.TabIndex = 3;
	    // 
	    // toolStrip1
	    // 
	    this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
	    this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	    this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
	    this.toolStrip1.Location = new System.Drawing.Point(0, 0);
	    this.toolStrip1.Name = "toolStrip1";
	    this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
	    this.toolStrip1.Size = new System.Drawing.Size(242, 47);
	    this.toolStrip1.TabIndex = 3;
	    this.toolStrip1.Text = "toolStrip1";
	    // 
	    // toolStripDropDownButton1
	    // 
	    this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
	    this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.permissionsToolStripMenuItem,
            this.monitorToolStripMenuItem,
            this.manageToolStripMenuItem});
	    this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
	    this.toolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
	    this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
	    this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 44);
	    this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
	    this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
	    // 
	    // homeToolStripMenuItem
	    // 
	    this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
	    this.homeToolStripMenuItem.Size = new System.Drawing.Size(288, 46);
	    this.homeToolStripMenuItem.Text = "Home";
	    this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
	    // 
	    // permissionsToolStripMenuItem
	    // 
	    this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
	    this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(288, 46);
	    this.permissionsToolStripMenuItem.Text = "Permissions";
	    this.permissionsToolStripMenuItem.Click += new System.EventHandler(this.permissionsToolStripMenuItem_Click);
	    // 
	    // monitorToolStripMenuItem
	    // 
	    this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
	    this.monitorToolStripMenuItem.Size = new System.Drawing.Size(288, 46);
	    this.monitorToolStripMenuItem.Text = "Monitor";
	    // 
	    // manageToolStripMenuItem
	    // 
	    this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
	    this.manageToolStripMenuItem.Size = new System.Drawing.Size(288, 46);
	    this.manageToolStripMenuItem.Text = "Manage";
	    this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
	    // 
	    // managePage
	    // 
	    this.managePage.Controls.Add(this.homeButton2);
	    this.managePage.Controls.Add(this.emailDomainWindow);
	    this.managePage.Controls.Add(this.webpageUsage);
	    this.managePage.Controls.Add(this.domainSwitch);
	    this.managePage.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.managePage.Location = new System.Drawing.Point(0, 0);
	    this.managePage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.managePage.Name = "managePage";
	    this.managePage.Size = new System.Drawing.Size(2504, 1197);
	    this.managePage.TabIndex = 8;
	    this.managePage.Visible = false;
	    // 
	    // homeButton2
	    // 
	    this.homeButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton2.BackgroundImage")));
	    this.homeButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.homeButton2.Location = new System.Drawing.Point(2360, 1075);
	    this.homeButton2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.homeButton2.Name = "homeButton2";
	    this.homeButton2.Size = new System.Drawing.Size(136, 114);
	    this.homeButton2.TabIndex = 3;
	    this.homeButton2.UseVisualStyleBackColor = true;
	    this.homeButton2.Click += new System.EventHandler(this.homeButton2_Click);
	    // 
	    // emailDomainWindow
	    // 
	    this.emailDomainWindow.BackColor = System.Drawing.SystemColors.ButtonShadow;
	    this.emailDomainWindow.Controls.Add(this.webaccessPanel);
	    this.emailDomainWindow.Controls.Add(this.domainADD);
	    this.emailDomainWindow.Controls.Add(this.domainEntered);
	    this.emailDomainWindow.Controls.Add(this.domainEntry);
	    this.emailDomainWindow.Controls.Add(this.labelManageAdd);
	    this.emailDomainWindow.Controls.Add(this.discMessage);
	    this.emailDomainWindow.Location = new System.Drawing.Point(267, 129);
	    this.emailDomainWindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.emailDomainWindow.Name = "emailDomainWindow";
	    this.emailDomainWindow.Size = new System.Drawing.Size(1997, 932);
	    this.emailDomainWindow.TabIndex = 2;
	    this.emailDomainWindow.Visible = false;
	    // 
	    // webaccessPanel
	    // 
	    this.webaccessPanel.Controls.Add(this.webmessageLabel);
	    this.webaccessPanel.Controls.Add(this.webPanelAccess2);
	    this.webaccessPanel.Location = new System.Drawing.Point(0, 0);
	    this.webaccessPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webaccessPanel.Name = "webaccessPanel";
	    this.webaccessPanel.Size = new System.Drawing.Size(1997, 940);
	    this.webaccessPanel.TabIndex = 6;
	    this.webaccessPanel.Visible = false;
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
	    this.discMessage.Location = new System.Drawing.Point(1000, 0);
	    this.discMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.discMessage.Name = "discMessage";
	    this.discMessage.Size = new System.Drawing.Size(1009, 32);
	    this.discMessage.TabIndex = 1;
	    this.discMessage.Text = "Disclaimer: Adding Domains to this page will blacklist the domain until removal.";
	    // 
	    // webpageUsage
	    // 
	    this.webpageUsage.Location = new System.Drawing.Point(445, 81);
	    this.webpageUsage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.webpageUsage.Name = "webpageUsage";
	    this.webpageUsage.Size = new System.Drawing.Size(245, 55);
	    this.webpageUsage.TabIndex = 1;
	    this.webpageUsage.Text = "Web Access";
	    this.webpageUsage.UseVisualStyleBackColor = true;
	    this.webpageUsage.Click += new System.EventHandler(this.webpageUsage_Click);
	    // 
	    // domainSwitch
	    // 
	    this.domainSwitch.Location = new System.Drawing.Point(267, 81);
	    this.domainSwitch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.domainSwitch.Name = "domainSwitch";
	    this.domainSwitch.Size = new System.Drawing.Size(200, 55);
	    this.domainSwitch.TabIndex = 0;
	    this.domainSwitch.Text = "Domain";
	    this.domainSwitch.UseVisualStyleBackColor = true;
	    this.domainSwitch.Click += new System.EventHandler(this.domainSwitch_Click);
	    // 
	    // blockIPwindow
	    // 
	    this.blockIPwindow.Controls.Add(this.testipWindow);
	    this.blockIPwindow.Controls.Add(this.ipYeahweblocked);
	    this.blockIPwindow.Controls.Add(this.pageMedian);
	    this.blockIPwindow.Controls.Add(this.rightArrowforip);
	    this.blockIPwindow.Controls.Add(this.ipEntry);
	    this.blockIPwindow.Location = new System.Drawing.Point(237, 496);
	    this.blockIPwindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.blockIPwindow.Name = "blockIPwindow";
	    this.blockIPwindow.Size = new System.Drawing.Size(1752, 572);
	    this.blockIPwindow.TabIndex = 7;
	    // 
	    // testipWindow
	    // 
	    this.testipWindow.AcceptsReturn = true;
	    this.testipWindow.Location = new System.Drawing.Point(1131, 107);
	    this.testipWindow.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.testipWindow.Multiline = true;
	    this.testipWindow.Name = "testipWindow";
	    this.testipWindow.ReadOnly = true;
	    this.testipWindow.Size = new System.Drawing.Size(335, 376);
	    this.testipWindow.TabIndex = 4;
	    this.testipWindow.Text = "\r\n";
	    this.testipWindow.TextChanged += new System.EventHandler(this.testipWindow_TextChanged);
	    // 
	    // ipYeahweblocked
	    // 
	    this.ipYeahweblocked.AutoSize = true;
	    this.ipYeahweblocked.BackColor = System.Drawing.SystemColors.ControlLight;
	    this.ipYeahweblocked.Location = new System.Drawing.Point(1533, 0);
	    this.ipYeahweblocked.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.ipYeahweblocked.Name = "ipYeahweblocked";
	    this.ipYeahweblocked.Size = new System.Drawing.Size(214, 32);
	    this.ipYeahweblocked.TabIndex = 3;
	    this.ipYeahweblocked.Text = "BlackListed IPS";
	    this.ipYeahweblocked.Click += new System.EventHandler(this.ipYeahweblocked_Click);
	    // 
	    // pageMedian
	    // 
	    this.pageMedian.Location = new System.Drawing.Point(864, 0);
	    this.pageMedian.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.pageMedian.Name = "pageMedian";
	    this.pageMedian.Size = new System.Drawing.Size(27, 572);
	    this.pageMedian.TabIndex = 2;
	    this.pageMedian.Text = "button3";
	    this.pageMedian.UseVisualStyleBackColor = true;
	    // 
	    // rightArrowforip
	    // 
	    this.rightArrowforip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrowforip.BackgroundImage")));
	    this.rightArrowforip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.rightArrowforip.Location = new System.Drawing.Point(459, 100);
	    this.rightArrowforip.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.rightArrowforip.Name = "rightArrowforip";
	    this.rightArrowforip.Size = new System.Drawing.Size(75, 55);
	    this.rightArrowforip.TabIndex = 1;
	    this.rightArrowforip.UseVisualStyleBackColor = true;
	    this.rightArrowforip.Click += new System.EventHandler(this.rightArrowforip_Click);
	    // 
	    // ipEntry
	    // 
	    this.ipEntry.Location = new System.Drawing.Point(93, 107);
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
	    this.blockIP.Location = new System.Drawing.Point(229, 432);
	    this.blockIP.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.blockIP.Name = "blockIP";
	    this.blockIP.Size = new System.Drawing.Size(172, 32);
	    this.blockIP.TabIndex = 6;
	    this.blockIP.Text = "Blocked IPs:";
	    this.blockIP.Click += new System.EventHandler(this.blockIP_Click);
	    // 
	    // homeButton1perm
	    // 
	    this.homeButton1perm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton1perm.BackgroundImage")));
	    this.homeButton1perm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.homeButton1perm.Location = new System.Drawing.Point(2395, 1104);
	    this.homeButton1perm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.homeButton1perm.Name = "homeButton1perm";
	    this.homeButton1perm.Size = new System.Drawing.Size(101, 93);
	    this.homeButton1perm.TabIndex = 5;
	    this.homeButton1perm.UseVisualStyleBackColor = true;
	    this.homeButton1perm.Click += new System.EventHandler(this.homeButton1perm_Click);
	    // 
	    // permissionsPage
	    // 
	    this.permissionsPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
	    this.permissionsPage.Location = new System.Drawing.Point(-3, 0);
	    this.permissionsPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.permissionsPage.Name = "permissionsPage";
	    this.permissionsPage.Size = new System.Drawing.Size(2507, 1197);
	    this.permissionsPage.TabIndex = 4;
	    this.permissionsPage.TabStop = false;
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
	    // Form_Firewall
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(2752, 1207);
	    this.Controls.Add(this.splitContainer1);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_Firewall";
	    this.Text = "Form1";
	    this.Load += new System.EventHandler(this.Firewall_Load);
	    this.splitContainer1.Panel1.ResumeLayout(false);
	    this.splitContainer1.Panel1.PerformLayout();
	    this.splitContainer1.Panel2.ResumeLayout(false);
	    this.splitContainer1.Panel2.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
	    this.splitContainer1.ResumeLayout(false);
	    this.toolStrip1.ResumeLayout(false);
	    this.toolStrip1.PerformLayout();
	    this.managePage.ResumeLayout(false);
	    this.emailDomainWindow.ResumeLayout(false);
	    this.emailDomainWindow.PerformLayout();
	    this.webaccessPanel.ResumeLayout(false);
	    this.webaccessPanel.PerformLayout();
	    this.webPanelAccess2.ResumeLayout(false);
	    this.webPanelAccess2.PerformLayout();
	    this.blockIPwindow.ResumeLayout(false);
	    this.blockIPwindow.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.permissionsPage)).EndInit();
	    this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label welcomeMessagelabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.Button homeButton1perm;
        private System.Windows.Forms.PictureBox permissionsPage;
        private System.Windows.Forms.Panel blockIPwindow;
        private System.Windows.Forms.Label blockIP;
        private System.Windows.Forms.Button pageMedian;
        private System.Windows.Forms.Button rightArrowforip;
        private System.Windows.Forms.TextBox ipEntry;
        private System.Windows.Forms.Label ipYeahweblocked;
        private System.Windows.Forms.TextBox testipWindow;
        private System.Windows.Forms.Panel managePage;
        private System.Windows.Forms.Panel emailDomainWindow;
        private System.Windows.Forms.Button webpageUsage;
        private System.Windows.Forms.Button domainSwitch;
        private System.Windows.Forms.Button homeButton2;
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
    }
}