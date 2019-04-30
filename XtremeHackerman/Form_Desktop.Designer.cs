namespace XtremeHackerman
{
    partial class Form_Desktop
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
	    this.components = new System.ComponentModel.Container();
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Desktop));
	    this.panel1 = new System.Windows.Forms.Panel();
	    this.toolbarNetworkBTN = new System.Windows.Forms.Button();
	    this.toolbarTime = new System.Windows.Forms.Label();
	    this.toolbarDate = new System.Windows.Forms.Label();
	    this.startButton = new System.Windows.Forms.Button();
	    this.internetExplorerIcon = new System.Windows.Forms.Button();
	    this.commandIcon = new System.Windows.Forms.Button();
	    this.FileManagerIcon = new System.Windows.Forms.Button();
	    this.emailIcon = new System.Windows.Forms.Button();
	    this.Restart = new System.Windows.Forms.Button();
	    this.Shutdown = new System.Windows.Forms.Button();
	    this.InternetBrowser = new System.Windows.Forms.Button();
	    this.TaskManager = new System.Windows.Forms.Button();
	    this.FileManager = new System.Windows.Forms.Button();
	    this.Email = new System.Windows.Forms.Button();
	    this.Btn_Ransom_Debug = new System.Windows.Forms.Button();
	    this.DesktopPermissions = new System.Windows.Forms.Timer(this.components);
	    this.RestartBootOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.restartNoChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.safeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.Antivirus = new System.Windows.Forms.Button();
	    this.AntivirusIcon = new System.Windows.Forms.Button();
	    this.panel1.SuspendLayout();
	    this.RestartBootOptions.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // panel1
	    // 
	    this.panel1.AutoSize = true;
	    this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	    this.panel1.Controls.Add(this.toolbarNetworkBTN);
	    this.panel1.Controls.Add(this.toolbarTime);
	    this.panel1.Controls.Add(this.toolbarDate);
	    this.panel1.Controls.Add(this.startButton);
	    this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
	    this.panel1.Location = new System.Drawing.Point(0, 1543);
	    this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(2869, 102);
	    this.panel1.TabIndex = 0;
	    // 
	    // toolbarNetworkBTN
	    // 
	    this.toolbarNetworkBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
	    this.toolbarNetworkBTN.AutoSize = true;
	    this.toolbarNetworkBTN.BackgroundImage = global::XtremeHackerman.Properties.Resources.WifiIcon;
	    this.toolbarNetworkBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	    this.toolbarNetworkBTN.FlatAppearance.BorderSize = 0;
	    this.toolbarNetworkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.toolbarNetworkBTN.Location = new System.Drawing.Point(2553, 7);
	    this.toolbarNetworkBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.toolbarNetworkBTN.Name = "toolbarNetworkBTN";
	    this.toolbarNetworkBTN.Size = new System.Drawing.Size(83, 62);
	    this.toolbarNetworkBTN.TabIndex = 11;
	    this.toolbarNetworkBTN.UseVisualStyleBackColor = true;
	    this.toolbarNetworkBTN.Click += new System.EventHandler(this.toolbarNetworkBTN_Click);
	    // 
	    // toolbarTime
	    // 
	    this.toolbarTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
	    this.toolbarTime.AutoSize = true;
	    this.toolbarTime.Location = new System.Drawing.Point(2718, 0);
	    this.toolbarTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.toolbarTime.Name = "toolbarTime";
	    this.toolbarTime.Size = new System.Drawing.Size(87, 32);
	    this.toolbarTime.TabIndex = 10;
	    this.toolbarTime.Text = "22:00";
	    // 
	    // toolbarDate
	    // 
	    this.toolbarDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
	    this.toolbarDate.AutoSize = true;
	    this.toolbarDate.Location = new System.Drawing.Point(2683, 38);
	    this.toolbarDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.toolbarDate.Name = "toolbarDate";
	    this.toolbarDate.Size = new System.Drawing.Size(143, 32);
	    this.toolbarDate.TabIndex = 9;
	    this.toolbarDate.Text = "3/18/2019";
	    // 
	    // startButton
	    // 
	    this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
	    this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	    this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
	    this.startButton.Image = global::XtremeHackerman.Properties.Resources.StartButton;
	    this.startButton.Location = new System.Drawing.Point(-5, -12);
	    this.startButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.startButton.Name = "startButton";
	    this.startButton.Size = new System.Drawing.Size(235, 103);
	    this.startButton.TabIndex = 8;
	    this.startButton.UseVisualStyleBackColor = false;
	    this.startButton.Click += new System.EventHandler(this.startButtonClick);
	    // 
	    // internetExplorerIcon
	    // 
	    this.internetExplorerIcon.BackColor = System.Drawing.Color.Transparent;
	    this.internetExplorerIcon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_InternetExplorer;
	    this.internetExplorerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.internetExplorerIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.internetExplorerIcon.Location = new System.Drawing.Point(195, 81);
	    this.internetExplorerIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.internetExplorerIcon.Name = "internetExplorerIcon";
	    this.internetExplorerIcon.Size = new System.Drawing.Size(253, 188);
	    this.internetExplorerIcon.TabIndex = 7;
	    this.internetExplorerIcon.UseVisualStyleBackColor = false;
	    this.internetExplorerIcon.Click += new System.EventHandler(this.internetExplorerClick);
	    // 
	    // commandIcon
	    // 
	    this.commandIcon.BackColor = System.Drawing.Color.Transparent;
	    this.commandIcon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_CommandLine;
	    this.commandIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.commandIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.commandIcon.Location = new System.Drawing.Point(195, 343);
	    this.commandIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.commandIcon.Name = "commandIcon";
	    this.commandIcon.Size = new System.Drawing.Size(253, 188);
	    this.commandIcon.TabIndex = 8;
	    this.commandIcon.UseVisualStyleBackColor = false;
	    this.commandIcon.Click += new System.EventHandler(this.commandIconClick);
	    // 
	    // FileManagerIcon
	    // 
	    this.FileManagerIcon.BackColor = System.Drawing.Color.Transparent;
	    this.FileManagerIcon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_FileManager;
	    this.FileManagerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.FileManagerIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.FileManagerIcon.Location = new System.Drawing.Point(195, 610);
	    this.FileManagerIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.FileManagerIcon.Name = "FileManagerIcon";
	    this.FileManagerIcon.Size = new System.Drawing.Size(253, 188);
	    this.FileManagerIcon.TabIndex = 9;
	    this.FileManagerIcon.UseVisualStyleBackColor = false;
	    this.FileManagerIcon.Click += new System.EventHandler(this.FileManagerButtonClick);
	    // 
	    // emailIcon
	    // 
	    this.emailIcon.BackColor = System.Drawing.Color.Transparent;
	    this.emailIcon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_Email1;
	    this.emailIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.emailIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.emailIcon.Location = new System.Drawing.Point(195, 885);
	    this.emailIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.emailIcon.Name = "emailIcon";
	    this.emailIcon.Size = new System.Drawing.Size(253, 188);
	    this.emailIcon.TabIndex = 10;
	    this.emailIcon.UseVisualStyleBackColor = false;
	    this.emailIcon.Click += new System.EventHandler(this.emailButtonClick);
	    // 
	    // Restart
	    // 
	    this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Restart.Location = new System.Drawing.Point(0, 1531);
	    this.Restart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Restart.Name = "Restart";
	    this.Restart.Size = new System.Drawing.Size(235, 55);
	    this.Restart.TabIndex = 10;
	    this.Restart.Text = "Restart";
	    this.Restart.UseVisualStyleBackColor = false;
	    this.Restart.Visible = false;
	    this.Restart.Click += new System.EventHandler(this.Restart_Click);
	    // 
	    // Shutdown
	    // 
	    this.Shutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.Shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Shutdown.Location = new System.Drawing.Point(0, 1462);
	    this.Shutdown.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Shutdown.Name = "Shutdown";
	    this.Shutdown.Size = new System.Drawing.Size(235, 55);
	    this.Shutdown.TabIndex = 11;
	    this.Shutdown.Text = "Shutdown";
	    this.Shutdown.UseVisualStyleBackColor = false;
	    this.Shutdown.Visible = false;
	    this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
	    // 
	    // InternetBrowser
	    // 
	    this.InternetBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.InternetBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.InternetBrowser.Location = new System.Drawing.Point(0, 1393);
	    this.InternetBrowser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.InternetBrowser.Name = "InternetBrowser";
	    this.InternetBrowser.Size = new System.Drawing.Size(235, 55);
	    this.InternetBrowser.TabIndex = 12;
	    this.InternetBrowser.Text = "Internet Browser";
	    this.InternetBrowser.UseVisualStyleBackColor = false;
	    this.InternetBrowser.Visible = false;
	    this.InternetBrowser.Click += new System.EventHandler(this.InternetBrowser_Click);
	    // 
	    // TaskManager
	    // 
	    this.TaskManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.TaskManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.TaskManager.Location = new System.Drawing.Point(0, 1323);
	    this.TaskManager.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.TaskManager.Name = "TaskManager";
	    this.TaskManager.Size = new System.Drawing.Size(235, 55);
	    this.TaskManager.TabIndex = 13;
	    this.TaskManager.Text = "Task Manager ";
	    this.TaskManager.UseVisualStyleBackColor = false;
	    this.TaskManager.Visible = false;
	    this.TaskManager.Click += new System.EventHandler(this.TaskManager_Click);
	    // 
	    // FileManager
	    // 
	    this.FileManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.FileManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.FileManager.Location = new System.Drawing.Point(0, 1254);
	    this.FileManager.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.FileManager.Name = "FileManager";
	    this.FileManager.Size = new System.Drawing.Size(235, 55);
	    this.FileManager.TabIndex = 14;
	    this.FileManager.Text = "File Manager";
	    this.FileManager.UseVisualStyleBackColor = false;
	    this.FileManager.Visible = false;
	    this.FileManager.Click += new System.EventHandler(this.FileManager_Click);
	    // 
	    // Email
	    // 
	    this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Email.Location = new System.Drawing.Point(0, 1185);
	    this.Email.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Email.Name = "Email";
	    this.Email.Size = new System.Drawing.Size(235, 55);
	    this.Email.TabIndex = 15;
	    this.Email.Text = "Email";
	    this.Email.UseVisualStyleBackColor = false;
	    this.Email.Visible = false;
	    // 
	    // Btn_Ransom_Debug
	    // 
	    this.Btn_Ransom_Debug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ransom_Debug.BackgroundImage")));
	    this.Btn_Ransom_Debug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.Btn_Ransom_Debug.Location = new System.Drawing.Point(1427, 31);
	    this.Btn_Ransom_Debug.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Btn_Ransom_Debug.Name = "Btn_Ransom_Debug";
	    this.Btn_Ransom_Debug.Size = new System.Drawing.Size(147, 138);
	    this.Btn_Ransom_Debug.TabIndex = 16;
	    this.Btn_Ransom_Debug.Text = "button1";
	    this.Btn_Ransom_Debug.UseVisualStyleBackColor = true;
	    this.Btn_Ransom_Debug.Visible = false;
	    this.Btn_Ransom_Debug.Click += new System.EventHandler(this.Btn_Ransom_Debug_Click);
	    // 
	    // DesktopPermissions
	    // 
	    this.DesktopPermissions.Enabled = true;
	    this.DesktopPermissions.Interval = 1000;
	    this.DesktopPermissions.Tick += new System.EventHandler(this.DesktopPermissions_Tick);
	    // 
	    // RestartBootOptions
	    // 
	    this.RestartBootOptions.BackColor = System.Drawing.Color.Violet;
	    this.RestartBootOptions.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.RestartBootOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartNoChangesToolStripMenuItem,
            this.safeModeToolStripMenuItem});
	    this.RestartBootOptions.Name = "RestartBootOptions";
	    this.RestartBootOptions.Size = new System.Drawing.Size(240, 96);
	    // 
	    // restartNoChangesToolStripMenuItem
	    // 
	    this.restartNoChangesToolStripMenuItem.Name = "restartNoChangesToolStripMenuItem";
	    this.restartNoChangesToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
	    this.restartNoChangesToolStripMenuItem.Text = "Restart";
	    this.restartNoChangesToolStripMenuItem.Click += new System.EventHandler(this.restartNoChangesToolStripMenuItem_Click);
	    // 
	    // safeModeToolStripMenuItem
	    // 
	    this.safeModeToolStripMenuItem.Name = "safeModeToolStripMenuItem";
	    this.safeModeToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
	    this.safeModeToolStripMenuItem.Text = "Safe Mode";
	    this.safeModeToolStripMenuItem.Click += new System.EventHandler(this.safeModeToolStripMenuItem_Click);
	    // 
	    // Antivirus
	    // 
	    this.Antivirus.BackColor = System.Drawing.Color.Transparent;
	    this.Antivirus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Antivirus.BackgroundImage")));
	    this.Antivirus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.Antivirus.Cursor = System.Windows.Forms.Cursors.Default;
	    this.Antivirus.Location = new System.Drawing.Point(582, 81);
	    this.Antivirus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Antivirus.Name = "Antivirus";
	    this.Antivirus.Size = new System.Drawing.Size(253, 188);
	    this.Antivirus.TabIndex = 17;
	    this.Antivirus.UseVisualStyleBackColor = false;
	    this.Antivirus.Click += new System.EventHandler(this.Antivirus_Click);
	    // 
	    // AntivirusIcon
	    // 
	    this.AntivirusIcon.BackColor = System.Drawing.Color.Transparent;
	    this.AntivirusIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AntivirusIcon.BackgroundImage")));
	    this.AntivirusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.AntivirusIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.AntivirusIcon.Location = new System.Drawing.Point(534, 81);
	    this.AntivirusIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.AntivirusIcon.Name = "AntivirusIcon";
	    this.AntivirusIcon.Size = new System.Drawing.Size(253, 188);
	    this.AntivirusIcon.TabIndex = 17;
	    this.AntivirusIcon.UseVisualStyleBackColor = false;
	    this.AntivirusIcon.Click += new System.EventHandler(this.Antivirus_Click);
	    // 
	    // Form_Desktop
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackgroundImage = global::XtremeHackerman.Properties.Resources.Background_Desktop;
	    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.ClientSize = new System.Drawing.Size(2869, 1645);
	    this.Controls.Add(this.AntivirusIcon);
	    this.Controls.Add(this.Btn_Ransom_Debug);
	    this.Controls.Add(this.Email);
	    this.Controls.Add(this.Restart);
	    this.Controls.Add(this.Shutdown);
	    this.Controls.Add(this.InternetBrowser);
	    this.Controls.Add(this.TaskManager);
	    this.Controls.Add(this.FileManager);
	    this.Controls.Add(this.emailIcon);
	    this.Controls.Add(this.FileManagerIcon);
	    this.Controls.Add(this.commandIcon);
	    this.Controls.Add(this.internetExplorerIcon);
	    this.Controls.Add(this.panel1);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_Desktop";
	    this.ShowIcon = false;
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Desktop - Xtreme Hackerman";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.panel1.ResumeLayout(false);
	    this.panel1.PerformLayout();
	    this.RestartBootOptions.ResumeLayout(false);
	    this.ResumeLayout(false);
	    this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button internetExplorerIcon;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button commandIcon;
        private System.Windows.Forms.Button FileManagerIcon;
        private System.Windows.Forms.Button emailIcon;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button InternetBrowser;
        private System.Windows.Forms.Button TaskManager;
        private System.Windows.Forms.Button FileManager;
        private System.Windows.Forms.Button Email;
        private System.Windows.Forms.Label toolbarDate;
        private System.Windows.Forms.Label toolbarTime;
        private System.Windows.Forms.Button toolbarNetworkBTN;
        private System.Windows.Forms.Button Btn_Ransom_Debug;
	private System.Windows.Forms.Button Antivirus;
        private System.Windows.Forms.Timer DesktopPermissions;
        private System.Windows.Forms.ContextMenuStrip RestartBootOptions;
        private System.Windows.Forms.ToolStripMenuItem restartNoChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeModeToolStripMenuItem;
	private System.Windows.Forms.Button AntivirusIcon;
    }
}