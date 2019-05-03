namespace XtremeHackerman
{
  partial class Form_FileManager
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FileManager));
	    this.toolStrip1 = new System.Windows.Forms.ToolStrip();
	    this.backFolderButton = new System.Windows.Forms.ToolStripButton();
	    this.forwardFolderButton = new System.Windows.Forms.ToolStripButton();
	    this.upFolderButton = new System.Windows.Forms.ToolStripButton();
	    this.newFolderButton = new System.Windows.Forms.ToolStripButton();
	    this.filePathComboBox = new System.Windows.Forms.ToolStripComboBox();
	    this.imageList1 = new System.Windows.Forms.ImageList(this.components);
	    this.folderViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.fileView = new System.Windows.Forms.ListView();
	    this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.fileViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	    this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	    this.folderView = new System.Windows.Forms.TreeView();
	    this.splitContainer1 = new System.Windows.Forms.SplitContainer();
	    this.toolStrip1.SuspendLayout();
	    this.folderViewMenuStrip.SuspendLayout();
	    this.fileViewMenuStrip.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
	    this.splitContainer1.Panel1.SuspendLayout();
	    this.splitContainer1.Panel2.SuspendLayout();
	    this.splitContainer1.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // toolStrip1
	    // 
	    this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backFolderButton,
            this.forwardFolderButton,
            this.upFolderButton,
            this.newFolderButton,
            this.filePathComboBox});
	    this.toolStrip1.Location = new System.Drawing.Point(0, 0);
	    this.toolStrip1.Name = "toolStrip1";
	    this.toolStrip1.Size = new System.Drawing.Size(1890, 47);
	    this.toolStrip1.TabIndex = 0;
	    this.toolStrip1.Text = "toolStrip1";
	    // 
	    // backFolderButton
	    // 
	    this.backFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.backFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("backFolderButton.Image")));
	    this.backFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.backFolderButton.Name = "backFolderButton";
	    this.backFolderButton.Size = new System.Drawing.Size(44, 44);
	    this.backFolderButton.Text = "Back";
	    // 
	    // forwardFolderButton
	    // 
	    this.forwardFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.forwardFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardFolderButton.Image")));
	    this.forwardFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.forwardFolderButton.Name = "forwardFolderButton";
	    this.forwardFolderButton.Size = new System.Drawing.Size(44, 44);
	    this.forwardFolderButton.Text = "Forward";
	    // 
	    // upFolderButton
	    // 
	    this.upFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.upFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("upFolderButton.Image")));
	    this.upFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.upFolderButton.Name = "upFolderButton";
	    this.upFolderButton.Size = new System.Drawing.Size(44, 44);
	    this.upFolderButton.Text = "Up";
	    // 
	    // newFolderButton
	    // 
	    this.newFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.newFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("newFolderButton.Image")));
	    this.newFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.newFolderButton.Name = "newFolderButton";
	    this.newFolderButton.Size = new System.Drawing.Size(44, 44);
	    this.newFolderButton.Text = "New Folder";
	    this.newFolderButton.Click += new System.EventHandler(this.newFolderButton_Click);
	    // 
	    // filePathComboBox
	    // 
	    this.filePathComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.filePathComboBox.Name = "filePathComboBox";
	    this.filePathComboBox.Size = new System.Drawing.Size(1000, 47);
	    // 
	    // imageList1
	    // 
	    this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
	    this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
	    this.imageList1.Images.SetKeyName(0, "folder.PNG");
	    this.imageList1.Images.SetKeyName(1, "openfolder.PNG");
	    this.imageList1.Images.SetKeyName(2, "thispc.png");
	    this.imageList1.Images.SetKeyName(3, "doc.PNG");
	    this.imageList1.Images.SetKeyName(4, "file.PNG");
	    this.imageList1.Images.SetKeyName(5, "img.PNG");
	    // 
	    // folderViewMenuStrip
	    // 
	    this.folderViewMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.folderViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
	    this.folderViewMenuStrip.Name = "contextMenuStrip1";
	    this.folderViewMenuStrip.Size = new System.Drawing.Size(249, 142);
	    this.folderViewMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.folderViewMenuStrip_Opening);
	    // 
	    // newFolderToolStripMenuItem
	    // 
	    this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
	    this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(248, 46);
	    this.newFolderToolStripMenuItem.Text = "New Folder";
	    this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
	    // 
	    // renameToolStripMenuItem
	    // 
	    this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
	    this.renameToolStripMenuItem.Size = new System.Drawing.Size(248, 46);
	    this.renameToolStripMenuItem.Text = "Rename";
	    this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
	    // 
	    // deleteToolStripMenuItem
	    // 
	    this.deleteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
	    this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
	    this.deleteToolStripMenuItem.Size = new System.Drawing.Size(248, 46);
	    this.deleteToolStripMenuItem.Text = "Delete";
	    this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
	    // 
	    // fileView
	    // 
	    this.fileView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
	    this.fileView.ContextMenuStrip = this.fileViewMenuStrip;
	    this.fileView.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.fileView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.fileView.LabelEdit = true;
	    this.fileView.Location = new System.Drawing.Point(0, 0);
	    this.fileView.Name = "fileView";
	    this.fileView.Size = new System.Drawing.Size(1418, 838);
	    this.fileView.SmallImageList = this.imageList1;
	    this.fileView.TabIndex = 2;
	    this.fileView.UseCompatibleStateImageBehavior = false;
	    this.fileView.View = System.Windows.Forms.View.Details;
	    this.fileView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.fileView_AfterLabelEdit);
	    this.fileView.DoubleClick += new System.EventHandler(this.fileView_DoubleClick);
	    // 
	    // columnHeader1
	    // 
	    this.columnHeader1.Text = "Name";
	    this.columnHeader1.Width = 399;
	    // 
	    // columnHeader2
	    // 
	    this.columnHeader2.Text = "Type";
	    this.columnHeader2.Width = 405;
	    // 
	    // fileViewMenuStrip
	    // 
	    this.fileViewMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.fileViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.renameToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
	    this.fileViewMenuStrip.Name = "contextMenuStrip2";
	    this.fileViewMenuStrip.Size = new System.Drawing.Size(204, 142);
	    // 
	    // newToolStripMenuItem
	    // 
	    this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.fileToolStripMenuItem});
	    this.newToolStripMenuItem.Name = "newToolStripMenuItem";
	    this.newToolStripMenuItem.Size = new System.Drawing.Size(203, 46);
	    this.newToolStripMenuItem.Text = "New";
	    // 
	    // folderToolStripMenuItem
	    // 
	    this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
	    this.folderToolStripMenuItem.Size = new System.Drawing.Size(332, 46);
	    this.folderToolStripMenuItem.Text = "Folder";
	    this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
	    // 
	    // fileToolStripMenuItem
	    // 
	    this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
	    this.fileToolStripMenuItem.Size = new System.Drawing.Size(332, 46);
	    this.fileToolStripMenuItem.Text = "Text Document";
	    this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
	    // 
	    // renameToolStripMenuItem1
	    // 
	    this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
	    this.renameToolStripMenuItem1.Size = new System.Drawing.Size(203, 46);
	    this.renameToolStripMenuItem1.Text = "Rename";
	    this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
	    // 
	    // deleteToolStripMenuItem1
	    // 
	    this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
	    this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(203, 46);
	    this.deleteToolStripMenuItem1.Text = "Delete";
	    this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
	    // 
	    // folderView
	    // 
	    this.folderView.ContextMenuStrip = this.folderViewMenuStrip;
	    this.folderView.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.folderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.folderView.ImageIndex = 0;
	    this.folderView.ImageList = this.imageList1;
	    this.folderView.LabelEdit = true;
	    this.folderView.Location = new System.Drawing.Point(0, 0);
	    this.folderView.Name = "folderView";
	    this.folderView.SelectedImageIndex = 0;
	    this.folderView.Size = new System.Drawing.Size(468, 838);
	    this.folderView.TabIndex = 0;
	    this.folderView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.folderView_AfterLabelEdit);
	    this.folderView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.folderView_AfterSelect);
	    // 
	    // splitContainer1
	    // 
	    this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.splitContainer1.Location = new System.Drawing.Point(0, 47);
	    this.splitContainer1.Name = "splitContainer1";
	    // 
	    // splitContainer1.Panel1
	    // 
	    this.splitContainer1.Panel1.Controls.Add(this.folderView);
	    // 
	    // splitContainer1.Panel2
	    // 
	    this.splitContainer1.Panel2.Controls.Add(this.fileView);
	    this.splitContainer1.Size = new System.Drawing.Size(1890, 838);
	    this.splitContainer1.SplitterDistance = 468;
	    this.splitContainer1.TabIndex = 3;
	    // 
	    // Form_FileManager
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(1890, 885);
	    this.Controls.Add(this.splitContainer1);
	    this.Controls.Add(this.toolStrip1);
	    this.Name = "Form_FileManager";
	    this.Text = "File Manager";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FileManager_FormClosing);
	    this.Load += new System.EventHandler(this.Form_FileManager_Load);
	    this.toolStrip1.ResumeLayout(false);
	    this.toolStrip1.PerformLayout();
	    this.folderViewMenuStrip.ResumeLayout(false);
	    this.fileViewMenuStrip.ResumeLayout(false);
	    this.splitContainer1.Panel1.ResumeLayout(false);
	    this.splitContainer1.Panel2.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
	    this.splitContainer1.ResumeLayout(false);
	    this.ResumeLayout(false);
	    this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton backFolderButton;
    private System.Windows.Forms.ToolStripButton forwardFolderButton;
    private System.Windows.Forms.ToolStripButton upFolderButton;
    private System.Windows.Forms.ToolStripComboBox filePathComboBox;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ToolStripButton newFolderButton;
    private System.Windows.Forms.ListView fileView;
    private System.Windows.Forms.ContextMenuStrip folderViewMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip fileViewMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
	private System.Windows.Forms.TreeView folderView;
	private System.Windows.Forms.SplitContainer splitContainer1;
    }
}