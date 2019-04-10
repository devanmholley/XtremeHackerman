using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XtremeHackerman.Classes;

namespace XtremeHackerman
{
    public partial class Form_FileManager : Form
    {
	public Dictionary<TreeNode, ListView> FolderFiles = Class_FileManager.FolderFiles;

	public Form_FileManager()
	{
	    InitializeComponent();

	    //Create Basic Folders: ThisPC, Documents, and Downloads
	    TreeNode pc, folder;
	    ListView pcfiles = new ListView();
	    ListView files = new ListView();

	    pc = folderView.Nodes.Add("ThisPC"); //Create "ThisPC" folder
	    pc.ImageIndex = 5; //set PC icon
	    pc.SelectedImageIndex = 5; //set PC icon
	    FolderFiles.Add(pc, pcfiles); //add to dictionary

	    folder = pc.Nodes.Add("Documents"); //add as child node under ThisPC
	    FolderFiles.Add(folder, files); //add to dictionary

	    files = new ListView(); 
	    folder = pc.Nodes.Add("Downloads"); //add as child node under ThisPC
	    FolderFiles.Add(folder, files); // add to dictionary
	}

	private void Form_FileManager_Load(object sender, EventArgs e)
	{
	    folderView.Nodes[0].Expand(); // Automatically expands to show all subfolders of "ThisPC" when opening filemanager
	}

/************************************************************************************************
* 
* Folder Stuff
* 
* **********************************************************************************************/

	private void folderView_AfterSelect(object sender, TreeViewEventArgs e)
	{
	    //Click on folder in treeview, show folders and files in listView
	    TreeNode currFolder = folderView.SelectedNode;

	    // if folder is "ThicPC", don't allow creation of new text document
	    if (currFolder.Parent == null) //PC has null parent
	    {
		fileToolStripMenuItem.Visible = false; //do not allow new files to be created
	    }
	    else
		fileToolStripMenuItem.Visible = true; //allow new files to be created

	    Class_FileManager.refreshFileView(fileView, currFolder); //populate files
	    filePathComboBox.Text = Class_FileManager.getFilePath(folderView.SelectedNode); //update combobox to display current path
	}

	private void newFolderButton_Click(object sender, EventArgs e)
	{
	    // Create New Folder Button from icon/toolbar
	    Class_FileManager.CreateFolder(fileView, folderView.SelectedNode);
	}

	private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Create New Folder from Right Click menu in TREEVIEW
	    Class_FileManager.CreateFolder(fileView, folderView.SelectedNode);
	}

	private void folderToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    // Create New Folder from right click menu in LISTVIEW
	    Class_FileManager.CreateFolder(fileView, folderView.SelectedNode);
	}

	private void renameToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
	    // Rename folder from Right Click menu
	    TreeNode currFolder = folderView.SelectedNode;
	    currFolder.BeginEdit();
	    Class_FileManager.refreshFileView(fileView, currFolder); //populate files
	}

	private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Delete folder from Right Click menu in folderView
	    if (folderView.SelectedNode.Parent != null) //Not allowed to delete "ThisPC" aka root node (ThisPC will have null parent)
	    {
		FolderFiles.Remove(folderView.SelectedNode);
		folderView.SelectedNode.Remove();
	    }
	    else
	    {
		MessageBox.Show("Deletion of Root Folder not allowed");
	    }
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
	    this.BeginInvoke(new Action(() => Class_FileManager.refreshFileView(fileView, folderView.SelectedNode))); //refresh file view AFTER label has finished editing
	}

/************************************************************************************************
* 
* File Stuff
* 
* **********************************************************************************************/

	private void fileToolStripMenuItem_Click(object sender, EventArgs e)
	{
	    //Create New Text Document
	    ListViewItem newDoc = new ListViewItem();
	    newDoc.Text = "New Text Document";
	    newDoc.SubItems.Add("Text Document");
	    newDoc.Tag = Class_FileManager.getFilePath(folderView.SelectedNode); //set file location path
	    FolderFiles[folderView.SelectedNode].Items.Add(newDoc); //add it to the dictionary

	    newDoc = fileView.Items.Add("New Text Document");
	    newDoc.SubItems.Add("Text Document");
	    newDoc.BeginEdit(); //prompt for new file name
	}


	private void renameToolStripMenuItem1_Click(object sender, EventArgs e)
	{
	    //Rename text document file from RIGHT CLICK
	    if (fileView.SelectedItems.Count > 0) //make sure something is selected
	    {
		fileView.SelectedItems[0].BeginEdit();
	    }
	}

	private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
	{
	    //Delete file or folder from fileView
	    ListViewItem currFile = fileView.SelectedItems[0];
	    TreeNode currFolder = folderView.SelectedNode;
	    int numFolders = currFolder.Nodes.Count;

	    if (currFile.SubItems[1].Text == "Text Document")
	    {
		int fileIndex = currFile.Index - numFolders;
		FolderFiles[currFolder].Items[fileIndex].Remove(); //delete from dictionary
		currFile.Remove(); //delete from fileview

	    }
	    else if (currFile.SubItems[1].Text == "File Folder")
	    {
		int fileIndex = currFile.Index; //get index of what is selected in fileview
		FolderFiles.Remove(currFolder.Nodes[fileIndex]); //delete selected folder from dictionary
		currFolder.Nodes[fileIndex].Remove(); //delete from folderview
		Class_FileManager.refreshFileView(fileView, currFolder); //refresh to disappear from fileview
	    }
	}

	private void folderView_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
	{
	    //Does not allow renaming of root folder "ThicPC"
	    if (e.Node.Parent == null)
	    {
	    e.CancelEdit = true;
	    MessageBox.Show("Edit of Root Folder is not allowed");
	    }
	}

	private void fileView_AfterLabelEdit(object sender, LabelEditEventArgs e)
	{
	    // Validate file name, no empty name, no invalid characters
	    //Code Attribution: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.afterlabeledit?view=netframework-4.7.2
	    if (e.Label != null)
	    {
		if (e.Label.Length > 0)
		{
		    foreach (ListViewItem file in fileView.Items) // check that there are no other similar named folders within current level
		    {
			if (!file.Equals(e.Item) && file.Text == e.Label)
			{
			    MessageBox.Show("This destination already contains a file named '" + e.Label + "'");
			    e.CancelEdit = true;
			}
		    }
		    if (e.Label.IndexOfAny(new char[] { '\\', '/', '*', '?', '"', '<', '>', '|' }) != -1) //contains invalid characters
		    {
			// Cancel the label edit action and inform the user
			e.CancelEdit = true;
			MessageBox.Show("A file name can't contain any of the following characters:\n \\ / : * ? \" < > |"); //mimicing windows invalid characters message
		    }
		}
		else
		{
		    // Cancel the label edit action and inform the user
		    e.CancelEdit = true;
		    MessageBox.Show("A file name can't be blank"); //cannot be blank name
		}

		//Time to reflect changes in dictionary
		ListViewItem currFile = fileView.SelectedItems[0];
		TreeNode currFolder = folderView.SelectedNode; //current folder	
		int numFolders = currFolder.Nodes.Count; //get num of folders currently listed in fileview

		//Change appropiate file to reflect in the dictionary
		if (currFile.SubItems[1].Text == "Text Document")
		{
		    int fileIndex = currFile.Index - numFolders; //calculate index of what the file index would be in the dictionary		   
		    FolderFiles[currFolder].Items[fileIndex].Text = e.Label; //renames the file in the Dictionary
		}
		//Changing Folder Name in fileView: reflect appropriate folder name in folderView
		else if (currFile.SubItems[1].Text == "File Folder")
		{
		    int fileIndex = currFile.Index; //get index of folder
		    currFolder.Nodes[fileIndex].Text = e.Label; //rename the folder in folderView
		}

	    }
	}
    }
}
