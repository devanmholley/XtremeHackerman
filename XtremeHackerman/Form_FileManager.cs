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
	    pc = folderView.Nodes.Add("ThisPC");
	    pc.ImageIndex = 5; //set PC icon
	    pc.SelectedImageIndex = 5; //set PC icon

	    pc.Nodes.Add("Documents"); //add as child node under ThisPC
	    pc.Nodes.Add("Downloads"); //add as child node under ThisPC
	}

	private void Form_FileManager_Load(object sender, EventArgs e)
	{
	    folderView.Nodes[0].Expand(); // Automatically expands to show all subfolders of "ThisPC"
	}

	private void filePathComboBox_Click(object sender, EventArgs e)
	{
	    //ComboBox to display or select file path
	}

	private void folderView_AfterSelect(object sender, TreeViewEventArgs e)
	{
	    //Click on folder in treeview, show subdirectories of selected folder in listview

	    fileView.Items.Clear(); //clear list view everytime new folder is selected

	    TreeNode folder = e.Node; //click on folder
	    foreach (TreeNode childNode in folder.Nodes) //for all subdirectories in the folder
	    {
	    ListViewItem newItem;
	    newItem = fileView.Items.Add(childNode.Text); //add child folders into listview
	    newItem.SubItems.Add("File Folder"); //set file type
	    }
    
	}

	private void newFolderButton_Click(object sender, EventArgs e)
	{
	    // Add New Folder Button from icon/toolbar
	    TreeNode parentFolder, newFolder;
	    parentFolder = folderView.SelectedNode;
	    newFolder = parentFolder.Nodes.Add("New Folder"); //add new folder under parent folder
	    parentFolder.Expand(); //show all child folders of parent
	    newFolder.BeginEdit(); //prompt for new folder name
	}

	private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Add New Folder from Right Click menu in TREEVIEW
	    TreeNode parentFolder, newFolder;
	    parentFolder = folderView.SelectedNode;
	    newFolder = parentFolder.Nodes.Add("New Folder"); //add new folder under parent folder
	    parentFolder.Expand(); //show all child folders of parent
	    newFolder.BeginEdit(); //prompt for new folder name
	}

	private void renameToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
	    // Rename folder from Right Click menu
	    folderView.SelectedNode.BeginEdit();
	}

	private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Delete folder from Right Click menu
	    if (folderView.SelectedNode.Parent != null) //Not allowed to delete "ThisPC" aka root node (ThisPC will have null parent)
	    {
		folderView.SelectedNode.Remove();
	    }
	    else
	    {
		MessageBox.Show("Deletion of Root Folder not allowed");
	    }
	}

	private void fileToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Create New Text Document
	}

	private void folderView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
	{
	    // Validate folder name, no empty name, no invalid characters
	    //Code Attribution: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.afterlabeledit?view=netframework-4.7.2

	    if (e.Label != null)
	    {
		if (e.Label.Length > 0)
		{
		    foreach (TreeNode folder in e.Node.Parent.Nodes) // check that there are no other similar named folders within current level
		    {
			if (!folder.Equals(e.Node) && folder.Text == e.Label)
			    {
			    MessageBox.Show("This destination already contains a folder named '" + e.Label + "'");
			    e.CancelEdit = true;
			    } 
		    }

		    if (e.Label.IndexOfAny(new char[] { '\\', '/', '*', '?', '"', '<', '>', '|' }) == -1) //does not contain any invalid characters
			// Stop editing without canceling the label change.
			e.Node.EndEdit(false);
		    else
		    {
			// Cancel the label edit action, inform the user, and place the node in edit mode again
			e.CancelEdit = true;
			MessageBox.Show("A file name can't contain any of the following characters:\n \\ / : * ? \" < > |"); //mimicing windows invalid characters message
			e.Node.BeginEdit();
		    }
		}
		else
		{
		    // Cancel the label edit action, inform the user, and place the node in edit mode again
		    e.CancelEdit = true;
		    MessageBox.Show("A file name can't be blank"); //cannot be blank name
		    e.Node.BeginEdit();
		}
	    }
	}
    }
}
