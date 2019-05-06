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
	    System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Step 1:", 0);
	    System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Step 2:", 0);
	    System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Step 3:", 0);
	    System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Step 4:", 0);
	    System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Step 5:", 0);
	    this.toolbarNetworkBTN = new System.Windows.Forms.Button();
	    this.toolbarTime = new System.Windows.Forms.Label();
	    this.toolbarDate = new System.Windows.Forms.Label();
	    this.startButton = new System.Windows.Forms.Button();
	    this.InternetIcon = new System.Windows.Forms.Button();
	    this.CommandIcon = new System.Windows.Forms.Button();
	    this.FileManagerIcon = new System.Windows.Forms.Button();
	    this.EmailIcon = new System.Windows.Forms.Button();
	    this.Restart = new System.Windows.Forms.Button();
	    this.Shutdown = new System.Windows.Forms.Button();
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
	    this.TaskManagerIcon = new System.Windows.Forms.Button();
	    this.eventProgress = new System.Windows.Forms.ProgressBar();
	    this.ProgressPanel = new System.Windows.Forms.Panel();
	    this.CompletedEventsLBL = new System.Windows.Forms.Label();
	    this.CompletedEventsList = new System.Windows.Forms.Label();
	    this.StepsView = new System.Windows.Forms.ListView();
	    this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.imageList1 = new System.Windows.Forms.ImageList(this.components);
	    this.ProgressLBL = new System.Windows.Forms.Label();
	    this.HintButton = new System.Windows.Forms.Button();
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
	    this.InstructionsPanel = new System.Windows.Forms.Panel();
	    this.NextBTN = new System.Windows.Forms.Button();
	    this.InstructionsTB = new System.Windows.Forms.TextBox();
	    this.Arrow1 = new System.Windows.Forms.PictureBox();
	    this.ArrowPanel = new System.Windows.Forms.Panel();
	    this.Arrow5 = new System.Windows.Forms.PictureBox();
	    this.Arrow4 = new System.Windows.Forms.PictureBox();
	    this.Arrow3 = new System.Windows.Forms.PictureBox();
	    this.Arrow2 = new System.Windows.Forms.PictureBox();
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
	    this.InstructionsPanel.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).BeginInit();
	    this.ArrowPanel.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow5)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow4)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow3)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // toolbarNetworkBTN
	    // 
	    this.toolbarNetworkBTN.AutoSize = true;
	    this.toolbarNetworkBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
	    this.toolbarNetworkBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.toolbarNetworkBTN.Dock = System.Windows.Forms.DockStyle.Left;
	    this.toolbarNetworkBTN.FlatAppearance.BorderSize = 0;
	    this.toolbarNetworkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.toolbarNetworkBTN.Image = ((System.Drawing.Image)(resources.GetObject("toolbarNetworkBTN.Image")));
	    this.toolbarNetworkBTN.Location = new System.Drawing.Point(0, 0);
	    this.toolbarNetworkBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.toolbarNetworkBTN.Name = "toolbarNetworkBTN";
	    this.toolbarNetworkBTN.Size = new System.Drawing.Size(70, 129);
	    this.toolbarNetworkBTN.TabIndex = 11;
	    this.toolbarNetworkBTN.UseVisualStyleBackColor = true;
	    this.toolbarNetworkBTN.Click += new System.EventHandler(this.toolbarNetworkBTN_Click);
	    // 
	    // toolbarTime
	    // 
	    this.toolbarTime.AutoSize = true;
	    this.toolbarTime.Dock = System.Windows.Forms.DockStyle.Top;
	    this.toolbarTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.toolbarTime.Location = new System.Drawing.Point(70, 0);
	    this.toolbarTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.toolbarTime.Name = "toolbarTime";
	    this.toolbarTime.Size = new System.Drawing.Size(190, 46);
	    this.toolbarTime.TabIndex = 10;
	    this.toolbarTime.Text = "00:00 PM";
	    // 
	    // toolbarDate
	    // 
	    this.toolbarDate.AutoSize = true;
	    this.toolbarDate.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.toolbarDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.toolbarDate.Location = new System.Drawing.Point(70, 83);
	    this.toolbarDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.toolbarDate.Name = "toolbarDate";
	    this.toolbarDate.Size = new System.Drawing.Size(196, 46);
	    this.toolbarDate.TabIndex = 9;
	    this.toolbarDate.Text = "0/00/0000";
	    // 
	    // startButton
	    // 
	    this.startButton.AutoSize = true;
	    this.startButton.BackColor = System.Drawing.Color.Transparent;
	    this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.startButton.Dock = System.Windows.Forms.DockStyle.Left;
	    this.startButton.FlatAppearance.BorderSize = 0;
	    this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
	    this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
	    this.startButton.Location = new System.Drawing.Point(0, 0);
	    this.startButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.startButton.Name = "startButton";
	    this.startButton.Size = new System.Drawing.Size(123, 129);
	    this.startButton.TabIndex = 8;
	    this.startButton.UseVisualStyleBackColor = false;
	    this.startButton.Click += new System.EventHandler(this.startButtonClick);
	    // 
	    // InternetIcon
	    // 
	    this.InternetIcon.AutoSize = true;
	    this.InternetIcon.BackColor = System.Drawing.Color.Transparent;
	    this.InternetIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.InternetIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.InternetIcon.FlatAppearance.BorderSize = 0;
	    this.InternetIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.InternetIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.InternetIcon.ForeColor = System.Drawing.Color.White;
	    this.InternetIcon.Image = ((System.Drawing.Image)(resources.GetObject("InternetIcon.Image")));
	    this.InternetIcon.Location = new System.Drawing.Point(78, 77);
	    this.InternetIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.InternetIcon.Name = "InternetIcon";
	    this.InternetIcon.Size = new System.Drawing.Size(171, 152);
	    this.InternetIcon.TabIndex = 7;
	    this.InternetIcon.Text = "Internet";
	    this.InternetIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.InternetIcon.UseVisualStyleBackColor = false;
	    this.InternetIcon.Click += new System.EventHandler(this.InternetIcon_Click);
	    // 
	    // CommandIcon
	    // 
	    this.CommandIcon.AutoSize = true;
	    this.CommandIcon.BackColor = System.Drawing.Color.Transparent;
	    this.CommandIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.CommandIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.CommandIcon.FlatAppearance.BorderSize = 0;
	    this.CommandIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.CommandIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.CommandIcon.ForeColor = System.Drawing.Color.White;
	    this.CommandIcon.Image = ((System.Drawing.Image)(resources.GetObject("CommandIcon.Image")));
	    this.CommandIcon.Location = new System.Drawing.Point(929, 77);
	    this.CommandIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.CommandIcon.Name = "CommandIcon";
	    this.CommandIcon.Size = new System.Drawing.Size(368, 152);
	    this.CommandIcon.TabIndex = 8;
	    this.CommandIcon.Text = "Command Prompt";
	    this.CommandIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.CommandIcon.UseVisualStyleBackColor = false;
	    this.CommandIcon.Click += new System.EventHandler(this.CommandIcon_Click);
	    // 
	    // FileManagerIcon
	    // 
	    this.FileManagerIcon.AutoSize = true;
	    this.FileManagerIcon.BackColor = System.Drawing.Color.Transparent;
	    this.FileManagerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.FileManagerIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.FileManagerIcon.FlatAppearance.BorderSize = 0;
	    this.FileManagerIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.FileManagerIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.FileManagerIcon.ForeColor = System.Drawing.Color.White;
	    this.FileManagerIcon.Image = ((System.Drawing.Image)(resources.GetObject("FileManagerIcon.Image")));
	    this.FileManagerIcon.Location = new System.Drawing.Point(430, 77);
	    this.FileManagerIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.FileManagerIcon.Name = "FileManagerIcon";
	    this.FileManagerIcon.Size = new System.Drawing.Size(268, 152);
	    this.FileManagerIcon.TabIndex = 9;
	    this.FileManagerIcon.Text = "File Explorer";
	    this.FileManagerIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.FileManagerIcon.UseVisualStyleBackColor = false;
	    this.FileManagerIcon.Click += new System.EventHandler(this.FileManagerIcon_Click);
	    // 
	    // EmailIcon
	    // 
	    this.EmailIcon.AutoSize = true;
	    this.EmailIcon.BackColor = System.Drawing.Color.Transparent;
	    this.EmailIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.EmailIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.EmailIcon.FlatAppearance.BorderSize = 0;
	    this.EmailIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.EmailIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.EmailIcon.ForeColor = System.Drawing.Color.White;
	    this.EmailIcon.Image = ((System.Drawing.Image)(resources.GetObject("EmailIcon.Image")));
	    this.EmailIcon.Location = new System.Drawing.Point(265, 77);
	    this.EmailIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.EmailIcon.Name = "EmailIcon";
	    this.EmailIcon.Size = new System.Drawing.Size(149, 152);
	    this.EmailIcon.TabIndex = 10;
	    this.EmailIcon.Text = "E-Mail";
	    this.EmailIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.EmailIcon.UseVisualStyleBackColor = false;
	    this.EmailIcon.Click += new System.EventHandler(this.EmailIcon_Click);
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
	    this.AntivirusIcon.AutoSize = true;
	    this.AntivirusIcon.BackColor = System.Drawing.Color.Transparent;
	    this.AntivirusIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.AntivirusIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.AntivirusIcon.FlatAppearance.BorderSize = 0;
	    this.AntivirusIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.AntivirusIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.AntivirusIcon.ForeColor = System.Drawing.Color.White;
	    this.AntivirusIcon.Image = ((System.Drawing.Image)(resources.GetObject("AntivirusIcon.Image")));
	    this.AntivirusIcon.Location = new System.Drawing.Point(714, 77);
	    this.AntivirusIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.AntivirusIcon.Name = "AntivirusIcon";
	    this.AntivirusIcon.Size = new System.Drawing.Size(199, 152);
	    this.AntivirusIcon.TabIndex = 17;
	    this.AntivirusIcon.Text = "AntiVirus";
	    this.AntivirusIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.AntivirusIcon.UseVisualStyleBackColor = false;
	    this.AntivirusIcon.Click += new System.EventHandler(this.Antivirus_Click);
	    // 
	    // StartMenuPanel
	    // 
	    this.StartMenuPanel.BackColor = System.Drawing.Color.Transparent;
	    this.StartMenuPanel.Controls.Add(this.Shutdown);
	    this.StartMenuPanel.Controls.Add(this.Restart);
	    this.StartMenuPanel.Controls.Add(this.LogOut);
	    this.StartMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.StartMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
	    this.StartMenuPanel.Location = new System.Drawing.Point(0, 1255);
	    this.StartMenuPanel.Name = "StartMenuPanel";
	    this.StartMenuPanel.Size = new System.Drawing.Size(2330, 261);
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
	    this.IconsPanel.Controls.Add(this.InternetIcon);
	    this.IconsPanel.Controls.Add(this.EmailIcon);
	    this.IconsPanel.Controls.Add(this.FileManagerIcon);
	    this.IconsPanel.Controls.Add(this.AntivirusIcon);
	    this.IconsPanel.Controls.Add(this.CommandIcon);
	    this.IconsPanel.Controls.Add(this.WireSharkIcon);
	    this.IconsPanel.Controls.Add(this.TaskManagerIcon);
	    this.IconsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.IconsPanel.Location = new System.Drawing.Point(0, 0);
	    this.IconsPanel.Margin = new System.Windows.Forms.Padding(5);
	    this.IconsPanel.Name = "IconsPanel";
	    this.IconsPanel.Padding = new System.Windows.Forms.Padding(70, 70, 0, 0);
	    this.IconsPanel.Size = new System.Drawing.Size(2330, 1516);
	    this.IconsPanel.TabIndex = 16;
	    // 
	    // WireSharkIcon
	    // 
	    this.WireSharkIcon.AutoSize = true;
	    this.WireSharkIcon.BackColor = System.Drawing.Color.Transparent;
	    this.WireSharkIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.WireSharkIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.WireSharkIcon.FlatAppearance.BorderSize = 0;
	    this.WireSharkIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.WireSharkIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.WireSharkIcon.ForeColor = System.Drawing.Color.White;
	    this.WireSharkIcon.Image = ((System.Drawing.Image)(resources.GetObject("WireSharkIcon.Image")));
	    this.WireSharkIcon.Location = new System.Drawing.Point(1313, 77);
	    this.WireSharkIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.WireSharkIcon.Name = "WireSharkIcon";
	    this.WireSharkIcon.Size = new System.Drawing.Size(359, 152);
	    this.WireSharkIcon.TabIndex = 18;
	    this.WireSharkIcon.Text = "Network Analyzer";
	    this.WireSharkIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.WireSharkIcon.UseVisualStyleBackColor = false;
	    this.WireSharkIcon.Click += new System.EventHandler(this.WiresharkIcon_Click);
	    // 
	    // TaskManagerIcon
	    // 
	    this.TaskManagerIcon.AutoSize = true;
	    this.TaskManagerIcon.BackColor = System.Drawing.Color.Transparent;
	    this.TaskManagerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.TaskManagerIcon.Cursor = System.Windows.Forms.Cursors.Default;
	    this.TaskManagerIcon.FlatAppearance.BorderSize = 0;
	    this.TaskManagerIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.TaskManagerIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.TaskManagerIcon.ForeColor = System.Drawing.Color.White;
	    this.TaskManagerIcon.Image = ((System.Drawing.Image)(resources.GetObject("TaskManagerIcon.Image")));
	    this.TaskManagerIcon.Location = new System.Drawing.Point(1688, 77);
	    this.TaskManagerIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.TaskManagerIcon.Name = "TaskManagerIcon";
	    this.TaskManagerIcon.Size = new System.Drawing.Size(359, 152);
	    this.TaskManagerIcon.TabIndex = 19;
	    this.TaskManagerIcon.Text = "Task Manager";
	    this.TaskManagerIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.TaskManagerIcon.UseVisualStyleBackColor = false;
	    this.TaskManagerIcon.Click += new System.EventHandler(this.TaskManagerIcon_Click);
	    // 
	    // eventProgress
	    // 
	    this.eventProgress.BackColor = System.Drawing.Color.Gray;
	    this.eventProgress.Dock = System.Windows.Forms.DockStyle.Top;
	    this.eventProgress.Location = new System.Drawing.Point(0, 0);
	    this.eventProgress.Name = "eventProgress";
	    this.eventProgress.Size = new System.Drawing.Size(539, 60);
	    this.eventProgress.TabIndex = 16;
	    // 
	    // ProgressPanel
	    // 
	    this.ProgressPanel.BackColor = System.Drawing.Color.Transparent;
	    this.ProgressPanel.Controls.Add(this.CompletedEventsLBL);
	    this.ProgressPanel.Controls.Add(this.CompletedEventsList);
	    this.ProgressPanel.Controls.Add(this.StepsView);
	    this.ProgressPanel.Controls.Add(this.ProgressLBL);
	    this.ProgressPanel.Controls.Add(this.HintButton);
	    this.ProgressPanel.Controls.Add(this.eventLBL);
	    this.ProgressPanel.Controls.Add(this.CurrEventLBL);
	    this.ProgressPanel.Controls.Add(this.eventProgress);
	    this.ProgressPanel.Dock = System.Windows.Forms.DockStyle.Right;
	    this.ProgressPanel.Location = new System.Drawing.Point(2330, 0);
	    this.ProgressPanel.Name = "ProgressPanel";
	    this.ProgressPanel.Size = new System.Drawing.Size(539, 1516);
	    this.ProgressPanel.TabIndex = 19;
	    // 
	    // CompletedEventsLBL
	    // 
	    this.CompletedEventsLBL.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.CompletedEventsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.CompletedEventsLBL.ForeColor = System.Drawing.Color.White;
	    this.CompletedEventsLBL.Image = ((System.Drawing.Image)(resources.GetObject("CompletedEventsLBL.Image")));
	    this.CompletedEventsLBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
	    this.CompletedEventsLBL.Location = new System.Drawing.Point(0, 1136);
	    this.CompletedEventsLBL.Name = "CompletedEventsLBL";
	    this.CompletedEventsLBL.Size = new System.Drawing.Size(539, 216);
	    this.CompletedEventsLBL.TabIndex = 25;
	    this.CompletedEventsLBL.Text = "Completed Events:";
	    this.CompletedEventsLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
	    // 
	    // CompletedEventsList
	    // 
	    this.CompletedEventsList.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.CompletedEventsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.CompletedEventsList.ForeColor = System.Drawing.Color.Teal;
	    this.CompletedEventsList.Location = new System.Drawing.Point(0, 1352);
	    this.CompletedEventsList.Name = "CompletedEventsList";
	    this.CompletedEventsList.Size = new System.Drawing.Size(539, 164);
	    this.CompletedEventsList.TabIndex = 26;
	    this.CompletedEventsList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    // 
	    // StepsView
	    // 
	    this.StepsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
	    this.StepsView.Dock = System.Windows.Forms.DockStyle.Top;
	    this.StepsView.Enabled = false;
	    this.StepsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.StepsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
	    listViewItem1.StateImageIndex = 0;
	    listViewItem2.StateImageIndex = 0;
	    listViewItem3.StateImageIndex = 0;
	    listViewItem4.StateImageIndex = 0;
	    listViewItem5.StateImageIndex = 0;
	    this.StepsView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
	    this.StepsView.LargeImageList = this.imageList1;
	    this.StepsView.Location = new System.Drawing.Point(0, 462);
	    this.StepsView.Name = "StepsView";
	    this.StepsView.Scrollable = false;
	    this.StepsView.Size = new System.Drawing.Size(539, 421);
	    this.StepsView.SmallImageList = this.imageList1;
	    this.StepsView.TabIndex = 23;
	    this.StepsView.UseCompatibleStateImageBehavior = false;
	    this.StepsView.View = System.Windows.Forms.View.Details;
	    // 
	    // columnHeader1
	    // 
	    this.columnHeader1.Width = 535;
	    // 
	    // imageList1
	    // 
	    this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
	    this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
	    this.imageList1.Images.SetKeyName(0, "Checkbox.png");
	    this.imageList1.Images.SetKeyName(1, "Checkbox_Checked.png");
	    this.imageList1.Images.SetKeyName(2, "Checkbox_Checked2.png");
	    // 
	    // ProgressLBL
	    // 
	    this.ProgressLBL.Dock = System.Windows.Forms.DockStyle.Top;
	    this.ProgressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.ProgressLBL.ForeColor = System.Drawing.Color.White;
	    this.ProgressLBL.Location = new System.Drawing.Point(0, 322);
	    this.ProgressLBL.Name = "ProgressLBL";
	    this.ProgressLBL.Size = new System.Drawing.Size(539, 140);
	    this.ProgressLBL.TabIndex = 22;
	    this.ProgressLBL.Text = "Progress:";
	    this.ProgressLBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
	    // 
	    // HintButton
	    // 
	    this.HintButton.AutoSize = true;
	    this.HintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.HintButton.Dock = System.Windows.Forms.DockStyle.Top;
	    this.HintButton.FlatAppearance.BorderSize = 0;
	    this.HintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.HintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.HintButton.ForeColor = System.Drawing.Color.White;
	    this.HintButton.Image = ((System.Drawing.Image)(resources.GetObject("HintButton.Image")));
	    this.HintButton.Location = new System.Drawing.Point(0, 182);
	    this.HintButton.Name = "HintButton";
	    this.HintButton.Size = new System.Drawing.Size(539, 140);
	    this.HintButton.TabIndex = 21;
	    this.HintButton.Text = "Hint";
	    this.HintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
	    this.HintButton.UseVisualStyleBackColor = true;
	    this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
	    // 
	    // eventLBL
	    // 
	    this.eventLBL.Dock = System.Windows.Forms.DockStyle.Top;
	    this.eventLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.eventLBL.ForeColor = System.Drawing.Color.Teal;
	    this.eventLBL.Location = new System.Drawing.Point(0, 121);
	    this.eventLBL.Name = "eventLBL";
	    this.eventLBL.Size = new System.Drawing.Size(539, 61);
	    this.eventLBL.TabIndex = 24;
	    this.eventLBL.Text = "event";
	    this.eventLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    this.eventLBL.DoubleClick += new System.EventHandler(this.eventLBL_DoubleClick);
	    // 
	    // CurrEventLBL
	    // 
	    this.CurrEventLBL.Dock = System.Windows.Forms.DockStyle.Top;
	    this.CurrEventLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.CurrEventLBL.ForeColor = System.Drawing.Color.White;
	    this.CurrEventLBL.Location = new System.Drawing.Point(0, 60);
	    this.CurrEventLBL.Name = "CurrEventLBL";
	    this.CurrEventLBL.Size = new System.Drawing.Size(539, 61);
	    this.CurrEventLBL.TabIndex = 17;
	    this.CurrEventLBL.Text = "Current Event:";
	    this.CurrEventLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
	    // 
	    // TaskbarPanel
	    // 
	    this.TaskbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
	    this.TaskbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.TaskbarPanel.Location = new System.Drawing.Point(0, 1516);
	    this.TaskbarPanel.Name = "TaskbarPanel";
	    // 
	    // TaskbarPanel.Panel1
	    // 
	    this.TaskbarPanel.Panel1.BackColor = System.Drawing.Color.Transparent;
	    this.TaskbarPanel.Panel1.Controls.Add(this.startButton);
	    // 
	    // TaskbarPanel.Panel2
	    // 
	    this.TaskbarPanel.Panel2.BackColor = System.Drawing.Color.Transparent;
	    this.TaskbarPanel.Panel2.Controls.Add(this.panel1);
	    this.TaskbarPanel.Size = new System.Drawing.Size(2869, 129);
	    this.TaskbarPanel.SplitterDistance = 2528;
	    this.TaskbarPanel.TabIndex = 12;
	    // 
	    // panel1
	    // 
	    this.panel1.BackColor = System.Drawing.Color.Transparent;
	    this.panel1.Controls.Add(this.toolbarTime);
	    this.panel1.Controls.Add(this.toolbarDate);
	    this.panel1.Controls.Add(this.toolbarNetworkBTN);
	    this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.panel1.Location = new System.Drawing.Point(0, 0);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(337, 129);
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
	    this.RansomwarePanel.Size = new System.Drawing.Size(2330, 1516);
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
	    this.RightPanel.Size = new System.Drawing.Size(1002, 1516);
	    this.RightPanel.TabIndex = 9;
	    // 
	    // Btn_Next_Ransom
	    // 
	    this.Btn_Next_Ransom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
	    this.Btn_Next_Ransom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Btn_Next_Ransom.Location = new System.Drawing.Point(635, 1355);
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
	    this.label_Warning.Size = new System.Drawing.Size(1002, 150);
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
	    this.TB_Ransomeware_Description.Location = new System.Drawing.Point(32, 74);
	    this.TB_Ransomeware_Description.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.TB_Ransomeware_Description.Multiline = true;
	    this.TB_Ransomeware_Description.Name = "TB_Ransomeware_Description";
	    this.TB_Ransomeware_Description.ReadOnly = true;
	    this.TB_Ransomeware_Description.ShortcutsEnabled = false;
	    this.TB_Ransomeware_Description.Size = new System.Drawing.Size(931, 1339);
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
	    this.LeftPanel.Size = new System.Drawing.Size(1328, 1516);
	    this.LeftPanel.TabIndex = 10;
	    // 
	    // Label_date
	    // 
	    this.Label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	    this.Label_date.AutoSize = true;
	    this.Label_date.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.Label_date.ForeColor = System.Drawing.Color.White;
	    this.Label_date.Location = new System.Drawing.Point(387, 1144);
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
	    this.Label_Destroy_Warning.Location = new System.Drawing.Point(163, 1023);
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
	    // InstructionsPanel
	    // 
	    this.InstructionsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
	    this.InstructionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
	    this.InstructionsPanel.Controls.Add(this.NextBTN);
	    this.InstructionsPanel.Controls.Add(this.InstructionsTB);
	    this.InstructionsPanel.Location = new System.Drawing.Point(1000, 600);
	    this.InstructionsPanel.Name = "InstructionsPanel";
	    this.InstructionsPanel.Size = new System.Drawing.Size(702, 386);
	    this.InstructionsPanel.TabIndex = 22;
	    this.InstructionsPanel.Visible = false;
	    // 
	    // NextBTN
	    // 
	    this.NextBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
	    this.NextBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextBTN.BackgroundImage")));
	    this.NextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.NextBTN.ForeColor = System.Drawing.Color.Gainsboro;
	    this.NextBTN.Location = new System.Drawing.Point(579, 263);
	    this.NextBTN.Name = "NextBTN";
	    this.NextBTN.Size = new System.Drawing.Size(120, 120);
	    this.NextBTN.TabIndex = 1;
	    this.NextBTN.UseVisualStyleBackColor = true;
	    this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
	    // 
	    // InstructionsTB
	    // 
	    this.InstructionsTB.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.InstructionsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.InstructionsTB.Location = new System.Drawing.Point(0, 0);
	    this.InstructionsTB.Multiline = true;
	    this.InstructionsTB.Name = "InstructionsTB";
	    this.InstructionsTB.Size = new System.Drawing.Size(702, 386);
	    this.InstructionsTB.TabIndex = 3;
	    this.InstructionsTB.Text = "Welcome Admin!\r\nYour goal is to secure the desktop by recovering from various cyb" +
    "er security attacks.\r\n";
	    this.InstructionsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
	    // 
	    // Arrow1
	    // 
	    this.Arrow1.BackColor = System.Drawing.Color.Transparent;
	    this.Arrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.Arrow1.Dock = System.Windows.Forms.DockStyle.Top;
	    this.Arrow1.Image = ((System.Drawing.Image)(resources.GetObject("Arrow1.Image")));
	    this.Arrow1.Location = new System.Drawing.Point(0, 0);
	    this.Arrow1.Name = "Arrow1";
	    this.Arrow1.Size = new System.Drawing.Size(223, 30);
	    this.Arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.Arrow1.TabIndex = 2;
	    this.Arrow1.TabStop = false;
	    this.Arrow1.Visible = false;
	    // 
	    // ArrowPanel
	    // 
	    this.ArrowPanel.BackColor = System.Drawing.Color.Transparent;
	    this.ArrowPanel.Controls.Add(this.Arrow5);
	    this.ArrowPanel.Controls.Add(this.Arrow4);
	    this.ArrowPanel.Controls.Add(this.Arrow3);
	    this.ArrowPanel.Controls.Add(this.Arrow2);
	    this.ArrowPanel.Controls.Add(this.Arrow1);
	    this.ArrowPanel.Dock = System.Windows.Forms.DockStyle.Right;
	    this.ArrowPanel.Location = new System.Drawing.Point(2107, 0);
	    this.ArrowPanel.Name = "ArrowPanel";
	    this.ArrowPanel.Size = new System.Drawing.Size(223, 1255);
	    this.ArrowPanel.TabIndex = 23;
	    // 
	    // Arrow5
	    // 
	    this.Arrow5.BackColor = System.Drawing.Color.Transparent;
	    this.Arrow5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.Arrow5.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.Arrow5.Image = ((System.Drawing.Image)(resources.GetObject("Arrow5.Image")));
	    this.Arrow5.Location = new System.Drawing.Point(0, 1055);
	    this.Arrow5.Name = "Arrow5";
	    this.Arrow5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 170);
	    this.Arrow5.Size = new System.Drawing.Size(223, 200);
	    this.Arrow5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.Arrow5.TabIndex = 6;
	    this.Arrow5.TabStop = false;
	    this.Arrow5.Visible = false;
	    // 
	    // Arrow4
	    // 
	    this.Arrow4.BackColor = System.Drawing.Color.Transparent;
	    this.Arrow4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.Arrow4.Dock = System.Windows.Forms.DockStyle.Top;
	    this.Arrow4.Image = ((System.Drawing.Image)(resources.GetObject("Arrow4.Image")));
	    this.Arrow4.Location = new System.Drawing.Point(0, 440);
	    this.Arrow4.Name = "Arrow4";
	    this.Arrow4.Padding = new System.Windows.Forms.Padding(0, 500, 0, 0);
	    this.Arrow4.Size = new System.Drawing.Size(223, 530);
	    this.Arrow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.Arrow4.TabIndex = 5;
	    this.Arrow4.TabStop = false;
	    this.Arrow4.Visible = false;
	    // 
	    // Arrow3
	    // 
	    this.Arrow3.BackColor = System.Drawing.Color.Transparent;
	    this.Arrow3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.Arrow3.Dock = System.Windows.Forms.DockStyle.Top;
	    this.Arrow3.Image = ((System.Drawing.Image)(resources.GetObject("Arrow3.Image")));
	    this.Arrow3.Location = new System.Drawing.Point(0, 160);
	    this.Arrow3.Name = "Arrow3";
	    this.Arrow3.Padding = new System.Windows.Forms.Padding(0, 250, 0, 0);
	    this.Arrow3.Size = new System.Drawing.Size(223, 280);
	    this.Arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.Arrow3.TabIndex = 4;
	    this.Arrow3.TabStop = false;
	    this.Arrow3.Visible = false;
	    // 
	    // Arrow2
	    // 
	    this.Arrow2.BackColor = System.Drawing.Color.Transparent;
	    this.Arrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.Arrow2.Dock = System.Windows.Forms.DockStyle.Top;
	    this.Arrow2.Image = ((System.Drawing.Image)(resources.GetObject("Arrow2.Image")));
	    this.Arrow2.Location = new System.Drawing.Point(0, 30);
	    this.Arrow2.Name = "Arrow2";
	    this.Arrow2.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
	    this.Arrow2.Size = new System.Drawing.Size(223, 130);
	    this.Arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.Arrow2.TabIndex = 3;
	    this.Arrow2.TabStop = false;
	    this.Arrow2.Visible = false;
	    // 
	    // Form_Desktop
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackgroundImage = global::XtremeHackerman.Properties.Resources.Background_Desktop;
	    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.ClientSize = new System.Drawing.Size(2869, 1645);
	    this.Controls.Add(this.ArrowPanel);
	    this.Controls.Add(this.InstructionsPanel);
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
	    this.IconsPanel.PerformLayout();
	    this.ProgressPanel.ResumeLayout(false);
	    this.ProgressPanel.PerformLayout();
	    this.TaskbarPanel.Panel1.ResumeLayout(false);
	    this.TaskbarPanel.Panel1.PerformLayout();
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
	    this.InstructionsPanel.ResumeLayout(false);
	    this.InstructionsPanel.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).EndInit();
	    this.ArrowPanel.ResumeLayout(false);
	    this.ArrowPanel.PerformLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow5)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow4)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow3)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).EndInit();
	    this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button InternetIcon;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button CommandIcon;
        private System.Windows.Forms.Button FileManagerIcon;
        private System.Windows.Forms.Button EmailIcon;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Label toolbarDate;
        private System.Windows.Forms.Label toolbarTime;
        private System.Windows.Forms.Button toolbarNetworkBTN;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Antivirus;
        private System.Windows.Forms.ContextMenuStrip RestartBootOptions;
        private System.Windows.Forms.ToolStripMenuItem restartNoChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeModeToolStripMenuItem;
		private System.Windows.Forms.Button AntivirusIcon;
		private System.Windows.Forms.FlowLayoutPanel StartMenuPanel;
		private System.Windows.Forms.FlowLayoutPanel IconsPanel;
		private System.Windows.Forms.ProgressBar eventProgress;
		private System.Windows.Forms.Panel ProgressPanel;
		private System.Windows.Forms.Label CurrEventLBL;
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
	private System.Windows.Forms.Button HintButton;
	private System.Windows.Forms.Button TaskManagerIcon;
	public System.Windows.Forms.Timer RefreshTimer;
	private System.Windows.Forms.Label ProgressLBL;
	private System.Windows.Forms.ListView StepsView;
	private System.Windows.Forms.ImageList imageList1;
	private System.Windows.Forms.Label eventLBL;
	private System.Windows.Forms.ColumnHeader columnHeader1;
	private System.Windows.Forms.Label CompletedEventsLBL;
	private System.Windows.Forms.Label CompletedEventsList;
	private System.Windows.Forms.Panel InstructionsPanel;
	private System.Windows.Forms.PictureBox Arrow1;
	private System.Windows.Forms.Button NextBTN;
	private System.Windows.Forms.TextBox InstructionsTB;
	private System.Windows.Forms.Panel ArrowPanel;
	private System.Windows.Forms.PictureBox Arrow5;
	private System.Windows.Forms.PictureBox Arrow4;
	private System.Windows.Forms.PictureBox Arrow2;
	private System.Windows.Forms.PictureBox Arrow3;
    }
}