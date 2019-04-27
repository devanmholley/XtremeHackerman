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
	    fileNameTextBox.Text = Class_File.SaveAsFileName;  
	    fileTypeComboBox.Text = Class_File.SaveAsFileType;

	    //Show all folders of Root
	    folderView.Nodes[0].Expand(); 
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
	    //Checks file name validation then saves file into chosen folder
	    ListView fileView = Class_FileManager.FolderFiles[folderView.SelectedNode];

	    // Validate file name, no empty name, no invalid characters
	    if (fileNameTextBox.Text != null)
	    {
		if (fileNameTextBox.Text.Length > 0)
		{
		    foreach (ListViewItem file in fileView.Items) // check that there are no other similar named files within current level
		    {
			if (file.Text == fileNameTextBox.Text)
			{
			    MessageBox.Show("This destination already contains a file named '" + fileNameTextBox.Text + "'");
			}
		    }
		    if (fileNameTextBox.Text.IndexOfAny(new char[] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' }) == -1) //does not contain invalid characters
		    {
			Class_File.Save(folderView.SelectedNode, fileNameTextBox.Text, fileTypeComboBox.Text, Class_File.SaveAsIsMalicious, Class_File.SaveAsContent);
			Close();
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
	    Close();
	}
    }
}
