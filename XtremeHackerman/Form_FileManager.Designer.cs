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
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Documents");
      System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Downloads");
      System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("This PC", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
      this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.listView1 = new System.Windows.Forms.ListView();
      this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1.SuspendLayout();
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
            this.toolStripButton5,
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
      this.toolStripButton1.Text = "toolStripButton1";
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
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(44, 46);
      this.toolStripButton2.Text = "toolStripButton2";
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
      this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.Size = new System.Drawing.Size(44, 46);
      this.toolStripButton3.Text = "toolStripButton3";
      // 
      // toolStripComboBox1
      // 
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new System.Drawing.Size(1000, 49);
      this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
      this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeView1.ImageIndex = 0;
      this.treeView1.ImageList = this.imageList1;
      this.treeView1.LabelEdit = true;
      this.treeView1.Location = new System.Drawing.Point(0, 49);
      this.treeView1.Name = "treeView1";
      treeNode1.Name = "Node1";
      treeNode1.Text = "Documents";
      treeNode2.Name = "Node2";
      treeNode2.Text = "Downloads";
      treeNode3.ImageIndex = 5;
      treeNode3.Name = "Node0";
      treeNode3.SelectedImageIndex = 5;
      treeNode3.Text = "This PC";
      this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
      this.treeView1.SelectedImageIndex = 1;
      this.treeView1.Size = new System.Drawing.Size(751, 836);
      this.treeView1.TabIndex = 1;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // listView1
      // 
      this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView1.Location = new System.Drawing.Point(751, 49);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(1139, 836);
      this.listView1.TabIndex = 2;
      this.listView1.UseCompatibleStateImageBehavior = false;
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.Size = new System.Drawing.Size(44, 46);
      this.toolStripButton4.Text = "toolStripButton4";
      // 
      // toolStripButton5
      // 
      this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
      this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton5.Name = "toolStripButton5";
      this.toolStripButton5.Size = new System.Drawing.Size(44, 46);
      this.toolStripButton5.Text = "toolStripButton5";
      // 
      // Form_FileManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1890, 885);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "Form_FileManager";
      this.Text = "File Manager";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
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
    private System.Windows.Forms.ToolStripButton toolStripButton5;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.ListView listView1;
  }
}