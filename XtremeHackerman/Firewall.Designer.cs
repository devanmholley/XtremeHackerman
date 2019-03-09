namespace XtremeHackerman
{
    partial class Firewall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firewall));
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.blockIPwindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsPage)).BeginInit();
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
            this.testipWindow.Location = new System.Drawing.Point(438, 45);
            this.testipWindow.Multiline = true;
            this.testipWindow.Name = "testipWindow";
            this.testipWindow.ReadOnly = true;
            this.testipWindow.Size = new System.Drawing.Size(114, 20);
            this.testipWindow.TabIndex = 4;
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
            // Firewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 506);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Firewall";
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
    }
}