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
            this.cliButton = new System.Windows.Forms.Button();
            this.FileManagerIcon = new System.Windows.Forms.Button();
            this.emailIcon = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.InternetBrowser = new System.Windows.Forms.Button();
            this.TaskManager = new System.Windows.Forms.Button();
            this.FileManager = new System.Windows.Forms.Button();
            this.EmailClient = new System.Windows.Forms.Button();
            this.Btn_Ransom_Debug = new System.Windows.Forms.Button();
            this.DesktopPermissions = new System.Windows.Forms.Timer(this.components);
            this.RestartBootOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restartNoChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 45);
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
            this.toolbarNetworkBTN.Location = new System.Drawing.Point(955, 3);
            this.toolbarNetworkBTN.Name = "toolbarNetworkBTN";
            this.toolbarNetworkBTN.Size = new System.Drawing.Size(31, 26);
            this.toolbarNetworkBTN.TabIndex = 11;
            this.toolbarNetworkBTN.UseVisualStyleBackColor = true;
            this.toolbarNetworkBTN.Click += new System.EventHandler(this.toolbarNetworkBTN_Click);
            // 
            // toolbarTime
            // 
            this.toolbarTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarTime.AutoSize = true;
            this.toolbarTime.Location = new System.Drawing.Point(1017, 0);
            this.toolbarTime.Name = "toolbarTime";
            this.toolbarTime.Size = new System.Drawing.Size(34, 13);
            this.toolbarTime.TabIndex = 10;
            this.toolbarTime.Text = "22:00";
            // 
            // toolbarDate
            // 
            this.toolbarDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbarDate.AutoSize = true;
            this.toolbarDate.Location = new System.Drawing.Point(1004, 16);
            this.toolbarDate.Name = "toolbarDate";
            this.toolbarDate.Size = new System.Drawing.Size(59, 13);
            this.toolbarDate.TabIndex = 9;
            this.toolbarDate.Text = "3/18/2019";
            this.toolbarDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Image = global::XtremeHackerman.Properties.Resources.StartButton;
            this.startButton.Location = new System.Drawing.Point(-2, -5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 43);
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
            this.internetExplorerIcon.Location = new System.Drawing.Point(73, 34);
            this.internetExplorerIcon.Name = "internetExplorerIcon";
            this.internetExplorerIcon.Size = new System.Drawing.Size(95, 79);
            this.internetExplorerIcon.TabIndex = 7;
            this.internetExplorerIcon.UseVisualStyleBackColor = false;
            this.internetExplorerIcon.Click += new System.EventHandler(this.internetExplorerClick);
            // 
            // cliButton
            // 
            this.cliButton.BackColor = System.Drawing.Color.Transparent;
            this.cliButton.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_CommandLine;
            this.cliButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cliButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.cliButton.Location = new System.Drawing.Point(73, 144);
            this.cliButton.Name = "cliButton";
            this.cliButton.Size = new System.Drawing.Size(95, 79);
            this.cliButton.TabIndex = 8;
            this.cliButton.UseVisualStyleBackColor = false;
            this.cliButton.Click += new System.EventHandler(this.cliButtonClick);
            // 
            // FileManagerIcon
            // 
            this.FileManagerIcon.BackColor = System.Drawing.Color.Transparent;
            this.FileManagerIcon.BackgroundImage = global::XtremeHackerman.Properties.Resources.Icon_FileManager;
            this.FileManagerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FileManagerIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileManagerIcon.Location = new System.Drawing.Point(73, 256);
            this.FileManagerIcon.Name = "FileManagerIcon";
            this.FileManagerIcon.Size = new System.Drawing.Size(95, 79);
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
            this.emailIcon.Location = new System.Drawing.Point(73, 371);
            this.emailIcon.Name = "emailIcon";
            this.emailIcon.Size = new System.Drawing.Size(95, 79);
            this.emailIcon.TabIndex = 10;
            this.emailIcon.UseVisualStyleBackColor = false;
            this.emailIcon.Click += new System.EventHandler(this.emailButtonClick);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(0, 642);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(88, 23);
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
            this.Shutdown.Location = new System.Drawing.Point(0, 613);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(88, 23);
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
            this.InternetBrowser.Location = new System.Drawing.Point(0, 584);
            this.InternetBrowser.Name = "InternetBrowser";
            this.InternetBrowser.Size = new System.Drawing.Size(88, 23);
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
            this.TaskManager.Location = new System.Drawing.Point(0, 555);
            this.TaskManager.Name = "TaskManager";
            this.TaskManager.Size = new System.Drawing.Size(88, 23);
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
            this.FileManager.Location = new System.Drawing.Point(0, 526);
            this.FileManager.Name = "FileManager";
            this.FileManager.Size = new System.Drawing.Size(88, 23);
            this.FileManager.TabIndex = 14;
            this.FileManager.Text = "File Manager";
            this.FileManager.UseVisualStyleBackColor = false;
            this.FileManager.Visible = false;
            this.FileManager.Click += new System.EventHandler(this.FileManager_Click);
            // 
            // EmailClient
            // 
            this.EmailClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this.EmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailClient.Location = new System.Drawing.Point(0, 497);
            this.EmailClient.Name = "EmailClient";
            this.EmailClient.Size = new System.Drawing.Size(88, 23);
            this.EmailClient.TabIndex = 15;
            this.EmailClient.Text = "Email";
            this.EmailClient.UseVisualStyleBackColor = false;
            this.EmailClient.Visible = false;
            // 
            // Btn_Ransom_Debug
            // 
            this.Btn_Ransom_Debug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ransom_Debug.BackgroundImage")));
            this.Btn_Ransom_Debug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ransom_Debug.Location = new System.Drawing.Point(535, 13);
            this.Btn_Ransom_Debug.Name = "Btn_Ransom_Debug";
            this.Btn_Ransom_Debug.Size = new System.Drawing.Size(55, 58);
            this.Btn_Ransom_Debug.TabIndex = 16;
            this.Btn_Ransom_Debug.Text = "button1";
            this.Btn_Ransom_Debug.UseVisualStyleBackColor = true;
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
            this.RestartBootOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartNoChangesToolStripMenuItem,
            this.safeModeToolStripMenuItem});
            this.RestartBootOptions.Name = "RestartBootOptions";
            this.RestartBootOptions.Size = new System.Drawing.Size(131, 48);
            // 
            // restartNoChangesToolStripMenuItem
            // 
            this.restartNoChangesToolStripMenuItem.Name = "restartNoChangesToolStripMenuItem";
            this.restartNoChangesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.restartNoChangesToolStripMenuItem.Text = "Restart";
            this.restartNoChangesToolStripMenuItem.Click += new System.EventHandler(this.restartNoChangesToolStripMenuItem_Click);
            // 
            // safeModeToolStripMenuItem
            // 
            this.safeModeToolStripMenuItem.Name = "safeModeToolStripMenuItem";
            this.safeModeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.safeModeToolStripMenuItem.Text = "Safe Mode";
            this.safeModeToolStripMenuItem.Click += new System.EventHandler(this.safeModeToolStripMenuItem_Click);
            // 
            // Form_Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XtremeHackerman.Properties.Resources.Background_Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 690);
            this.Controls.Add(this.Btn_Ransom_Debug);
            this.Controls.Add(this.EmailClient);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.InternetBrowser);
            this.Controls.Add(this.TaskManager);
            this.Controls.Add(this.FileManager);
            this.Controls.Add(this.emailIcon);
            this.Controls.Add(this.FileManagerIcon);
            this.Controls.Add(this.cliButton);
            this.Controls.Add(this.internetExplorerIcon);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Desktop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop - Xtreme Hackerman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Desktop_Load);
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
        private System.Windows.Forms.Button cliButton;
        private System.Windows.Forms.Button FileManagerIcon;
        private System.Windows.Forms.Button emailIcon;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button InternetBrowser;
        private System.Windows.Forms.Button TaskManager;
        private System.Windows.Forms.Button FileManager;
        private System.Windows.Forms.Button EmailClient;
        private System.Windows.Forms.Label toolbarDate;
        private System.Windows.Forms.Label toolbarTime;
        private System.Windows.Forms.Button toolbarNetworkBTN;
        private System.Windows.Forms.Button Btn_Ransom_Debug;
        private System.Windows.Forms.Timer DesktopPermissions;
        private System.Windows.Forms.ContextMenuStrip RestartBootOptions;
        private System.Windows.Forms.ToolStripMenuItem restartNoChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeModeToolStripMenuItem;
    }
}