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
	    this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
	    this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
	    this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
	    this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
	    this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
	    this.imageList1 = new System.Windows.Forms.ImageList(this.components);
	    this.folderTreeView = new System.Windows.Forms.TreeView();
	    this.folderContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.contentListView = new System.Windows.Forms.ListView();
	    this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.fileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
	    this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
	    this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	    this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
	    this.folderStructBindingSource = new System.Windows.Forms.BindingSource(this.components);
	    this.fileManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
	    this.toolStrip1.SuspendLayout();
	    this.folderContextMenuStrip.SuspendLayout();
	    this.fileContextMenuStrip.SuspendLayout();
	    ((System.ComponentModel.ISupportInitialize)(this.folderStructBindingSource)).BeginInit();
	    ((System.ComponentModel.ISupportInitialize)(this.fileManagerBindingSource)).BeginInit();
	    this.SuspendLayout();
	    // 
	    // toolStrip1
	    // 
	    this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripComboBox1});
	    this.toolStrip1.Location = new System.Drawing.Point(0, 0);
	    this.toolStrip1.Name = "toolStrip1";
	    this.toolStrip1.Size = new System.Drawing.Size(1890, 49);
	    this.toolStrip1.TabIndex = 0;
	    this.toolStrip1.Text = "toolStrip1";
	    // 
	    // toolStripButton1
	    // 
	    this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
	    this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.toolStripButton1.Name = "toolStripButton1";
	    this.toolStripButton1.Size = new System.Drawing.Size(44, 46);
	    this.toolStripButton1.Text = "Back";
	    // 
	    // toolStripButton2
	    // 
	    this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
	    this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.toolStripButton2.Name = "toolStripButton2";
	    this.toolStripButton2.Size = new System.Drawing.Size(44, 46);
	    this.toolStripButton2.Text = "Forward";
	    // 
	    // toolStripButton3
	    // 
	    this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
	    this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.toolStripButton3.Name = "toolStripButton3";
	    this.toolStripButton3.Size = new System.Drawing.Size(44, 46);
	    this.toolStripButton3.Text = "Up";
	    // 
	    // toolStripButton4
	    // 
	    this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
	    this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
	    this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
	    this.toolStripButton4.Name = "toolStripButton4";
	    this.toolStripButton4.Size = new System.Drawing.Size(44, 46);
	    this.toolStripButton4.Text = "New Folder";
	    this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
	    // 
	    // toolStripComboBox1
	    // 
	    this.toolStripComboBox1.Items.AddRange(new object[] {
            "This PC",
            "This PC > Documents",
            "This PC > Downloads"});
	    this.toolStripComboBox1.Name = "toolStripComboBox1";
	    this.toolStripComboBox1.Size = new System.Drawing.Size(1000, 49);
	    this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
	    // 
	    // imageList1
	    // 
	    this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
	    this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
	    this.imageList1.Images.SetKeyName(0, "folder.PNG");
	    this.imageList1.Images.SetKeyName(1, "openfolder.PNG");
	    this.imageList1.Images.SetKeyName(2, "doc.PNG");
	    this.imageList1.Images.SetKeyName(3, "file.PNG");
	    this.imageList1.Images.SetKeyName(4, "img.PNG");
	    this.imageList1.Images.SetKeyName(5, "thispc.png");
	    // 
	    // folderTreeView
	    // 
	    this.folderTreeView.ContextMenuStrip = this.folderContextMenuStrip;
	    this.folderTreeView.DataBindings.Add(new System.Windows.Forms.Binding("Name", this.folderStructBindingSource, "Name", true));
	    this.folderTreeView.Dock = System.Windows.Forms.DockStyle.Left;
	    this.folderTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.folderTreeView.ImageIndex = 0;
	    this.folderTreeView.ImageList = this.imageList1;
	    this.folderTreeView.LabelEdit = true;
	    this.folderTreeView.Location = new System.Drawing.Point(0, 49);
	    this.folderTreeView.Name = "folderTreeView";
	    this.folderTreeView.SelectedImageIndex = 1;
	    this.folderTreeView.Size = new System.Drawing.Size(751, 836);
	    this.folderTreeView.TabIndex = 1;
	    this.folderTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
	    // 
	    // folderContextMenuStrip
	    // 
	    this.folderContextMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.folderContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
	    this.folderContextMenuStrip.Name = "contextMenuStrip1";
	    this.folderContextMenuStrip.Size = new System.Drawing.Size(249, 142);
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
	    // contentListView
	    // 
	    this.contentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
	    this.contentListView.ContextMenuStrip = this.fileContextMenuStrip;
	    this.contentListView.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.contentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.contentListView.Location = new System.Drawing.Point(751, 49);
	    this.contentListView.Name = "contentListView";
	    this.contentListView.Size = new System.Drawing.Size(1139, 836);
	    this.contentListView.SmallImageList = this.imageList1;
	    this.contentListView.TabIndex = 2;
	    this.contentListView.UseCompatibleStateImageBehavior = false;
	    this.contentListView.View = System.Windows.Forms.View.Details;
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
	    // fileContextMenuStrip
	    // 
	    this.fileContextMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
	    this.fileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.renameToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
	    this.fileContextMenuStrip.Name = "contextMenuStrip2";
	    this.fileContextMenuStrip.Size = new System.Drawing.Size(204, 142);
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
	    this.folderToolStripMenuItem.Size = new System.Drawing.Size(216, 46);
	    this.folderToolStripMenuItem.Text = "Folder";
	    // 
	    // fileToolStripMenuItem
	    // 
	    this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
	    this.fileToolStripMenuItem.Size = new System.Drawing.Size(216, 46);
	    this.fileToolStripMenuItem.Text = "File";
	    // 
	    // renameToolStripMenuItem1
	    // 
	    this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
	    this.renameToolStripMenuItem1.Size = new System.Drawing.Size(203, 46);
	    this.renameToolStripMenuItem1.Text = "Rename";
	    // 
	    // deleteToolStripMenuItem1
	    // 
	    this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
	    this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(203, 46);
	    this.deleteToolStripMenuItem1.Text = "Delete";
	    // 
	    // folderStructBindingSource
	    // 
	    this.folderStructBindingSource.DataSource = typeof(XtremeHackerman.Classes.Class_FileManager.FolderStruct);
	    // 
	    // fileManagerBindingSource
	    // 
	    this.fileManagerBindingSource.DataSource = typeof(XtremeHackerman.Classes.Class_FileManager);
	    // 
	    // Form_FileManager
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(1890, 885);
	    this.Controls.Add(this.contentListView);
	    this.Controls.Add(this.folderTreeView);
	    this.Controls.Add(this.toolStrip1);
	    this.Name = "Form_FileManager";
	    this.Text = "File Manager";
	    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
	    this.Load += new System.EventHandler(this.Form_FileManager_Load);
	    this.toolStrip1.ResumeLayout(false);
	    this.toolStrip1.PerformLayout();
	    this.folderContextMenuStrip.ResumeLayout(false);
	    this.fileContextMenuStrip.ResumeLayout(false);
	    ((System.ComponentModel.ISupportInitialize)(this.folderStructBindingSource)).EndInit();
	    ((System.ComponentModel.ISupportInitialize)(this.fileManagerBindingSource)).EndInit();
	    this.ResumeLayout(false);
	    this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private System.Windows.Forms.TreeView folderTreeView;
    private System.Windows.Forms.ListView contentListView;
    private System.Windows.Forms.ContextMenuStrip folderContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip fileContextMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
	private System.Windows.Forms.BindingSource fileManagerBindingSource;
	private System.Windows.Forms.BindingSource folderStructBindingSource;
    }
}