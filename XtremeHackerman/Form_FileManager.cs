using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman
{
    public partial class Form_FileManager : Form
    {
	public Form_FileManager()
	{
	    InitializeComponent();
	}

	private void toolStripComboBox1_Click(object sender, EventArgs e)
	{

	}

	private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
	    //Click on folder in treeview, populate what's in the folder in listview
	    listView1.Items.Clear(); //clear list view everytime new folder is selected

	    TreeNode folder = e.Node; //click on folder
	    foreach (TreeNode childNode in folder.Nodes)
	    {
	    ListViewItem newItem;
	    newItem = listView1.Items.Add(childNode.Text); //add child folders into listview
	    newItem.ImageIndex = 0; //set it to have a folder icon
	    newItem.SubItems.Add("File Folder"); //set file type
	    }
      
	}

	private void toolStripButton4_Click(object sender, EventArgs e)
	{
	    // Add New Folder Button
	    TreeNode newFolder;
	    newFolder = treeView1.SelectedNode.Nodes.Add("New Folder");
	    treeView1.ExpandAll();
	    newFolder.BeginEdit();

	}

	private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Add New Folder from Right Click menu
	    TreeNode newFolder;
	    newFolder = treeView1.SelectedNode.Nodes.Add("New Folder");
	    treeView1.ExpandAll();
	    newFolder.BeginEdit();
	}

	private void renameToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Rename folder from Right Click menu
	    treeView1.SelectedNode.BeginEdit();
	}

	private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Delete folder from Right Click menu
	    treeView1.SelectedNode.Remove();
	}

	private void Form_FileManager_Load(object sender, EventArgs e)
	{
	    treeView1.ExpandAll(); // Automatically expands all folders
	}
    }
}
