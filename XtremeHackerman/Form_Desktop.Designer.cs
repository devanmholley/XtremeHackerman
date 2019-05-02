﻿namespace XtremeHackerman
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
	    this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
	    this.RestartBootOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.restartNoChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.safeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.Antivirus = new System.Windows.Forms.Button();
	    this.AntivirusIcon = new System.Windows.Forms.Button();
	    this.StartMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
	    this.LogOut = new System.Windows.Forms.Button();
	    this.IconsPanel = new System.Windows.Forms.FlowLayoutPanel();
	    this.WireSharkIcon = new System.Windows.Forms.Button();
	    this.eventProgress = new System.Windows.Forms.ProgressBar();
	    this.ProgressPanel = new System.Windows.Forms.Panel();
	    this.HintIcon = new System.Windows.Forms.Button();
	    this.eventLBL = new System.Windows.Forms.Label();
	    this.CurrEventLBL = new System.Windows.Forms.Label();
	    this.TaskbarPanel = new System.Windows.Forms.SplitContainer();
	    this.panel1 = new System.Windows.Forms.Panel();
	    this.RansomwarePanel = new System.Windows.Forms.Panel();
	    this.RightPanel = new System.Windows.Forms.Panel();
	    this.Btn_Next_Ransom = new System.Windows.Forms.Button();
	    this.label_Warning = new System.Windows.Forms.Label();
	    this.TB_Ransomeware_Description = new System.Windows.Forms.TextBox();
	    this.LeftPanel = new System.Windows.Forms.Panel();
	    this.Label_date = new System.Windows.Forms.Label();
	    this.Label_Destroy_Warning = new System.Windows.Forms.Label();
	    this.PB_Ransom_Icon = new System.Windows.Forms.PictureBox();
	    this.RestartBootOptions.SuspendLayout();
	    this.StartMenuPanel.SuspendLayout();
	    this.IconsPanel.SuspendLayout();
	    this.ProgressPanel.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.TaskbarPanel)).BeginInit();
	    this.TaskbarPanel.Panel1.SuspendLayout();
	    this.TaskbarPanel.Panel2.SuspendLayout();
	    this.TaskbarPanel.SuspendLayout();
	    this.panel1.SuspendLayout();
	    this.RansomwarePanel.SuspendLayout();
	    this.RightPanel.SuspendLayout();
	    this.LeftPanel.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.PB_Ransom_Icon)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // toolbarNetworkBTN
	    // 
	    this.toolbarNetworkBTN.AutoSize = true;
	    this.toolbarNetworkBTN.BackgroundImage = global::XtremeHackerman.Properties.Resources.WifiIcon;
	    this.toolbarNetworkBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
	    this.toolbarNetworkBTN.Dock = System.Windows.Forms.DockStyle.Left;
	    this.toolbarNetworkBTN.FlatAppearance.BorderSize = 0;
	    this.toolbarNetworkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.toolbarNetworkBTN.Location = new System.Drawing.Point(0, 0);
	    this.toolbarNetworkBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.toolbarNetworkBTN.Name = "toolbarNetworkBTN";
	    this.toolbarNetworkBTN.Size = new System.Drawing.Size(83, 100);
	    this.toolbarNetworkBTN.TabIndex = 11;
	    this.toolbarNetworkBTN.UseVisualStyleBackColor = true;
	    this.toolbarNetworkBTN.Click += new System.EventHandler(this.toolbarNetworkBTN_Click);
	    // 
	    // toolbarTime
	    // 
	    this.toolbarTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
	    this.toolbarTime.AutoSize = true;
	    this.toolbarTime.Location = new System.Drawing.Point(116, 12);
	    this.toolbarTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.toolbarTime.Name = "toolbarTime";
	    this.toolbarTime.Size = new System.Drawing.Size(136, 32);
	    this.toolbarTime.TabIndex = 10;
	    this.toolbarTime.Text = "22:00 PM";
	    // 
	    // toolbarDate
	    // 
	    this.toolbarDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
	    this.toolbarDate.AutoSize = true;
	    this.toolbarDate.Location = new System.Drawing.Point(110, 57);
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
	    this.startButton.Dock = System.Windows.Forms.DockStyle.Left;
	    this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	    this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
	    this.startButton.Image = global::XtremeHackerman.Properties.Resources.StartButton;
	    this.startButton.Location = new System.Drawing.Point(0, 0);
	    this.startButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.startButton.Name = "startButton";
	    this.startButton.Size = new System.Drawing.Size(235, 100);
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
	    this.internetExplorerIcon.Location = new System.Drawing.Point(78, 77);
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
	    this.commandIcon.Location = new System.Drawing.Point(78, 885);
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
	    this.FileManagerIcon.Location = new System.Drawing.Point(78, 481);
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
	    this.emailIcon.Location = new System.Drawing.Point(78, 279);
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
	    this.Restart.Location = new System.Drawing.Point(8, 100);
	    this.Restart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Restart.Name = "Restart";
	    this.Restart.Size = new System.Drawing.Size(280, 70);
	    this.Restart.TabIndex = 10;
	    this.Restart.Text = "Restart";
	    this.Restart.UseVisualStyleBackColor = false;
	    this.Restart.Click += new System.EventHandler(this.Restart_Click);
	    // 
	    // Shutdown
	    // 
	    this.Shutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.Shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Shutdown.Location = new System.Drawing.Point(8, 184);
	    this.Shutdown.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Shutdown.Name = "Shutdown";
	    this.Shutdown.Size = new System.Drawing.Size(280, 70);
	    this.Shutdown.TabIndex = 11;
	    this.Shutdown.Text = "Shutdown";
	    this.Shutdown.UseVisualStyleBackColor = false;
	    this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
	    // 
	    // InternetBrowser
	    // 
	    this.InternetBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.InternetBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.InternetBrowser.Location = new System.Drawing.Point(600, 184);
	    this.InternetBrowser.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.InternetBrowser.Name = "InternetBrowser";
	    this.InternetBrowser.Size = new System.Drawing.Size(280, 70);
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
	    this.TaskManager.Location = new System.Drawing.Point(304, 184);
	    this.TaskManager.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.TaskManager.Name = "TaskManager";
	    this.TaskManager.Size = new System.Drawing.Size(280, 70);
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
	    this.FileManager.Location = new System.Drawing.Point(304, 16);
	    this.FileManager.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.FileManager.Name = "FileManager";
	    this.FileManager.Size = new System.Drawing.Size(280, 70);
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
	    this.Email.Location = new System.Drawing.Point(304, 100);
	    this.Email.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Email.Name = "Email";
	    this.Email.Size = new System.Drawing.Size(280, 70);
	    this.Email.TabIndex = 15;
	    this.Email.Text = "Email";
	    this.Email.UseVisualStyleBackColor = false;
	    this.Email.Visible = false;
	    // 
	    // RefreshTimer
	    // 
	    this.RefreshTimer.Enabled = true;
	    this.RefreshTimer.Interval = 1000;
	    this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
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
	    this.AntivirusIcon.Location = new System.Drawing.Point(78, 683);
	    this.AntivirusIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.AntivirusIcon.Name = "AntivirusIcon";
	    this.AntivirusIcon.Size = new System.Drawing.Size(253, 188);
	    this.AntivirusIcon.TabIndex = 17;
	    this.AntivirusIcon.UseVisualStyleBackColor = false;
	    this.AntivirusIcon.Click += new System.EventHandler(this.Antivirus_Click);
	    // 
	    // StartMenuPanel
	    // 
	    this.StartMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	    this.StartMenuPanel.BackColor = System.Drawing.Color.Transparent;
	    this.StartMenuPanel.Controls.Add(this.Shutdown);
	    this.StartMenuPanel.Controls.Add(this.Restart);
	    this.StartMenuPanel.Controls.Add(this.LogOut);
	    this.StartMenuPanel.Controls.Add(this.TaskManager);
	    this.StartMenuPanel.Controls.Add(this.Email);
	    this.StartMenuPanel.Controls.Add(this.FileManager);
	    this.StartMenuPanel.Controls.Add(this.InternetBrowser);
	    this.StartMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
	    this.StartMenuPanel.Location = new System.Drawing.Point(0, 1282);
	    this.StartMenuPanel.Name = "StartMenuPanel";
	    this.StartMenuPanel.Size = new System.Drawing.Size(307, 261);
	    this.StartMenuPanel.TabIndex = 18;
	    this.StartMenuPanel.Visible = false;
	    // 
	    // LogOut
	    // 
	    this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.LogOut.Location = new System.Drawing.Point(8, 16);
	    this.LogOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.LogOut.Name = "LogOut";
	    this.LogOut.Size = new System.Drawing.Size(280, 70);
	    this.LogOut.TabIndex = 16;
	    this.LogOut.Text = "Log Out";
	    this.LogOut.UseVisualStyleBackColor = false;
	    this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
	    // 
	    // IconsPanel
	    // 
	    this.IconsPanel.BackColor = System.Drawing.Color.Transparent;
	    this.IconsPanel.Controls.Add(this.internetExplorerIcon);
	    this.IconsPanel.Controls.Add(this.emailIcon);
	    this.IconsPanel.Controls.Add(this.FileManagerIcon);
	    this.IconsPanel.Controls.Add(this.AntivirusIcon);
	    this.IconsPanel.Controls.Add(this.commandIcon);
	    this.IconsPanel.Controls.Add(this.WireSharkIcon);
	    this.IconsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.IconsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
	    this.IconsPanel.Location = new System.Drawing.Point(0, 0);
	    this.IconsPanel.Margin = new System.Windows.Forms.Padding(5);
	    this.IconsPanel.Name = "IconsPanel";
	    this.IconsPanel.Padding = new System.Windows.Forms.Padding(70, 70, 0, 0);
	    this.IconsPanel.Size = new System.Drawing.Size(2454, 1545);
	    this.IconsPanel.TabIndex = 16;
	    // 
	    // WireSharkIcon
	    // 
	    this.WireSharkIcon.BackColor = System.Drawing.Color.White;
	    this.WireSharkIcon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_Wireshark;
	    this.WireSharkIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.WireSharkIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.WireSharkIcon.Location = new System.Drawing.Point(78, 1087);
	    this.WireSharkIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.WireSharkIcon.Name = "WireSharkIcon";
	    this.WireSharkIcon.Size = new System.Drawing.Size(253, 188);
	    this.WireSharkIcon.TabIndex = 18;
	    this.WireSharkIcon.UseVisualStyleBackColor = false;
	    this.WireSharkIcon.Click += new System.EventHandler(this.WiresharkIcon_Click);
	    // 
	    // eventProgress
	    // 
	    this.eventProgress.BackColor = System.Drawing.Color.Gray;
	    this.eventProgress.Dock = System.Windows.Forms.DockStyle.Top;
	    this.eventProgress.Location = new System.Drawing.Point(0, 0);
	    this.eventProgress.Name = "eventProgress";
	    this.eventProgress.Size = new System.Drawing.Size(415, 60);
	    this.eventProgress.TabIndex = 16;
	    // 
	    // ProgressPanel
	    // 
	    this.ProgressPanel.BackColor = System.Drawing.Color.Transparent;
	    this.ProgressPanel.Controls.Add(this.HintIcon);
	    this.ProgressPanel.Controls.Add(this.eventLBL);
	    this.ProgressPanel.Controls.Add(this.CurrEventLBL);
	    this.ProgressPanel.Controls.Add(this.eventProgress);
	    this.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Right;
	    this.ProgressPanel.Location = new System.Drawing.Point(2454, 0);
	    this.ProgressPanel.Name = "ProgressPanel";
	    this.ProgressPanel.Size = new System.Drawing.Size(415, 1545);
	    this.ProgressPanel.TabIndex = 19;
	    // 
	    // HintIcon
	    // 
	    this.HintIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HintIcon.BackgroundImage")));
	    this.HintIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.HintIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.HintIcon.Location = new System.Drawing.Point(119, 187);
	    this.HintIcon.Name = "HintIcon";
	    this.HintIcon.Size = new System.Drawing.Size(182, 150);
	    this.HintIcon.TabIndex = 16;
	    this.HintIcon.Text = "Hint";
	    this.HintIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    this.HintIcon.UseVisualStyleBackColor = true;
	    // 
	    // eventLBL
	    // 
	    this.eventLBL.AutoSize = true;
	    this.eventLBL.Dock = System.Windows.Forms.DockStyle.Top;
	    this.eventLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.eventLBL.ForeColor = System.Drawing.Color.Teal;
	    this.eventLBL.Location = new System.Drawing.Point(0, 121);
	    this.eventLBL.Name = "eventLBL";
	    this.eventLBL.Size = new System.Drawing.Size(156, 61);
	    this.eventLBL.TabIndex = 20;
	    this.eventLBL.Text = "event";
	    this.eventLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // CurrEventLBL
	    // 
	    this.CurrEventLBL.Dock = System.Windows.Forms.DockStyle.Top;
	    this.CurrEventLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.CurrEventLBL.ForeColor = System.Drawing.Color.White;
	    this.CurrEventLBL.Location = new System.Drawing.Point(0, 60);
	    this.CurrEventLBL.Name = "CurrEventLBL";
	    this.CurrEventLBL.Size = new System.Drawing.Size(415, 61);
	    this.CurrEventLBL.TabIndex = 17;
	    this.CurrEventLBL.Text = "Current Event:";
	    this.CurrEventLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    // 
	    // TaskbarPanel
	    // 
	    this.TaskbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.TaskbarPanel.Location = new System.Drawing.Point(0, 1545);
	    this.TaskbarPanel.Name = "TaskbarPanel";
	    // 
	    // TaskbarPanel.Panel1
	    // 
	    this.TaskbarPanel.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.TaskbarPanel.Panel1.Controls.Add(this.startButton);
	    // 
	    // TaskbarPanel.Panel2
	    // 
	    this.TaskbarPanel.Panel2.Controls.Add(this.panel1);
	    this.TaskbarPanel.Size = new System.Drawing.Size(2869, 100);
	    this.TaskbarPanel.SplitterDistance = 2583;
	    this.TaskbarPanel.TabIndex = 12;
	    // 
	    // panel1
	    // 
	    this.panel1.Controls.Add(this.toolbarTime);
	    this.panel1.Controls.Add(this.toolbarNetworkBTN);
	    this.panel1.Controls.Add(this.toolbarDate);
	    this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.panel1.Location = new System.Drawing.Point(0, 0);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(282, 100);
	    this.panel1.TabIndex = 12;
	    // 
	    // RansomwarePanel
	    // 
	    this.RansomwarePanel.BackColor = System.Drawing.Color.Red;
	    this.RansomwarePanel.Controls.Add(this.RightPanel);
	    this.RansomwarePanel.Controls.Add(this.LeftPanel);
	    this.RansomwarePanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.RansomwarePanel.Location = new System.Drawing.Point(0, 0);
	    this.RansomwarePanel.Name = "RansomwarePanel";
	    this.RansomwarePanel.Size = new System.Drawing.Size(2454, 1545);
	    this.RansomwarePanel.TabIndex = 21;
	    // 
	    // RightPanel
	    // 
	    this.RightPanel.Controls.Add(this.Btn_Next_Ransom);
	    this.RightPanel.Controls.Add(this.label_Warning);
	    this.RightPanel.Controls.Add(this.TB_Ransomeware_Description);
	    this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.RightPanel.ForeColor = System.Drawing.SystemColors.WindowText;
	    this.RightPanel.Location = new System.Drawing.Point(1328, 0);
	    this.RightPanel.Name = "RightPanel";
	    this.RightPanel.Size = new System.Drawing.Size(1126, 1545);
	    this.RightPanel.TabIndex = 9;
	    // 
	    // Btn_Next_Ransom
	    // 
	    this.Btn_Next_Ransom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
	    this.Btn_Next_Ransom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Btn_Next_Ransom.Location = new System.Drawing.Point(759, 1384);
	    this.Btn_Next_Ransom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Btn_Next_Ransom.Name = "Btn_Next_Ransom";
	    this.Btn_Next_Ransom.Size = new System.Drawing.Size(328, 117);
	    this.Btn_Next_Ransom.TabIndex = 7;
	    this.Btn_Next_Ransom.Text = "Next";
	    this.Btn_Next_Ransom.UseVisualStyleBackColor = true;
	    // 
	    // label_Warning
	    // 
	    this.label_Warning.Dock = System.Windows.Forms.DockStyle.Top;
	    this.label_Warning.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.label_Warning.ForeColor = System.Drawing.Color.White;
	    this.label_Warning.Location = new System.Drawing.Point(0, 0);
	    this.label_Warning.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.label_Warning.Name = "label_Warning";
	    this.label_Warning.Size = new System.Drawing.Size(1126, 150);
	    this.label_Warning.TabIndex = 0;
	    this.label_Warning.Text = "Your personal files are encrypted!";
	    this.label_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // TB_Ransomeware_Description
	    // 
	    this.TB_Ransomeware_Description.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
	    this.TB_Ransomeware_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
	    this.TB_Ransomeware_Description.BackColor = System.Drawing.Color.White;
	    this.TB_Ransomeware_Description.Enabled = false;
	    this.TB_Ransomeware_Description.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.TB_Ransomeware_Description.ForeColor = System.Drawing.Color.Black;
	    this.TB_Ransomeware_Description.HideSelection = false;
	    this.TB_Ransomeware_Description.Location = new System.Drawing.Point(32, 88);
	    this.TB_Ransomeware_Description.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.TB_Ransomeware_Description.Multiline = true;
	    this.TB_Ransomeware_Description.Name = "TB_Ransomeware_Description";
	    this.TB_Ransomeware_Description.ReadOnly = true;
	    this.TB_Ransomeware_Description.ShortcutsEnabled = false;
	    this.TB_Ransomeware_Description.Size = new System.Drawing.Size(1055, 1339);
	    this.TB_Ransomeware_Description.TabIndex = 3;
	    this.TB_Ransomeware_Description.TabStop = false;
	    this.TB_Ransomeware_Description.Text = resources.GetString("TB_Ransomeware_Description.Text");
	    // 
	    // LeftPanel
	    // 
	    this.LeftPanel.Controls.Add(this.Label_date);
	    this.LeftPanel.Controls.Add(this.Label_Destroy_Warning);
	    this.LeftPanel.Controls.Add(this.PB_Ransom_Icon);
	    this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
	    this.LeftPanel.Location = new System.Drawing.Point(0, 0);
	    this.LeftPanel.Name = "LeftPanel";
	    this.LeftPanel.Size = new System.Drawing.Size(1328, 1545);
	    this.LeftPanel.TabIndex = 10;
	    // 
	    // Label_date
	    // 
	    this.Label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	    this.Label_date.AutoSize = true;
	    this.Label_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Label_date.ForeColor = System.Drawing.Color.White;
	    this.Label_date.Location = new System.Drawing.Point(387, 1173);
	    this.Label_date.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.Label_date.Name = "Label_date";
	    this.Label_date.Size = new System.Drawing.Size(484, 55);
	    this.Label_date.TabIndex = 5;
	    this.Label_date.Text = "4/4/2019 10:44:43 AM";
	    this.Label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // Label_Destroy_Warning
	    // 
	    this.Label_Destroy_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	    this.Label_Destroy_Warning.AutoSize = true;
	    this.Label_Destroy_Warning.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Label_Destroy_Warning.ForeColor = System.Drawing.Color.White;
	    this.Label_Destroy_Warning.Location = new System.Drawing.Point(163, 1052);
	    this.Label_Destroy_Warning.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.Label_Destroy_Warning.Name = "Label_Destroy_Warning";
	    this.Label_Destroy_Warning.Size = new System.Drawing.Size(966, 76);
	    this.Label_Destroy_Warning.TabIndex = 2;
	    this.Label_Destroy_Warning.Text = "The private key will be destroyed on:";
	    this.Label_Destroy_Warning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
	    // Form_Desktop
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackgroundImage = global::XtremeHackerman.Properties.Resources.Background_Desktop;
	    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.ClientSize = new System.Drawing.Size(2869, 1645);
	    this.Controls.Add(this.StartMenuPanel);
	    this.Controls.Add(this.IconsPanel);
	    this.Controls.Add(this.RansomwarePanel);
	    this.Controls.Add(this.ProgressPanel);
	    this.Controls.Add(this.TaskbarPanel);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_Desktop";
	    this.ShowIcon = false;
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Desktop - Xtreme Hackerman";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Desktop_FormClosing);
	    this.Load += new System.EventHandler(this.Form_Desktop_Load);
	    this.RestartBootOptions.ResumeLayout(false);
	    this.StartMenuPanel.ResumeLayout(false);
	    this.IconsPanel.ResumeLayout(false);
	    this.ProgressPanel.ResumeLayout(false);
	    this.ProgressPanel.PerformLayout();
	    this.TaskbarPanel.Panel1.ResumeLayout(false);
	    this.TaskbarPanel.Panel2.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.TaskbarPanel)).EndInit();
	    this.TaskbarPanel.ResumeLayout(false);
	    this.panel1.ResumeLayout(false);
	    this.panel1.PerformLayout();
	    this.RansomwarePanel.ResumeLayout(false);
	    this.RightPanel.ResumeLayout(false);
	    this.RightPanel.PerformLayout();
	    this.LeftPanel.ResumeLayout(false);
	    this.LeftPanel.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.PB_Ransom_Icon)).EndInit();
	    this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Antivirus;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ContextMenuStrip RestartBootOptions;
        private System.Windows.Forms.ToolStripMenuItem restartNoChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeModeToolStripMenuItem;
		private System.Windows.Forms.Button AntivirusIcon;
		private System.Windows.Forms.FlowLayoutPanel StartMenuPanel;
		private System.Windows.Forms.FlowLayoutPanel IconsPanel;
		private System.Windows.Forms.ProgressBar eventProgress;
		private System.Windows.Forms.Panel ProgressPanel;
		private System.Windows.Forms.Label CurrEventLBL;
		private System.Windows.Forms.Label eventLBL;
		private System.Windows.Forms.Button HintIcon;
		private System.Windows.Forms.SplitContainer TaskbarPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel RansomwarePanel;
		private System.Windows.Forms.Button LogOut;
	private System.Windows.Forms.Button WireSharkIcon;
	private System.Windows.Forms.Panel RightPanel;
	private System.Windows.Forms.Button Btn_Next_Ransom;
	private System.Windows.Forms.TextBox TB_Ransomeware_Description;
	private System.Windows.Forms.Label label_Warning;
	private System.Windows.Forms.Panel LeftPanel;
	private System.Windows.Forms.Label Label_date;
	private System.Windows.Forms.Label Label_Destroy_Warning;
	private System.Windows.Forms.PictureBox PB_Ransom_Icon;
    }
}