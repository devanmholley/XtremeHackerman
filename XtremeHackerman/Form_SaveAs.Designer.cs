namespace XtremeHackerman
{
    partial class Form_SaveAs
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
	    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SaveAs));
	    this.folderView = new System.Windows.Forms.TreeView();
	    this.imageList1 = new System.Windows.Forms.ImageList(this.components);
	    this.fileNameTextBox = new System.Windows.Forms.TextBox();
	    this.SaveButton = new System.Windows.Forms.Button();
	    this.CancelButton = new System.Windows.Forms.Button();
	    this.FileNameLabel = new System.Windows.Forms.Label();
	    this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
	    this.FileTypeLabel = new System.Windows.Forms.Label();
	    this.SuspendLayout();
	    // 
	    // folderView
	    // 
	    this.folderView.Dock = System.Windows.Forms.DockStyle.Top;
	    this.folderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	    this.folderView.ImageIndex = 0;
	    this.folderView.ImageList = this.imageList1;
	    this.folderView.Location = new System.Drawing.Point(0, 0);
	    this.folderView.Name = "folderView";
	    this.folderView.SelectedImageIndex = 1;
	    this.folderView.Size = new System.Drawing.Size(782, 591);
	    this.folderView.TabIndex = 0;
	    // 
	    // imageList1
	    // 
	    this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
	    this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
	    this.imageList1.Images.SetKeyName(0, "folder.PNG");
	    this.imageList1.Images.SetKeyName(1, "openfolder.PNG");
	    this.imageList1.Images.SetKeyName(2, "thispc.png");
	    // 
	    // fileNameTextBox
	    // 
	    this.fileNameTextBox.Location = new System.Drawing.Point(170, 618);
	    this.fileNameTextBox.Name = "fileNameTextBox";
	    this.fileNameTextBox.Size = new System.Drawing.Size(613, 38);
	    this.fileNameTextBox.TabIndex = 1;
	    // 
	    // SaveButton
	    // 
	    this.SaveButton.Location = new System.Drawing.Point(415, 761);
	    this.SaveButton.Name = "SaveButton";
	    this.SaveButton.Size = new System.Drawing.Size(170, 50);
	    this.SaveButton.TabIndex = 2;
	    this.SaveButton.Text = "Save";
	    this.SaveButton.UseVisualStyleBackColor = true;
	    this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
	    // 
	    // CancelButton
	    // 
	    this.CancelButton.Location = new System.Drawing.Point(600, 761);
	    this.CancelButton.Name = "CancelButton";
	    this.CancelButton.Size = new System.Drawing.Size(170, 50);
	    this.CancelButton.TabIndex = 3;
	    this.CancelButton.Text = "Cancel";
	    this.CancelButton.UseVisualStyleBackColor = true;
	    this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
	    // 
	    // FileNameLabel
	    // 
	    this.FileNameLabel.AutoSize = true;
	    this.FileNameLabel.Location = new System.Drawing.Point(12, 618);
	    this.FileNameLabel.Name = "FileNameLabel";
	    this.FileNameLabel.Size = new System.Drawing.Size(152, 32);
	    this.FileNameLabel.TabIndex = 4;
	    this.FileNameLabel.Text = "File Name:";
	    // 
	    // fileTypeComboBox
	    // 
	    this.fileTypeComboBox.FormattingEnabled = true;
	    this.fileTypeComboBox.Location = new System.Drawing.Point(170, 672);
	    this.fileTypeComboBox.Name = "fileTypeComboBox";
	    this.fileTypeComboBox.Size = new System.Drawing.Size(612, 39);
	    this.fileTypeComboBox.TabIndex = 6;
	    // 
	    // FileTypeLabel
	    // 
	    this.FileTypeLabel.AutoSize = true;
	    this.FileTypeLabel.Location = new System.Drawing.Point(12, 672);
	    this.FileTypeLabel.Name = "FileTypeLabel";
	    this.FileTypeLabel.Size = new System.Drawing.Size(140, 32);
	    this.FileTypeLabel.TabIndex = 7;
	    this.FileTypeLabel.Text = "File Type:";
	    // 
	    // Form_SaveAs
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(782, 823);
	    this.Controls.Add(this.FileTypeLabel);
	    this.Controls.Add(this.fileTypeComboBox);
	    this.Controls.Add(this.FileNameLabel);
	    this.Controls.Add(this.CancelButton);
	    this.Controls.Add(this.SaveButton);
	    this.Controls.Add(this.fileNameTextBox);
	    this.Controls.Add(this.folderView);
	    this.Name = "Form_SaveAs";
	    this.Text = "Form_SaveAs";
	    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SaveAs_FormClosing);
	    this.Load += new System.EventHandler(this.Form_SaveAs_Load);
	    this.ResumeLayout(false);
	    this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.TreeView folderView;
	private System.Windows.Forms.TextBox fileNameTextBox;
	private System.Windows.Forms.Button SaveButton;
	private System.Windows.Forms.Button CancelButton;
	private System.Windows.Forms.Label FileNameLabel;
	private System.Windows.Forms.ComboBox fileTypeComboBox;
	private System.Windows.Forms.ImageList imageList1;
	private System.Windows.Forms.Label FileTypeLabel;
    }
}