namespace XtremeHackerman
{
    partial class Form_TitleScreen
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TitleScreen));
	    this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
	    this.button_Admin = new System.Windows.Forms.Button();
	    this.button_Hacker = new System.Windows.Forms.Button();
	    this.button_About = new System.Windows.Forms.Button();
	    this.button_Quit = new System.Windows.Forms.Button();
	    this.safeModeIconButton = new System.Windows.Forms.PictureBox();
	    this.pictureBox_Title = new System.Windows.Forms.PictureBox();
	    this.safeModeContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.safeModeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.bootInSafeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.bootInNormalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.enableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	    this.disableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	    this.enableSafeModeWithCommandPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.enableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
	    this.disableToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
	    this.securityOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.copyrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.SafeModeStatus = new System.Windows.Forms.Label();
	    this.NetworkingStatus = new System.Windows.Forms.Label();
	    this.CMDAccessStatus = new System.Windows.Forms.Label();
	    this.BootStatusTimer = new System.Windows.Forms.Timer(this.components);
	    this.panel1 = new System.Windows.Forms.Panel();
	    this.tableLayoutPanel_Buttons.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.safeModeIconButton)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).BeginInit();
	    this.safeModeContextStrip.SuspendLayout();
	    this.panel1.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // tableLayoutPanel_Buttons
	    // 
	    this.tableLayoutPanel_Buttons.BackColor = System.Drawing.Color.Transparent;
	    this.tableLayoutPanel_Buttons.ColumnCount = 6;
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
	    this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_Admin, 1, 0);
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_Hacker, 3, 0);
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_About, 2, 1);
	    this.tableLayoutPanel_Buttons.Controls.Add(this.button_Quit, 2, 2);
	    this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.tableLayoutPanel_Buttons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
	    this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(0, 395);
	    this.tableLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
	    this.tableLayoutPanel_Buttons.RowCount = 3;
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
	    this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
	    this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(1925, 350);
	    this.tableLayoutPanel_Buttons.TabIndex = 1;
	    // 
	    // button_Admin
	    // 
	    this.button_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_Admin, 2);
	    this.button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_Admin.ForeColor = System.Drawing.Color.White;
	    this.button_Admin.Location = new System.Drawing.Point(393, 7);
	    this.button_Admin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_Admin.Name = "button_Admin";
	    this.button_Admin.Size = new System.Drawing.Size(561, 188);
	    this.button_Admin.TabIndex = 0;
	    this.button_Admin.Text = "ADMIN";
	    this.button_Admin.UseVisualStyleBackColor = true;
	    this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
	    // 
	    // button_Hacker
	    // 
	    this.button_Hacker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_Hacker, 2);
	    this.button_Hacker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_Hacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_Hacker.ForeColor = System.Drawing.Color.White;
	    this.button_Hacker.Location = new System.Drawing.Point(970, 7);
	    this.button_Hacker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_Hacker.Name = "button_Hacker";
	    this.button_Hacker.Size = new System.Drawing.Size(561, 188);
	    this.button_Hacker.TabIndex = 1;
	    this.button_Hacker.Text = "HACKER";
	    this.button_Hacker.UseVisualStyleBackColor = true;
	    this.button_Hacker.Click += new System.EventHandler(this.button_Hacker_Click);
	    // 
	    // button_About
	    // 
	    this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_About, 2);
	    this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_About.ForeColor = System.Drawing.Color.White;
	    this.button_About.Location = new System.Drawing.Point(874, 209);
	    this.button_About.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_About.Name = "button_About";
	    this.button_About.Size = new System.Drawing.Size(176, 60);
	    this.button_About.TabIndex = 2;
	    this.button_About.Text = "ABOUT";
	    this.button_About.UseVisualStyleBackColor = true;
	    this.button_About.Click += new System.EventHandler(this.button_About_Click);
	    // 
	    // button_Quit
	    // 
	    this.button_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	    this.tableLayoutPanel_Buttons.SetColumnSpan(this.button_Quit, 2);
	    this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
	    this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.button_Quit.ForeColor = System.Drawing.Color.White;
	    this.button_Quit.Location = new System.Drawing.Point(874, 283);
	    this.button_Quit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.button_Quit.Name = "button_Quit";
	    this.button_Quit.Size = new System.Drawing.Size(176, 62);
	    this.button_Quit.TabIndex = 3;
	    this.button_Quit.Text = "QUIT";
	    this.button_Quit.UseVisualStyleBackColor = true;
	    this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
	    // 
	    // safeModeIconButton
	    // 
	    this.safeModeIconButton.BackColor = System.Drawing.Color.Transparent;
	    this.safeModeIconButton.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.safeModeIconButton.Image = ((System.Drawing.Image)(resources.GetObject("safeModeIconButton.Image")));
	    this.safeModeIconButton.Location = new System.Drawing.Point(0, 63);
	    this.safeModeIconButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.safeModeIconButton.Name = "safeModeIconButton";
	    this.safeModeIconButton.Size = new System.Drawing.Size(1925, 64);
	    this.safeModeIconButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
	    this.safeModeIconButton.TabIndex = 3;
	    this.safeModeIconButton.TabStop = false;
	    this.safeModeIconButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.safeModeIconButton_MouseClick);
	    // 
	    // pictureBox_Title
	    // 
	    this.pictureBox_Title.BackColor = System.Drawing.Color.Transparent;
	    this.pictureBox_Title.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.pictureBox_Title.Image = global::XtremeHackerman.Properties.Resources.Picture_Title;
	    this.pictureBox_Title.Location = new System.Drawing.Point(0, 0);
	    this.pictureBox_Title.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.pictureBox_Title.Name = "pictureBox_Title";
	    this.pictureBox_Title.Padding = new System.Windows.Forms.Padding(0, 0, 0, 300);
	    this.pictureBox_Title.Size = new System.Drawing.Size(1925, 395);
	    this.pictureBox_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
	    this.pictureBox_Title.TabIndex = 2;
	    this.pictureBox_Title.TabStop = false;
	    // 
	    // safeModeContextStrip
	    // 
	    this.safeModeContextStrip.BackColor = System.Drawing.Color.Violet;
	    this.safeModeContextStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.safeModeContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.safeModeOptionsToolStripMenuItem,
            this.securityOptionsToolStripMenuItem,
            this.copyrightToolStripMenuItem});
	    this.safeModeContextStrip.Name = "contextMenuStrip1";
	    this.safeModeContextStrip.Size = new System.Drawing.Size(316, 142);
	    // 
	    // safeModeOptionsToolStripMenuItem
	    // 
	    this.safeModeOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bootInSafeModeToolStripMenuItem,
            this.bootInNormalModeToolStripMenuItem,
            this.enableSafeModeWithCommandPromptToolStripMenuItem});
	    this.safeModeOptionsToolStripMenuItem.Name = "safeModeOptionsToolStripMenuItem";
	    this.safeModeOptionsToolStripMenuItem.Size = new System.Drawing.Size(315, 46);
	    this.safeModeOptionsToolStripMenuItem.Text = "Boot Options";
	    this.safeModeOptionsToolStripMenuItem.Click += new System.EventHandler(this.safeModeOptionsToolStripMenuItem_Click);
	    // 
	    // bootInSafeModeToolStripMenuItem
	    // 
	    this.bootInSafeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
	    this.bootInSafeModeToolStripMenuItem.Name = "bootInSafeModeToolStripMenuItem";
	    this.bootInSafeModeToolStripMenuItem.Size = new System.Drawing.Size(401, 46);
	    this.bootInSafeModeToolStripMenuItem.Text = "Enable Safe Mode";
	    // 
	    // enableToolStripMenuItem
	    // 
	    this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
	    this.enableToolStripMenuItem.Size = new System.Drawing.Size(229, 46);
	    this.enableToolStripMenuItem.Text = "Enable";
	    this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
	    // 
	    // disableToolStripMenuItem
	    // 
	    this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
	    this.disableToolStripMenuItem.Size = new System.Drawing.Size(229, 46);
	    this.disableToolStripMenuItem.Text = "Disable";
	    this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
	    // 
	    // bootInNormalModeToolStripMenuItem
	    // 
	    this.bootInNormalModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem1,
            this.disableToolStripMenuItem1});
	    this.bootInNormalModeToolStripMenuItem.Name = "bootInNormalModeToolStripMenuItem";
	    this.bootInNormalModeToolStripMenuItem.Size = new System.Drawing.Size(401, 46);
	    this.bootInNormalModeToolStripMenuItem.Text = "Networking Options";
	    // 
	    // enableToolStripMenuItem1
	    // 
	    this.enableToolStripMenuItem1.Name = "enableToolStripMenuItem1";
	    this.enableToolStripMenuItem1.Size = new System.Drawing.Size(229, 46);
	    this.enableToolStripMenuItem1.Text = "Enable";
	    this.enableToolStripMenuItem1.Click += new System.EventHandler(this.enableToolStripMenuItem1_Click);
	    // 
	    // disableToolStripMenuItem1
	    // 
	    this.disableToolStripMenuItem1.Name = "disableToolStripMenuItem1";
	    this.disableToolStripMenuItem1.Size = new System.Drawing.Size(229, 46);
	    this.disableToolStripMenuItem1.Text = "Disable";
	    this.disableToolStripMenuItem1.Click += new System.EventHandler(this.disableToolStripMenuItem1_Click);
	    // 
	    // enableSafeModeWithCommandPromptToolStripMenuItem
	    // 
	    this.enableSafeModeWithCommandPromptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem2,
            this.disableToolStripMenuItem2});
	    this.enableSafeModeWithCommandPromptToolStripMenuItem.Name = "enableSafeModeWithCommandPromptToolStripMenuItem";
	    this.enableSafeModeWithCommandPromptToolStripMenuItem.Size = new System.Drawing.Size(401, 46);
	    this.enableSafeModeWithCommandPromptToolStripMenuItem.Text = "Command Prompt";
	    // 
	    // enableToolStripMenuItem2
	    // 
	    this.enableToolStripMenuItem2.Name = "enableToolStripMenuItem2";
	    this.enableToolStripMenuItem2.Size = new System.Drawing.Size(229, 46);
	    this.enableToolStripMenuItem2.Text = "Enable";
	    this.enableToolStripMenuItem2.Click += new System.EventHandler(this.enableToolStripMenuItem2_Click);
	    // 
	    // disableToolStripMenuItem2
	    // 
	    this.disableToolStripMenuItem2.Name = "disableToolStripMenuItem2";
	    this.disableToolStripMenuItem2.Size = new System.Drawing.Size(229, 46);
	    this.disableToolStripMenuItem2.Text = "Disable";
	    this.disableToolStripMenuItem2.Click += new System.EventHandler(this.disableToolStripMenuItem2_Click);
	    // 
	    // securityOptionsToolStripMenuItem
	    // 
	    this.securityOptionsToolStripMenuItem.Name = "securityOptionsToolStripMenuItem";
	    this.securityOptionsToolStripMenuItem.Size = new System.Drawing.Size(315, 46);
	    this.securityOptionsToolStripMenuItem.Text = "Security Options";
	    this.securityOptionsToolStripMenuItem.Visible = false;
	    this.securityOptionsToolStripMenuItem.Click += new System.EventHandler(this.securityOptionsToolStripMenuItem_Click);
	    // 
	    // copyrightToolStripMenuItem
	    // 
	    this.copyrightToolStripMenuItem.Name = "copyrightToolStripMenuItem";
	    this.copyrightToolStripMenuItem.Size = new System.Drawing.Size(315, 46);
	    this.copyrightToolStripMenuItem.Text = "Copyright";
	    this.copyrightToolStripMenuItem.Visible = false;
	    // 
	    // SafeModeStatus
	    // 
	    this.SafeModeStatus.AutoSize = true;
	    this.SafeModeStatus.BackColor = System.Drawing.Color.Transparent;
	    this.SafeModeStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.SafeModeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.SafeModeStatus.ForeColor = System.Drawing.Color.White;
	    this.SafeModeStatus.Location = new System.Drawing.Point(0, 127);
	    this.SafeModeStatus.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.SafeModeStatus.Name = "SafeModeStatus";
	    this.SafeModeStatus.Size = new System.Drawing.Size(327, 63);
	    this.SafeModeStatus.TabIndex = 3;
	    this.SafeModeStatus.Text = "Safe Mode: \r\n";
	    this.SafeModeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // NetworkingStatus
	    // 
	    this.NetworkingStatus.AutoSize = true;
	    this.NetworkingStatus.BackColor = System.Drawing.Color.Transparent;
	    this.NetworkingStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.NetworkingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.NetworkingStatus.ForeColor = System.Drawing.Color.White;
	    this.NetworkingStatus.Location = new System.Drawing.Point(0, 190);
	    this.NetworkingStatus.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.NetworkingStatus.Name = "NetworkingStatus";
	    this.NetworkingStatus.Size = new System.Drawing.Size(278, 63);
	    this.NetworkingStatus.TabIndex = 4;
	    this.NetworkingStatus.Text = "Network:  \r\n";
	    this.NetworkingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // CMDAccessStatus
	    // 
	    this.CMDAccessStatus.AutoSize = true;
	    this.CMDAccessStatus.BackColor = System.Drawing.Color.Transparent;
	    this.CMDAccessStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.CMDAccessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.CMDAccessStatus.ForeColor = System.Drawing.Color.White;
	    this.CMDAccessStatus.Location = new System.Drawing.Point(0, 253);
	    this.CMDAccessStatus.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
	    this.CMDAccessStatus.Name = "CMDAccessStatus";
	    this.CMDAccessStatus.Size = new System.Drawing.Size(704, 63);
	    this.CMDAccessStatus.TabIndex = 5;
	    this.CMDAccessStatus.Text = "Command Prompt Access: ";
	    this.CMDAccessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	    // 
	    // BootStatusTimer
	    // 
	    this.BootStatusTimer.Enabled = true;
	    this.BootStatusTimer.Tick += new System.EventHandler(this.BootStatusTimer_Tick);
	    // 
	    // panel1
	    // 
	    this.panel1.BackColor = System.Drawing.Color.Transparent;
	    this.panel1.Controls.Add(this.safeModeIconButton);
	    this.panel1.Controls.Add(this.SafeModeStatus);
	    this.panel1.Controls.Add(this.NetworkingStatus);
	    this.panel1.Controls.Add(this.CMDAccessStatus);
	    this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.panel1.Location = new System.Drawing.Point(0, 745);
	    this.panel1.Name = "panel1";
	    this.panel1.Size = new System.Drawing.Size(1925, 316);
	    this.panel1.TabIndex = 6;
	    // 
	    // Form_TitleScreen
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.BackgroundImage = global::XtremeHackerman.Properties.Resources.Background_TitleScreen;
	    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	    this.ClientSize = new System.Drawing.Size(1925, 1061);
	    this.Controls.Add(this.pictureBox_Title);
	    this.Controls.Add(this.tableLayoutPanel_Buttons);
	    this.Controls.Add(this.panel1);
	    this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
	    this.Name = "Form_TitleScreen";
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	    this.Text = "Xtreme Hackerman";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.Load += new System.EventHandler(this.Form_TitleScreen_Load);
	    this.tableLayoutPanel_Buttons.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.safeModeIconButton)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).EndInit();
	    this.safeModeContextStrip.ResumeLayout(false);
	    this.panel1.ResumeLayout(false);
	    this.panel1.PerformLayout();
	    this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Buttons;
        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Button button_Hacker;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.PictureBox pictureBox_Title;
        private System.Windows.Forms.PictureBox safeModeIconButton;
        private System.Windows.Forms.ContextMenuStrip safeModeContextStrip;
        private System.Windows.Forms.ToolStripMenuItem safeModeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootInSafeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootInNormalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSafeModeWithCommandPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem2;
        private System.Windows.Forms.Label SafeModeStatus;
        private System.Windows.Forms.Label NetworkingStatus;
        private System.Windows.Forms.Label CMDAccessStatus;
        private System.Windows.Forms.Timer BootStatusTimer;
	private System.Windows.Forms.Panel panel1;
    }
}