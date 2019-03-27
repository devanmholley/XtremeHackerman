using System;
using System.Collections;
using System.Windows.Forms;

namespace XtremeHackerman
{
    public partial class Form_FileManager : Form
    {
	public Form_FileManager()
	{
	    InitializeComponent();

	    //Create Basic Folders: ThisPC, Documents, and Downloads
	    TreeNode pc;
	    pc = treeView1.Nodes.Add("ThisPC");
	    pc.ImageIndex = 5; //set PC icon
	    pc.SelectedImageIndex = 5; //set PC icon

	    pc.Nodes.Add("Documents"); //add as child node under ThisPC
	    pc.Nodes.Add("Downloads"); //add as child node under ThisPC
	}

	private void Form_FileManager_Load(object sender, EventArgs e)
	{
	    treeView1.Nodes[0].Expand(); // Automatically expands to show all subfolders of "ThisPC"
	}

	private void toolStripComboBox1_Click(object sender, EventArgs e)
	{
	    //ComboBox to display or select file path
	}

	private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
	    //Click on folder in treeview, show subdirectories of selected folder in listview

	    listView1.Items.Clear(); //clear list view everytime new folder is selected

	    TreeNode folder = e.Node; //click on folder
	    foreach (TreeNode childNode in folder.Nodes) //for all subdirectories in the folder
	    {
	    ListViewItem newItem;
	    newItem = listView1.Items.Add(childNode.Text); //add child folders into listview
	    newItem.SubItems.Add("File Folder"); //set file type
	    }
    
	}

	private void toolStripButton4_Click(object sender, EventArgs e)
	{
	    // Add New Folder Button
	    TreeNode parentFolder, newFolder;
	    parentFolder = treeView1.SelectedNode;
	    newFolder = parentFolder.Nodes.Add("New Folder"); //add new folder under parent folder
	    parentFolder.Expand(); //show all child folders of parent
	    newFolder.BeginEdit(); //prompt for new folder name
	}

	private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Add New Folder from Right Click menu
	    TreeNode parentFolder, newFolder;
	    parentFolder = treeView1.SelectedNode;
	    newFolder = parentFolder.Nodes.Add("New Folder"); //add new folder under parent folder
	    parentFolder.Expand(); //show all child folders of parent
	    newFolder.BeginEdit(); //prompt for new folder name
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

	private void fileToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Create New Text Document
	}
    }
}
