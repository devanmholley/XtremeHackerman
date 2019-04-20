using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman.Classes
{
    class Class_FileManager
    {

	//Initalize basic folders
	public static TreeNode root = new TreeNode("This PC", 2, 2);
	public static TreeNode docs = new TreeNode("Documents");
	public static TreeNode down = new TreeNode("Downloads");

	public static TreeView Folders = InitFolders();

	//dictionary<folder, filesInTheFolder>
	public static Dictionary<TreeNode, ListView> FolderFiles { get; set; } = new Dictionary<TreeNode, ListView>()
	{
	    {root, new ListView() },
	    {docs, new ListView() },
	    {down, new ListView() }
	};

	/// <summary>
	/// Creates a new folder through the UI: new folder button OR right click new folder
	/// </summary>
	/// <param name="currFolder"></param>
	public static void CreateFolder(ListView fileView, TreeNode currFolder)
	{
	    TreeNode newFolder;
	    ListViewItem newFolderItem = new ListViewItem();

	    //folderView side of things
	    newFolder = currFolder.Nodes.Add("New Folder"); //add new folder under parent folder
	    currFolder.Expand(); //show all child folders of parent
	    newFolder.BeginEdit(); //prompt for new folder name

	    FolderFiles.Add(newFolder, new ListView()); //Add it into the dictionary
	    refreshFileView(fileView, currFolder); //show new folder in fileview
	}

	/// <summary>
	/// Show subfolders and files of currently selected folder in fileView
	/// </summary>
	/// <param name="fileView"></param>
	/// <param name="currFolder"></param>
	public static void refreshFileView(ListView fileView, TreeNode currFolder)
	{
	    fileView.Items.Clear(); //clear fileView everytime new folder is selected

	    //populate folders first from folderView
	    foreach (TreeNode subfolder in currFolder.Nodes)
	    {
		ListViewItem newFolderItem;
		newFolderItem = fileView.Items.Add(subfolder.Text); //add folder's name, and show up in fileView
		newFolderItem.SubItems.Add("File Folder"); //add folder type
	    }

	    //populate files from dictionary
	    foreach (ListViewItem file in FolderFiles[currFolder].Items)
	    {
		var clone = file.Clone() as ListViewItem;
		clone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16);
		fileView.Items.Add(clone);
	    }
	}

	/// <summary>
	/// Returns file's folder path location
	/// </summary>
	/// <param name="currFolder"></param>
	/// <returns></returns>
	public static string getFilePath(TreeNode currFolder)
	{
	    string path = currFolder.FullPath;
	    return path;
	}

	/// <summary>
	/// A files tag = file path
	/// After folder is renamed, updates all the file's tag with the new path
	/// </summary>
	/// <param name="currFolder"></param>
	public static void updateFilePath(TreeNode currFolder)
	{
	    foreach (ListViewItem file in FolderFiles[currFolder].Items)
		file.Tag = getFilePath(currFolder);
	}

	private static TreeView InitFolders()
	{
	    TreeView folders = new TreeView();
	    root.Nodes.Add(docs);
	    root.Nodes.Add(down);
	    folders.Nodes.Add(root);
	    return folders;
	}
    }
}
