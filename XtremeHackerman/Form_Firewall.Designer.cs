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
            this.webaccessPanel = new System.Windows.Forms.Panel();
            this.webPanelAccess2 = new System.Windows.Forms.Panel();
            this.webmessageLabel = new System.Windows.Forms.Label();
            this.clearedWebLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webaccessBtnMedian = new System.Windows.Forms.Button();
            this.blacklistWebLabel = new System.Windows.Forms.Label();
            this.waccessTextEntry = new System.Windows.Forms.TextBox();
            this.waccessBLEntry = new System.Windows.Forms.TextBox();
            this.waccessInBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.managePage.SuspendLayout();
            this.emailDomainWindow.SuspendLayout();
            this.blockIPwindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsPage)).BeginInit();
            this.webaccessPanel.SuspendLayout();
            this.webPanelAccess2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Logout_Button);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, -1);
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
            this.splitContainer1.Size = new System.Drawing.Size(1034, 502);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(91, 25);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.permissionsToolStripMenuItem.Text = "Permissions";
            this.permissionsToolStripMenuItem.Click += new System.EventHandler(this.permissionsToolStripMenuItem_Click);
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.monitorToolStripMenuItem.Text = "Monitor";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
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
            this.managePage.Name = "managePage";
            this.managePage.Size = new System.Drawing.Size(939, 502);
            this.managePage.TabIndex = 8;
            this.managePage.Visible = false;
            // 
            // homeButton2
            // 
            this.homeButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton2.BackgroundImage")));
            this.homeButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton2.Location = new System.Drawing.Point(885, 451);
            this.homeButton2.Name = "homeButton2";
            this.homeButton2.Size = new System.Drawing.Size(51, 48);
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
            this.emailDomainWindow.Location = new System.Drawing.Point(100, 54);
            this.emailDomainWindow.Name = "emailDomainWindow";
            this.emailDomainWindow.Size = new System.Drawing.Size(749, 391);
            this.emailDomainWindow.TabIndex = 2;
            this.emailDomainWindow.Visible = false;
            // 
            // domainADD
            // 
            this.domainADD.Location = new System.Drawing.Point(313, 101);
            this.domainADD.Name = "domainADD";
            this.domainADD.Size = new System.Drawing.Size(75, 23);
            this.domainADD.TabIndex = 5;
            this.domainADD.Text = "Add";
            this.domainADD.UseVisualStyleBackColor = true;
            this.domainADD.Click += new System.EventHandler(this.domainADD_Click);
            // 
            // domainEntered
            // 
            this.domainEntered.AllowDrop = true;
            this.domainEntered.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.domainEntered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainEntered.Location = new System.Drawing.Point(40, 128);
            this.domainEntered.Multiline = true;
            this.domainEntered.Name = "domainEntered";
            this.domainEntered.Size = new System.Drawing.Size(226, 199);
            this.domainEntered.TabIndex = 4;
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
            this.discMessage.Location = new System.Drawing.Point(375, 0);
            this.discMessage.Name = "discMessage";
            this.discMessage.Size = new System.Drawing.Size(374, 13);
            this.discMessage.TabIndex = 1;
            this.discMessage.Text = "Disclaimer: Adding Domains to this page will blacklist the domain until removal.";
            // 
            // webpageUsage
            // 
            this.webpageUsage.Location = new System.Drawing.Point(167, 34);
            this.webpageUsage.Name = "webpageUsage";
            this.webpageUsage.Size = new System.Drawing.Size(92, 23);
            this.webpageUsage.TabIndex = 1;
            this.webpageUsage.Text = "Web Access";
            this.webpageUsage.UseVisualStyleBackColor = true;
            this.webpageUsage.Click += new System.EventHandler(this.webpageUsage_Click);
            // 
            // domainSwitch
            // 
            this.domainSwitch.Location = new System.Drawing.Point(100, 34);
            this.domainSwitch.Name = "domainSwitch";
            this.domainSwitch.Size = new System.Drawing.Size(75, 23);
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
            this.blockIPwindow.Location = new System.Drawing.Point(89, 208);
            this.blockIPwindow.Name = "blockIPwindow";
            this.blockIPwindow.Size = new System.Drawing.Size(657, 240);
            this.blockIPwindow.TabIndex = 7;
            // 
            // testipWindow
            // 
            this.testipWindow.AcceptsReturn = true;
            this.testipWindow.AllowDrop = true;
            this.testipWindow.Location = new System.Drawing.Point(424, 45);
            this.testipWindow.Multiline = true;
            this.testipWindow.Name = "testipWindow";
            this.testipWindow.ReadOnly = true;
            this.testipWindow.Size = new System.Drawing.Size(128, 160);
            this.testipWindow.TabIndex = 4;
            this.testipWindow.Text = "\r\n";
            this.testipWindow.TextChanged += new System.EventHandler(this.testipWindow_TextChanged);
            // 
            // ipYeahweblocked
            // 
            this.ipYeahweblocked.AutoSize = true;
            this.ipYeahweblocked.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ipYeahweblocked.Location = new System.Drawing.Point(575, 0);
            this.ipYeahweblocked.Name = "ipYeahweblocked";
            this.ipYeahweblocked.Size = new System.Drawing.Size(82, 13);
            this.ipYeahweblocked.TabIndex = 3;
            this.ipYeahweblocked.Text = "BlackListed IPS";
            this.ipYeahweblocked.Click += new System.EventHandler(this.ipYeahweblocked_Click);
            // 
            // pageMedian
            // 
            this.pageMedian.Location = new System.Drawing.Point(324, 0);
            this.pageMedian.Name = "pageMedian";
            this.pageMedian.Size = new System.Drawing.Size(10, 240);
            this.pageMedian.TabIndex = 2;
            this.pageMedian.Text = "button3";
            this.pageMedian.UseVisualStyleBackColor = true;
            // 
            // rightArrowforip
            // 
            this.rightArrowforip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrowforip.BackgroundImage")));
            this.rightArrowforip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightArrowforip.Location = new System.Drawing.Point(172, 42);
            this.rightArrowforip.Name = "rightArrowforip";
            this.rightArrowforip.Size = new System.Drawing.Size(28, 23);
            this.rightArrowforip.TabIndex = 1;
            this.rightArrowforip.UseVisualStyleBackColor = true;
            this.rightArrowforip.Click += new System.EventHandler(this.rightArrowforip_Click);
            // 
            // ipEntry
            // 
            this.ipEntry.Location = new System.Drawing.Point(35, 45);
            this.ipEntry.Name = "ipEntry";
            this.ipEntry.Size = new System.Drawing.Size(118, 20);
            this.ipEntry.TabIndex = 0;
            this.ipEntry.TextChanged += new System.EventHandler(this.ipEntry_TextChanged);
            // 
            // blockIP
            // 
            this.blockIP.AutoSize = true;
            this.blockIP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.blockIP.Location = new System.Drawing.Point(86, 181);
            this.blockIP.Name = "blockIP";
            this.blockIP.Size = new System.Drawing.Size(67, 13);
            this.blockIP.TabIndex = 6;
            this.blockIP.Text = "Blocked IPs:";
            this.blockIP.Click += new System.EventHandler(this.blockIP_Click);
            // 
            // homeButton1perm
            // 
            this.homeButton1perm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton1perm.BackgroundImage")));
            this.homeButton1perm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton1perm.Location = new System.Drawing.Point(898, 463);
            this.homeButton1perm.Name = "homeButton1perm";
            this.homeButton1perm.Size = new System.Drawing.Size(38, 39);
            this.homeButton1perm.TabIndex = 5;
            this.homeButton1perm.UseVisualStyleBackColor = true;
            this.homeButton1perm.Click += new System.EventHandler(this.homeButton1perm_Click);
            // 
            // permissionsPage
            // 
            this.permissionsPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.permissionsPage.Location = new System.Drawing.Point(-1, 0);
            this.permissionsPage.Name = "permissionsPage";
            this.permissionsPage.Size = new System.Drawing.Size(940, 502);
            this.permissionsPage.TabIndex = 4;
            this.permissionsPage.TabStop = false;
            // 
            // welcomeMessagelabel
            // 
            this.welcomeMessagelabel.AutoSize = true;
            this.welcomeMessagelabel.Location = new System.Drawing.Point(465, 172);
            this.welcomeMessagelabel.Name = "welcomeMessagelabel";
            this.welcomeMessagelabel.Size = new System.Drawing.Size(118, 13);
            this.welcomeMessagelabel.TabIndex = 1;
            this.welcomeMessagelabel.Text = "Welcome Mr. Anderson";
            // 
            // webaccessPanel
            // 
            this.webaccessPanel.Controls.Add(this.webmessageLabel);
            this.webaccessPanel.Controls.Add(this.webPanelAccess2);
            this.webaccessPanel.Location = new System.Drawing.Point(0, 0);
            this.webaccessPanel.Name = "webaccessPanel";
            this.webaccessPanel.Size = new System.Drawing.Size(749, 394);
            this.webaccessPanel.TabIndex = 6;
            this.webaccessPanel.Visible = false;
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
            this.webPanelAccess2.Location = new System.Drawing.Point(72, 90);
            this.webPanelAccess2.Name = "webPanelAccess2";
            this.webPanelAccess2.Size = new System.Drawing.Size(538, 261);
            this.webPanelAccess2.TabIndex = 0;
            // 
            // webmessageLabel
            // 
            this.webmessageLabel.AutoSize = true;
            this.webmessageLabel.Location = new System.Drawing.Point(435, 74);
            this.webmessageLabel.Name = "webmessageLabel";
            this.webmessageLabel.Size = new System.Drawing.Size(175, 13);
            this.webmessageLabel.TabIndex = 1;
            this.webmessageLabel.Text = "Add sites users cannot go to below.";
            // 
            // clearedWebLabel
            // 
            this.clearedWebLabel.AutoSize = true;
            this.clearedWebLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clearedWebLabel.Location = new System.Drawing.Point(3, 11);
            this.clearedWebLabel.Name = "clearedWebLabel";
            this.clearedWebLabel.Size = new System.Drawing.Size(46, 13);
            this.clearedWebLabel.TabIndex = 0;
            this.clearedWebLabel.Text = "Cleared:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 178);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "VirusTotals.com\r\n<filler>\r\n<filler>";
            // 
            // webaccessBtnMedian
            // 
            this.webaccessBtnMedian.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.webaccessBtnMedian.Location = new System.Drawing.Point(235, 0);
            this.webaccessBtnMedian.Name = "webaccessBtnMedian";
            this.webaccessBtnMedian.Size = new System.Drawing.Size(15, 261);
            this.webaccessBtnMedian.TabIndex = 2;
            this.webaccessBtnMedian.UseVisualStyleBackColor = true;
            // 
            // blacklistWebLabel
            // 
            this.blacklistWebLabel.AutoSize = true;
            this.blacklistWebLabel.Location = new System.Drawing.Point(267, 15);
            this.blacklistWebLabel.Name = "blacklistWebLabel";
            this.blacklistWebLabel.Size = new System.Drawing.Size(61, 13);
            this.blacklistWebLabel.TabIndex = 3;
            this.blacklistWebLabel.Text = "Blacklisted:";
            // 
            // waccessTextEntry
            // 
            this.waccessTextEntry.Location = new System.Drawing.Point(334, 12);
            this.waccessTextEntry.Name = "waccessTextEntry";
            this.waccessTextEntry.Size = new System.Drawing.Size(100, 20);
            this.waccessTextEntry.TabIndex = 4;
            // 
            // waccessBLEntry
            // 
            this.waccessBLEntry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.waccessBLEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waccessBLEntry.Location = new System.Drawing.Point(270, 37);
            this.waccessBLEntry.Multiline = true;
            this.waccessBLEntry.Name = "waccessBLEntry";
            this.waccessBLEntry.Size = new System.Drawing.Size(141, 179);
            this.waccessBLEntry.TabIndex = 5;
            // 
            // waccessInBtn
            // 
            this.waccessInBtn.BackColor = System.Drawing.SystemColors.Control;
            this.waccessInBtn.Location = new System.Drawing.Point(440, 11);
            this.waccessInBtn.Name = "waccessInBtn";
            this.waccessInBtn.Size = new System.Drawing.Size(75, 23);
            this.waccessInBtn.TabIndex = 6;
            this.waccessInBtn.Text = "Add:";
            this.waccessInBtn.UseVisualStyleBackColor = false;
            this.waccessInBtn.Click += new System.EventHandler(this.waccessInBtn_Click);
            // 
            // Firewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 506);
            this.Controls.Add(this.splitContainer1);
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
            this.blockIPwindow.ResumeLayout(false);
            this.blockIPwindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsPage)).EndInit();
            this.webaccessPanel.ResumeLayout(false);
            this.webaccessPanel.PerformLayout();
            this.webPanelAccess2.ResumeLayout(false);
            this.webPanelAccess2.PerformLayout();
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