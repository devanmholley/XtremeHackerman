using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman.Classes
{
    /// <summary>
    /// Class_File is the details of a file
    /// Class_File will be the "Tag" of a ListViewItem(which acts as a file in FileManager)
    /// </summary>
    class Class_File
    {
	public static TreeNode Folder { get; set; }
	public static string FilePath { get; set; }
	public static string FileName { get; set; }
	public static string FileType { get; set; }
	public static bool IsMalicious { get; set; }
	public static object Content { get; set; }

	public Class_File(TreeNode folder, string filename, string filetype, bool ismalicious, object content)
	{
	    Folder = folder;
	    FilePath = folder.FullPath;
	    FileName = filename;
	    FileType = filetype;
	    IsMalicious = ismalicious;
	    Content = content;
	}

	/// <summary>
	/// Save a file/attachment from Email or InternetBrowser
	/// </summary>
	/// <param name="filename"></param>
	/// <param name="filetype"></param>
	/// <param name="ismalicious"></param>
	/// <param name="content"></param>
	public static void Save(TreeNode folder, string filename, string filetype, bool ismalicious, object content)
	{
	    if (folder == null)
	    {
		folder = Class_FileManager.down; //choose downloads folder
	    }
	    
	    //Create new ListViewItem
	    ListViewItem newFile = new ListViewItem();
	    newFile.Text = filename;
	    newFile.SubItems.Add(filetype);

	    Class_File fileTag = new Class_File(folder, filename, filetype, ismalicious, content); //Create new File
	    newFile.Tag = fileTag;

	    Class_FileManager.FolderFiles[folder].Items.Add(newFile);//add to dictionary
	}

	/// <summary>
	/// Save a file/attachment from Email or InternetBrowser 
	/// But allowing user to choose folder and name
	/// </summary>
	/// <param name="filename"></param>
	/// <param name="filetype"></param>
	/// <param name="ismalicious"></param>
	/// <param name="content"></param>
	public static void SaveAs(string filename, string filetype, bool ismalicious, object content)
	{
	    FileName = filename;
	    FileType = filetype;
	    IsMalicious = ismalicious;
	    Content = content;

	    //Pop up folder selecting dialog
	    var formSaveAs = new Form_SaveAs();
	    formSaveAs.ShowDialog();
	}
    }
}
