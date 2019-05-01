namespace XtremeHackerman
{
    partial class Form_SelectFile
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SelectFile));
	    this.folderView = new System.Windows.Forms.TreeView();
	    this.imageList1 = new System.Windows.Forms.ImageList(this.components);
	    this.fileView = new System.Windows.Forms.ListView();
	    this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
	    this.SelectButton = new System.Windows.Forms.Button();
	    this.CancelButton = new System.Windows.Forms.Button();
	    this.ButtonsPanel = new System.Windows.Forms.Panel();
	    this.splitter1 = new System.Windows.Forms.Splitter();
	    this.ButtonsPanel.SuspendLayout();
	    this.SuspendLayout();
	    // 
	    // folderView
	    // 
	    this.folderView.Dock = System.Windows.Forms.DockStyle.Left;
	    this.folderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.folderView.ImageIndex = 0;
	    this.folderView.ImageList = this.imageList1;
	    this.folderView.Location = new System.Drawing.Point(0, 0);
	    this.folderView.Name = "folderView";
	    this.folderView.SelectedImageIndex = 0;
	    this.folderView.Size = new System.Drawing.Size(504, 766);
	    this.folderView.TabIndex = 0;
	    this.folderView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.folderView_AfterSelect);
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
	    // fileView
	    // 
	    this.fileView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Type});
	    this.fileView.Dock = System.Windows.Forms.DockStyle.Fill;
	    this.fileView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.fileView.Location = new System.Drawing.Point(504, 0);
	    this.fileView.Name = "fileView";
	    this.fileView.Size = new System.Drawing.Size(997, 766);
	    this.fileView.SmallImageList = this.imageList1;
	    this.fileView.TabIndex = 1;
	    this.fileView.UseCompatibleStateImageBehavior = false;
	    this.fileView.View = System.Windows.Forms.View.Details;
	    // 
	    // FileName
	    // 
	    this.FileName.Text = "Name";
	    this.FileName.Width = 150;
	    // 
	    // Type
	    // 
	    this.Type.Text = "Type";
	    this.Type.Width = 275;
	    // 
	    // SelectButton
	    // 
	    this.SelectButton.Dock = System.Windows.Forms.DockStyle.Right;
	    this.SelectButton.Location = new System.Drawing.Point(725, 0);
	    this.SelectButton.Name = "SelectButton";
	    this.SelectButton.Size = new System.Drawing.Size(136, 70);
	    this.SelectButton.TabIndex = 2;
	    this.SelectButton.Text = "Select";
	    this.SelectButton.UseVisualStyleBackColor = true;
	    this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
	    // 
	    // CancelButton
	    // 
	    this.CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
	    this.CancelButton.Location = new System.Drawing.Point(861, 0);
	    this.CancelButton.Name = "CancelButton";
	    this.CancelButton.Size = new System.Drawing.Size(136, 70);
	    this.CancelButton.TabIndex = 3;
	    this.CancelButton.Text = "Cancel";
	    this.CancelButton.UseVisualStyleBackColor = true;
	    this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
	    // 
	    // ButtonsPanel
	    // 
	    this.ButtonsPanel.BackColor = System.Drawing.SystemColors.Window;
	    this.ButtonsPanel.Controls.Add(this.SelectButton);
	    this.ButtonsPanel.Controls.Add(this.CancelButton);
	    this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
	    this.ButtonsPanel.Location = new System.Drawing.Point(504, 696);
	    this.ButtonsPanel.Name = "ButtonsPanel";
	    this.ButtonsPanel.Size = new System.Drawing.Size(997, 70);
	    this.ButtonsPanel.TabIndex = 4;
	    // 
	    // splitter1
	    // 
	    this.splitter1.Location = new System.Drawing.Point(504, 0);
	    this.splitter1.Name = "splitter1";
	    this.splitter1.Size = new System.Drawing.Size(10, 696);
	    this.splitter1.TabIndex = 0;
	    this.splitter1.TabStop = false;
	    // 
	    // Form_SelectFile
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(1501, 766);
	    this.Controls.Add(this.splitter1);
	    this.Controls.Add(this.ButtonsPanel);
	    this.Controls.Add(this.fileView);
	    this.Controls.Add(this.folderView);
	    this.Name = "Form_SelectFile";
	    this.Text = "SelectFile";
	    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SelectFile_FormClosing);
	    this.Load += new System.EventHandler(this.Form_SelectFile_Load);
	    this.ButtonsPanel.ResumeLayout(false);
	    this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TreeView folderView;
	private System.Windows.Forms.ListView fileView;
	private System.Windows.Forms.ImageList imageList1;
	private System.Windows.Forms.ColumnHeader FileName;
	private System.Windows.Forms.ColumnHeader Type;
	private System.Windows.Forms.Button SelectButton;
	private System.Windows.Forms.Button CancelButton;
	private System.Windows.Forms.Panel ButtonsPanel;
	private System.Windows.Forms.Splitter splitter1;
    }
}