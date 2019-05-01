using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XtremeHackerman.Classes;

namespace XtremeHackerman
{
    public partial class Form_SelectFile : Form
    {
	public static ListViewItem selectedFile { get; set; }

	public Form_SelectFile()
	{
	    InitializeComponent();
	}

	private void Form_SelectFile_Load(object sender, EventArgs e)
	{
	    folderView.Nodes.Add(Class_FileManager.root);
	    folderView.Nodes[0].Expand();
	}

	private void Form_SelectFile_FormClosing(object sender, FormClosingEventArgs e)
	{
	    folderView.Nodes.Clear();
	}

	private void folderView_AfterSelect(object sender, TreeViewEventArgs e)
	{
	    //Click on folder in treeview, show folders and files in listView
	    TreeNode currFolder = folderView.SelectedNode;
	    Class_FileManager.refreshFileView(fileView, currFolder); //populate files
	}

	private void CancelButton_Click(object sender, EventArgs e)
	{
	    Close();
	}

	private void SelectButton_Click(object sender, EventArgs e)
	{
	    if (fileView.SelectedItems.Count >= 1 && fileView.SelectedItems[0].SubItems[1].Text != "File Folder")
	    {
		selectedFile = fileView.SelectedItems[0];
		DialogResult = DialogResult.OK;
		Close();
	    }
	}
    }
}
