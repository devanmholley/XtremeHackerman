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
    public partial class Form_FileManager : Form
    {
	public Form_FileManager()
	{
	    InitializeComponent();
	    folderTreeView.ExpandAll(); // Automatically expands all folders
	}

	private void toolStripComboBox1_Click(object sender, EventArgs e)
	{

	}

	private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
	    //Click on folder in treeview, populate what's in the folder in listview
	    contentListView.Items.Clear(); //clear list view everytime new folder is selected

	    TreeNode folder = e.Node; //click on folder
	    foreach (TreeNode childNode in folder.Nodes)
	    {
	    ListViewItem newItem;
	    newItem = contentListView.Items.Add(childNode.Text); //add child folders into listview
	    newItem.ImageIndex = 0; //set it to have a folder icon
	    newItem.SubItems.Add("File Folder"); //set file type
	    }
      
	}

	private void toolStripButton4_Click(object sender, EventArgs e)
	{
	    // Add New Folder Button
	    TreeNode newFolder;
	    newFolder = folderTreeView.SelectedNode.Nodes.Add("New Folder");
	    folderTreeView.ExpandAll();
	    newFolder.BeginEdit();

	}

	private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Add New Folder from Right Click menu
	    TreeNode newFolder;
	    newFolder = folderTreeView.SelectedNode.Nodes.Add("New Folder");
	    folderTreeView.ExpandAll();
	    newFolder.BeginEdit();
	}

	private void renameToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Rename folder from Right Click menu
	    folderTreeView.SelectedNode.BeginEdit();
	}

	private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Delete folder from Right Click menu
	    folderTreeView.SelectedNode.Remove();
	}

	private void Form_FileManager_Load(object sender, EventArgs e)
	{
	    //fileManagerBindingSource.DataSource = Class_FileManager.FolderList;
	}
    }
}
