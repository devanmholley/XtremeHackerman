﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman.Classes
{
    class Class_Antivirus
    {
	public static List<ListViewItem> MalwareList;

	// When the scan 'finishes' display the results.
	// This method is called after the 'scan button is clicked.
	public static void ScanResults()
        {
	    MalwareList = new List<ListViewItem>();
	    foreach (KeyValuePair<TreeNode, ListView> entry in Class_FileManager.FolderFiles) //iterate through dictionary
	    {
		foreach (ListViewItem file in entry.Value.Items) //look at all files in each folder
		{
		    var fileDetails = (Class_File)file.Tag; //grab file details of file
		    if ( fileDetails.IsMalicious == true ) //check if file is malicious
		    {
			MalwareList.Add(file); //append to list if true
		    }
		}
	    }
	}

	public static void RemoveAllThreats()
	{
	    foreach (ListViewItem malware in MalwareList) //delete files from dictionary
		malware.Remove();
	}
    }
}
