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
    public partial class Form_SaveAs : Form
    {
	public Form_SaveAs()
	{
	    InitializeComponent();
	}

	private void Form_SaveAs_Load(object sender, EventArgs e)
	{
	    //Show name and type upon opening 
	    FileNameLabel.Text = Class_File.FileName;  
	    FileTypeLabel.Text = Class_File.FileType;
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
	    //Checks file name validation then saves file into chosen folder
	    ListView fileView = Class_FileManager.FolderFiles[folderView.SelectedNode];

	    // Validate file name, no empty name, no invalid characters
	    if (FileNameLabel.Text != null)
	    {
		if (FileNameLabel.Text.Length > 0)
		{
		    foreach (ListViewItem file in fileView.Items) // check that there are no other similar named files within current level
		    {
			if (file.Text == FileNameLabel.Text)
			{
			    MessageBox.Show("This destination already contains a file named '" + FileNameLabel.Text + "'");
			}
		    }
		    if (FileNameLabel.Text.IndexOfAny(new char[] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' }) == -1) //does not contain invalid characters
		    {
			Class_File.Save(folderView.SelectedNode, FileNameLabel.Text, FileTypeLabel.Text, Class_File.IsMalicious, Class_File.Content);
		    }
		    else //contains invalid characters
		    {
			MessageBox.Show("A file name can't contain any of the following characters:\n \\ / : * ? \" < > |"); //mimicing windows invalid characters message
		    }
		}
		else
		{
		    MessageBox.Show("A file name can't be blank"); //cannot be blank name
		}
	    }
	}

	private void CancelButton_Click(object sender, EventArgs e)
	{
	    this.Close();
	}
    }
}
