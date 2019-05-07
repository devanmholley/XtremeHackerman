namespace XtremeHackerman
{
    partial class Form_VirusTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VirusTotal));
            this.urlDetailsPanel = new System.Windows.Forms.Panel();
            this.ScanURLAgain = new System.Windows.Forms.Button();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.CommentsLBL = new System.Windows.Forms.Label();
            this.ServingIPTextbox = new System.Windows.Forms.TextBox();
            this.ServingIPLBL = new System.Windows.Forms.Label();
            this.finalURLTextbox = new System.Windows.Forms.TextBox();
            this.finalURLLBL = new System.Windows.Forms.Label();
            this.httpLBL = new System.Windows.Forms.Label();
            this.hostTextbox = new System.Windows.Forms.TextBox();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.urlHostlbl = new System.Windows.Forms.Label();
            this.urlLBL = new System.Windows.Forms.Label();
            this.urlDetailsbtn = new System.Windows.Forms.Button();
            this.urlDetailslbl = new System.Windows.Forms.Label();
            this.urlScanButton = new System.Windows.Forms.Button();
            this.virusTotalLogo = new System.Windows.Forms.Label();
            this.urlScanPanel = new System.Windows.Forms.Panel();
            this.urlScanner = new System.Windows.Forms.Button();
            this.urlScanHere = new System.Windows.Forms.TextBox();
            this.urlEntry = new System.Windows.Forms.TextBox();
            this.urlIcon = new System.Windows.Forms.PictureBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.fileScanButton = new System.Windows.Forms.Button();
            this.fileScanPanel = new System.Windows.Forms.Panel();
            this.fileScanTextBox = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.fileScanner = new System.Windows.Forms.Button();
            this.fileScanHere = new System.Windows.Forms.TextBox();
            this.fileIcon = new System.Windows.Forms.PictureBox();
            this.urlResultsPanel = new System.Windows.Forms.SplitContainer();
            this.urlResultsicon = new System.Windows.Forms.PictureBox();
            this.fileResultsPanel = new System.Windows.Forms.Panel();
            this.ScanFileAgain = new System.Windows.Forms.Button();
            this.isMaliciousLBL = new System.Windows.Forms.Label();
            this.MaliciousPic = new System.Windows.Forms.PictureBox();
            this.SafePic = new System.Windows.Forms.PictureBox();
            this.FileResultsLBL = new System.Windows.Forms.Label();
            this.selectedFileType = new System.Windows.Forms.Label();
            this.selectedFileName = new System.Windows.Forms.Label();
            this.FileTypeLBL = new System.Windows.Forms.Label();
            this.FileNameLBL = new System.Windows.Forms.Label();
            this.urlDetailsPanel.SuspendLayout();
            this.urlScanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlIcon)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.fileScanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urlResultsPanel)).BeginInit();
            this.urlResultsPanel.Panel1.SuspendLayout();
            this.urlResultsPanel.Panel2.SuspendLayout();
            this.urlResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlResultsicon)).BeginInit();
            this.fileResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaliciousPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafePic)).BeginInit();
            this.SuspendLayout();
            // 
            // urlDetailsPanel
            // 
            this.urlDetailsPanel.Controls.Add(this.ScanURLAgain);
            this.urlDetailsPanel.Controls.Add(this.CommentsTextBox);
            this.urlDetailsPanel.Controls.Add(this.CommentsLBL);
            this.urlDetailsPanel.Controls.Add(this.ServingIPTextbox);
            this.urlDetailsPanel.Controls.Add(this.ServingIPLBL);
            this.urlDetailsPanel.Controls.Add(this.finalURLTextbox);
            this.urlDetailsPanel.Controls.Add(this.finalURLLBL);
            this.urlDetailsPanel.Controls.Add(this.httpLBL);
            this.urlDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.urlDetailsPanel.Name = "urlDetailsPanel";
            this.urlDetailsPanel.Size = new System.Drawing.Size(651, 318);
            this.urlDetailsPanel.TabIndex = 5;
            this.urlDetailsPanel.Visible = false;
            // 
            // ScanURLAgain
            // 
            this.ScanURLAgain.Location = new System.Drawing.Point(96, 252);
            this.ScanURLAgain.Name = "ScanURLAgain";
            this.ScanURLAgain.Size = new System.Drawing.Size(75, 23);
            this.ScanURLAgain.TabIndex = 7;
            this.ScanURLAgain.Text = "Scan Again";
            this.ScanURLAgain.UseVisualStyleBackColor = true;
            this.ScanURLAgain.Click += new System.EventHandler(this.ScanAgainButton_Click);
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.BackColor = System.Drawing.Color.White;
            this.CommentsTextBox.Location = new System.Drawing.Point(255, 71);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.ReadOnly = true;
            this.CommentsTextBox.Size = new System.Drawing.Size(389, 207);
            this.CommentsTextBox.TabIndex = 6;
            this.CommentsTextBox.Text = "\r\n";
            // 
            // CommentsLBL
            // 
            this.CommentsLBL.AutoSize = true;
            this.CommentsLBL.Location = new System.Drawing.Point(253, 55);
            this.CommentsLBL.Name = "CommentsLBL";
            this.CommentsLBL.Size = new System.Drawing.Size(56, 13);
            this.CommentsLBL.TabIndex = 5;
            this.CommentsLBL.Text = "Comments";
            // 
            // ServingIPTextbox
            // 
            this.ServingIPTextbox.BackColor = System.Drawing.Color.White;
            this.ServingIPTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServingIPTextbox.Location = new System.Drawing.Point(42, 138);
            this.ServingIPTextbox.Name = "ServingIPTextbox";
            this.ServingIPTextbox.ReadOnly = true;
            this.ServingIPTextbox.Size = new System.Drawing.Size(193, 13);
            this.ServingIPTextbox.TabIndex = 4;
            // 
            // ServingIPLBL
            // 
            this.ServingIPLBL.AutoSize = true;
            this.ServingIPLBL.Location = new System.Drawing.Point(40, 122);
            this.ServingIPLBL.Name = "ServingIPLBL";
            this.ServingIPLBL.Size = new System.Drawing.Size(97, 13);
            this.ServingIPLBL.TabIndex = 3;
            this.ServingIPLBL.Text = "Serving IP Address";
            // 
            // finalURLTextbox
            // 
            this.finalURLTextbox.BackColor = System.Drawing.Color.White;
            this.finalURLTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalURLTextbox.Location = new System.Drawing.Point(42, 71);
            this.finalURLTextbox.Name = "finalURLTextbox";
            this.finalURLTextbox.ReadOnly = true;
            this.finalURLTextbox.Size = new System.Drawing.Size(193, 13);
            this.finalURLTextbox.TabIndex = 2;
            // 
            // finalURLLBL
            // 
            this.finalURLLBL.AutoSize = true;
            this.finalURLLBL.Location = new System.Drawing.Point(40, 55);
            this.finalURLLBL.Name = "finalURLLBL";
            this.finalURLLBL.Size = new System.Drawing.Size(54, 13);
            this.finalURLLBL.TabIndex = 1;
            this.finalURLLBL.Text = "Final URL";
            // 
            // httpLBL
            // 
            this.httpLBL.AutoSize = true;
            this.httpLBL.Location = new System.Drawing.Point(24, 15);
            this.httpLBL.Name = "httpLBL";
            this.httpLBL.Size = new System.Drawing.Size(87, 13);
            this.httpLBL.TabIndex = 0;
            this.httpLBL.Text = "HTTP Response";
            // 
            // hostTextbox
            // 
            this.hostTextbox.BackColor = System.Drawing.Color.White;
            this.hostTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostTextbox.Location = new System.Drawing.Point(237, 73);
            this.hostTextbox.Name = "hostTextbox";
            this.hostTextbox.Size = new System.Drawing.Size(124, 13);
            this.hostTextbox.TabIndex = 7;
            // 
            // urlTextbox
            // 
            this.urlTextbox.BackColor = System.Drawing.Color.White;
            this.urlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTextbox.Location = new System.Drawing.Point(237, 43);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(124, 13);
            this.urlTextbox.TabIndex = 6;
            // 
            // urlHostlbl
            // 
            this.urlHostlbl.AutoSize = true;
            this.urlHostlbl.BackColor = System.Drawing.Color.Transparent;
            this.urlHostlbl.Location = new System.Drawing.Point(198, 72);
            this.urlHostlbl.Name = "urlHostlbl";
            this.urlHostlbl.Size = new System.Drawing.Size(35, 13);
            this.urlHostlbl.TabIndex = 5;
            this.urlHostlbl.Text = "Host :";
            // 
            // urlLBL
            // 
            this.urlLBL.AutoSize = true;
            this.urlLBL.BackColor = System.Drawing.Color.Transparent;
            this.urlLBL.Location = new System.Drawing.Point(198, 43);
            this.urlLBL.Name = "urlLBL";
            this.urlLBL.Size = new System.Drawing.Size(35, 13);
            this.urlLBL.TabIndex = 4;
            this.urlLBL.Text = "URL :";
            // 
            // urlDetailsbtn
            // 
            this.urlDetailsbtn.BackColor = System.Drawing.SystemColors.Menu;
            this.urlDetailsbtn.Location = new System.Drawing.Point(102, 78);
            this.urlDetailsbtn.Name = "urlDetailsbtn";
            this.urlDetailsbtn.Size = new System.Drawing.Size(65, 23);
            this.urlDetailsbtn.TabIndex = 2;
            this.urlDetailsbtn.Text = "Details";
            this.urlDetailsbtn.UseVisualStyleBackColor = false;
            this.urlDetailsbtn.Click += new System.EventHandler(this.urlDetailsbtn_Click);
            // 
            // urlDetailslbl
            // 
            this.urlDetailslbl.AutoSize = true;
            this.urlDetailslbl.BackColor = System.Drawing.Color.Transparent;
            this.urlDetailslbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urlDetailslbl.Location = new System.Drawing.Point(198, 11);
            this.urlDetailslbl.Name = "urlDetailslbl";
            this.urlDetailslbl.Size = new System.Drawing.Size(168, 13);
            this.urlDetailslbl.TabIndex = 1;
            this.urlDetailslbl.Text = "No Engine detected with this URL";
            // 
            // urlScanButton
            // 
            this.urlScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlScanButton.Location = new System.Drawing.Point(112, 120);
            this.urlScanButton.Name = "urlScanButton";
            this.urlScanButton.Size = new System.Drawing.Size(65, 30);
            this.urlScanButton.TabIndex = 1;
            this.urlScanButton.Text = "URL";
            this.urlScanButton.UseVisualStyleBackColor = true;
            this.urlScanButton.Click += new System.EventHandler(this.urlScanButton_Click);
            // 
            // virusTotalLogo
            // 
            this.virusTotalLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virusTotalLogo.Location = new System.Drawing.Point(219, 48);
            this.virusTotalLogo.Name = "virusTotalLogo";
            this.virusTotalLogo.Size = new System.Drawing.Size(192, 30);
            this.virusTotalLogo.TabIndex = 0;
            this.virusTotalLogo.Text = "VirusTotals.com";
            // 
            // urlScanPanel
            // 
            this.urlScanPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urlScanPanel.Controls.Add(this.urlScanner);
            this.urlScanPanel.Controls.Add(this.SelectFileButton);
            this.urlScanPanel.Controls.Add(this.urlScanHere);
            this.urlScanPanel.Controls.Add(this.urlEntry);
            this.urlScanPanel.Controls.Add(this.urlIcon);
            this.urlScanPanel.Location = new System.Drawing.Point(0, 0);
            this.urlScanPanel.Name = "urlScanPanel";
            this.urlScanPanel.Size = new System.Drawing.Size(406, 215);
            this.urlScanPanel.TabIndex = 2;
            // 
            // urlScanner
            // 
            this.urlScanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urlScanner.BackgroundImage")));
            this.urlScanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urlScanner.Location = new System.Drawing.Point(359, 57);
            this.urlScanner.Name = "urlScanner";
            this.urlScanner.Size = new System.Drawing.Size(44, 34);
            this.urlScanner.TabIndex = 3;
            this.urlScanner.UseVisualStyleBackColor = true;
            this.urlScanner.Click += new System.EventHandler(this.urlScanner_Click);
            // 
            // urlScanHere
            // 
            this.urlScanHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlScanHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlScanHere.Location = new System.Drawing.Point(125, 39);
            this.urlScanHere.Name = "urlScanHere";
            this.urlScanHere.Size = new System.Drawing.Size(159, 24);
            this.urlScanHere.TabIndex = 2;
            this.urlScanHere.Text = "Scan URLs Here:";
            // 
            // urlEntry
            // 
            this.urlEntry.Location = new System.Drawing.Point(8, 67);
            this.urlEntry.Name = "urlEntry";
            this.urlEntry.Size = new System.Drawing.Size(350, 20);
            this.urlEntry.TabIndex = 1;
            // 
            // urlIcon
            // 
            this.urlIcon.BackColor = System.Drawing.Color.Transparent;
            this.urlIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urlIcon.BackgroundImage")));
            this.urlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.urlIcon.Location = new System.Drawing.Point(184, 10);
            this.urlIcon.Name = "urlIcon";
            this.urlIcon.Size = new System.Drawing.Size(40, 30);
            this.urlIcon.TabIndex = 0;
            this.urlIcon.TabStop = false;
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HomePanel.Controls.Add(this.urlScanButton);
            this.HomePanel.Controls.Add(this.fileScanButton);
            this.HomePanel.Controls.Add(this.virusTotalLogo);
            this.HomePanel.Controls.Add(this.fileScanPanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(651, 435);
            this.HomePanel.TabIndex = 9;
            // 
            // fileScanButton
            // 
            this.fileScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileScanButton.Location = new System.Drawing.Point(176, 120);
            this.fileScanButton.Name = "fileScanButton";
            this.fileScanButton.Size = new System.Drawing.Size(55, 30);
            this.fileScanButton.TabIndex = 3;
            this.fileScanButton.Text = "File";
            this.fileScanButton.UseVisualStyleBackColor = true;
            this.fileScanButton.Click += new System.EventHandler(this.fileScanButton_Click);
            // 
            // fileScanPanel
            // 
            this.fileScanPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileScanPanel.Controls.Add(this.fileScanTextBox);
            this.fileScanPanel.Controls.Add(this.fileScanner);
            this.fileScanPanel.Controls.Add(this.urlScanPanel);
            this.fileScanPanel.Controls.Add(this.fileScanHere);
            this.fileScanPanel.Controls.Add(this.fileIcon);
            this.fileScanPanel.Location = new System.Drawing.Point(109, 148);
            this.fileScanPanel.Name = "fileScanPanel";
            this.fileScanPanel.Size = new System.Drawing.Size(406, 215);
            this.fileScanPanel.TabIndex = 4;
            // 
            // fileScanTextBox
            // 
            this.fileScanTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fileScanTextBox.Location = new System.Drawing.Point(67, 67);
            this.fileScanTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.fileScanTextBox.Name = "fileScanTextBox";
            this.fileScanTextBox.ReadOnly = true;
            this.fileScanTextBox.Size = new System.Drawing.Size(291, 20);
            this.fileScanTextBox.TabIndex = 5;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(5, 67);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(1);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(63, 20);
            this.SelectFileButton.TabIndex = 4;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // fileScanner
            // 
            this.fileScanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileScanner.BackgroundImage")));
            this.fileScanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileScanner.Location = new System.Drawing.Point(359, 57);
            this.fileScanner.Name = "fileScanner";
            this.fileScanner.Size = new System.Drawing.Size(44, 34);
            this.fileScanner.TabIndex = 3;
            this.fileScanner.UseVisualStyleBackColor = true;
            this.fileScanner.Click += new System.EventHandler(this.fileScanner_Click);
            // 
            // fileScanHere
            // 
            this.fileScanHere.BackColor = System.Drawing.SystemColors.Window;
            this.fileScanHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileScanHere.Location = new System.Drawing.Point(148, 46);
            this.fileScanHere.Name = "fileScanHere";
            this.fileScanHere.ReadOnly = true;
            this.fileScanHere.Size = new System.Drawing.Size(159, 13);
            this.fileScanHere.TabIndex = 2;
            this.fileScanHere.Text = "Scan Your Files Here:";
            // 
            // fileIcon
            // 
            this.fileIcon.BackColor = System.Drawing.Color.Transparent;
            this.fileIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileIcon.BackgroundImage")));
            this.fileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fileIcon.Location = new System.Drawing.Point(183, 23);
            this.fileIcon.Name = "fileIcon";
            this.fileIcon.Size = new System.Drawing.Size(27, 17);
            this.fileIcon.TabIndex = 0;
            this.fileIcon.TabStop = false;
            // 
            // urlResultsPanel
            // 
            this.urlResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.urlResultsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.urlResultsPanel.Name = "urlResultsPanel";
            this.urlResultsPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // urlResultsPanel.Panel1
            // 
            this.urlResultsPanel.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.urlResultsPanel.Panel1.Controls.Add(this.urlDetailslbl);
            this.urlResultsPanel.Panel1.Controls.Add(this.urlDetailsbtn);
            this.urlResultsPanel.Panel1.Controls.Add(this.urlResultsicon);
            this.urlResultsPanel.Panel1.Controls.Add(this.urlLBL);
            this.urlResultsPanel.Panel1.Controls.Add(this.urlHostlbl);
            this.urlResultsPanel.Panel1.Controls.Add(this.urlTextbox);
            this.urlResultsPanel.Panel1.Controls.Add(this.hostTextbox);
            // 
            // urlResultsPanel.Panel2
            // 
            this.urlResultsPanel.Panel2.Controls.Add(this.urlDetailsPanel);
            this.urlResultsPanel.Size = new System.Drawing.Size(651, 435);
            this.urlResultsPanel.SplitterDistance = 115;
            this.urlResultsPanel.SplitterWidth = 2;
            this.urlResultsPanel.TabIndex = 9;
            // 
            // urlResultsicon
            // 
            this.urlResultsicon.BackColor = System.Drawing.Color.Transparent;
            this.urlResultsicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urlResultsicon.BackgroundImage")));
            this.urlResultsicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urlResultsicon.Location = new System.Drawing.Point(102, 23);
            this.urlResultsicon.Name = "urlResultsicon";
            this.urlResultsicon.Size = new System.Drawing.Size(65, 50);
            this.urlResultsicon.TabIndex = 3;
            this.urlResultsicon.TabStop = false;
            // 
            // fileResultsPanel
            // 
            this.fileResultsPanel.Controls.Add(this.ScanFileAgain);
            this.fileResultsPanel.Controls.Add(this.isMaliciousLBL);
            this.fileResultsPanel.Controls.Add(this.MaliciousPic);
            this.fileResultsPanel.Controls.Add(this.SafePic);
            this.fileResultsPanel.Controls.Add(this.FileResultsLBL);
            this.fileResultsPanel.Controls.Add(this.selectedFileType);
            this.fileResultsPanel.Controls.Add(this.selectedFileName);
            this.fileResultsPanel.Controls.Add(this.FileTypeLBL);
            this.fileResultsPanel.Controls.Add(this.FileNameLBL);
            this.fileResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.fileResultsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.fileResultsPanel.Name = "fileResultsPanel";
            this.fileResultsPanel.Size = new System.Drawing.Size(651, 435);
            this.fileResultsPanel.TabIndex = 8;
            // 
            // ScanFileAgain
            // 
            this.ScanFileAgain.Location = new System.Drawing.Point(273, 320);
            this.ScanFileAgain.Name = "ScanFileAgain";
            this.ScanFileAgain.Size = new System.Drawing.Size(75, 23);
            this.ScanFileAgain.TabIndex = 8;
            this.ScanFileAgain.Text = "Scan Again";
            this.ScanFileAgain.UseVisualStyleBackColor = true;
            this.ScanFileAgain.Click += new System.EventHandler(this.ScanAgainButton_Click);
            // 
            // isMaliciousLBL
            // 
            this.isMaliciousLBL.AutoSize = true;
            this.isMaliciousLBL.Location = new System.Drawing.Point(284, 230);
            this.isMaliciousLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.isMaliciousLBL.Name = "isMaliciousLBL";
            this.isMaliciousLBL.Size = new System.Drawing.Size(51, 13);
            this.isMaliciousLBL.TabIndex = 6;
            this.isMaliciousLBL.Text = "Malicious";
            // 
            // MaliciousPic
            // 
            this.MaliciousPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaliciousPic.BackgroundImage")));
            this.MaliciousPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaliciousPic.Location = new System.Drawing.Point(200, 201);
            this.MaliciousPic.Margin = new System.Windows.Forms.Padding(1);
            this.MaliciousPic.Name = "MaliciousPic";
            this.MaliciousPic.Size = new System.Drawing.Size(64, 71);
            this.MaliciousPic.TabIndex = 5;
            this.MaliciousPic.TabStop = false;
            // 
            // SafePic
            // 
            this.SafePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SafePic.BackgroundImage")));
            this.SafePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SafePic.Location = new System.Drawing.Point(200, 201);
            this.SafePic.Margin = new System.Windows.Forms.Padding(1);
            this.SafePic.Name = "SafePic";
            this.SafePic.Size = new System.Drawing.Size(64, 71);
            this.SafePic.TabIndex = 7;
            this.SafePic.TabStop = false;
            // 
            // FileResultsLBL
            // 
            this.FileResultsLBL.AutoSize = true;
            this.FileResultsLBL.Location = new System.Drawing.Point(270, 17);
            this.FileResultsLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FileResultsLBL.Name = "FileResultsLBL";
            this.FileResultsLBL.Size = new System.Drawing.Size(89, 13);
            this.FileResultsLBL.TabIndex = 4;
            this.FileResultsLBL.Text = "File Scan Results";
            // 
            // selectedFileType
            // 
            this.selectedFileType.AutoSize = true;
            this.selectedFileType.BackColor = System.Drawing.Color.White;
            this.selectedFileType.Location = new System.Drawing.Point(292, 111);
            this.selectedFileType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.selectedFileType.Name = "selectedFileType";
            this.selectedFileType.Size = new System.Drawing.Size(35, 13);
            this.selectedFileType.TabIndex = 3;
            this.selectedFileType.Text = "label4";
            // 
            // selectedFileName
            // 
            this.selectedFileName.AutoSize = true;
            this.selectedFileName.BackColor = System.Drawing.Color.White;
            this.selectedFileName.Location = new System.Drawing.Point(292, 78);
            this.selectedFileName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(35, 13);
            this.selectedFileName.TabIndex = 2;
            this.selectedFileName.Text = "label3";
            // 
            // FileTypeLBL
            // 
            this.FileTypeLBL.AutoSize = true;
            this.FileTypeLBL.Location = new System.Drawing.Point(221, 111);
            this.FileTypeLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FileTypeLBL.Name = "FileTypeLBL";
            this.FileTypeLBL.Size = new System.Drawing.Size(53, 13);
            this.FileTypeLBL.TabIndex = 1;
            this.FileTypeLBL.Text = "File Type:";
            // 
            // FileNameLBL
            // 
            this.FileNameLBL.AutoSize = true;
            this.FileNameLBL.Location = new System.Drawing.Point(221, 78);
            this.FileNameLBL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FileNameLBL.Name = "FileNameLBL";
            this.FileNameLBL.Size = new System.Drawing.Size(54, 13);
            this.FileNameLBL.TabIndex = 0;
            this.FileNameLBL.Text = "File Name";
            // 
            // Form_VirusTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 435);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.fileResultsPanel);
            this.Controls.Add(this.urlResultsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form_VirusTotal";
            this.Text = "Form_VirusTotal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.urlDetailsPanel.ResumeLayout(false);
            this.urlDetailsPanel.PerformLayout();
            this.urlScanPanel.ResumeLayout(false);
            this.urlScanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlIcon)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.fileScanPanel.ResumeLayout(false);
            this.fileScanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon)).EndInit();
            this.urlResultsPanel.Panel1.ResumeLayout(false);
            this.urlResultsPanel.Panel1.PerformLayout();
            this.urlResultsPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlResultsPanel)).EndInit();
            this.urlResultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlResultsicon)).EndInit();
            this.fileResultsPanel.ResumeLayout(false);
            this.fileResultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaliciousPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SafePic)).EndInit();
            this.ResumeLayout(false);

	}

	#endregion
	private System.Windows.Forms.Panel urlDetailsPanel;
	private System.Windows.Forms.Button ScanURLAgain;
	private System.Windows.Forms.TextBox CommentsTextBox;
	private System.Windows.Forms.Label CommentsLBL;
	private System.Windows.Forms.TextBox ServingIPTextbox;
	private System.Windows.Forms.Label ServingIPLBL;
	private System.Windows.Forms.TextBox finalURLTextbox;
	private System.Windows.Forms.Label finalURLLBL;
	private System.Windows.Forms.Label httpLBL;
	private System.Windows.Forms.TextBox hostTextbox;
	private System.Windows.Forms.TextBox urlTextbox;
	private System.Windows.Forms.Label urlHostlbl;
	private System.Windows.Forms.Label urlLBL;
	private System.Windows.Forms.PictureBox urlResultsicon;
	private System.Windows.Forms.Button urlDetailsbtn;
	private System.Windows.Forms.Label urlDetailslbl;
	private System.Windows.Forms.Button urlScanButton;
	private System.Windows.Forms.Label virusTotalLogo;
	private System.Windows.Forms.Panel urlScanPanel;
	private System.Windows.Forms.Button urlScanner;
	private System.Windows.Forms.TextBox urlScanHere;
	private System.Windows.Forms.TextBox urlEntry;
	private System.Windows.Forms.PictureBox urlIcon;
	private System.Windows.Forms.Panel HomePanel;
	private System.Windows.Forms.SplitContainer urlResultsPanel;
	private System.Windows.Forms.Button fileScanButton;
	private System.Windows.Forms.Panel fileScanPanel;
	private System.Windows.Forms.Button fileScanner;
	private System.Windows.Forms.TextBox fileScanHere;
	private System.Windows.Forms.PictureBox fileIcon;
	private System.Windows.Forms.Panel fileResultsPanel;
	private System.Windows.Forms.Label isMaliciousLBL;
	private System.Windows.Forms.PictureBox MaliciousPic;
	private System.Windows.Forms.Label FileResultsLBL;
	private System.Windows.Forms.Label selectedFileType;
	private System.Windows.Forms.Label selectedFileName;
	private System.Windows.Forms.Label FileTypeLBL;
	private System.Windows.Forms.Label FileNameLBL;
	private System.Windows.Forms.TextBox fileScanTextBox;
	private System.Windows.Forms.Button SelectFileButton;
	private System.Windows.Forms.PictureBox SafePic;
	private System.Windows.Forms.Button ScanFileAgain;
    }
}