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
    public partial class Form_VirusTotal : Form
    {
	ListViewItem selectedFile;
	List<string> unsafeUrls = new List<string>(15) { "viruses.com", "thebest.com" };

	public Form_VirusTotal()
	{
	    InitializeComponent();
	}

	private void urlScanButton_Click(object sender, EventArgs e)
	{
	    urlScanPanel.Visible = true;
	    fileScanPanel.Visible = false;
	}

	//this the code behind making the button work for shifting between virus totals panels
	private void urlScanner_Click(object sender, EventArgs e)
	{
	    if (urlEntry.Text != null)
	    {
		urlResultsPanel.Visible = true;
		urlResultsPanel.BringToFront();
		urlTextbox.Text = "https://" + urlEntry.Text;
		hostTextbox.Text = urlEntry.Text;

		var random = new Random();
		string randomIP = $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
		ServingIPTextbox.Text = randomIP;

		if (unsafeUrls.Contains(urlEntry.Text)) //if unsafe
		{
		    finalURLTextbox.Text = "https=://youhavebeenowned.com/";
		    CommentsTextBox.Text = "user: techwiz47" + Environment.NewLine + Environment.NewLine + "The website is really malicious and even got my grandfathers information do yourself a favor and don't click anything.";

		}
		else
		{
		    finalURLTextbox.Text = urlTextbox.Text;
		    CommentsTextBox.Text = "user: Admin" + Environment.NewLine + Environment.NewLine + "Due to the matrix algorithm on the backend of our site, virustotals views the website as a safe website to visit.";
		}
	    }
	}

	// button click events under here are for showing the various details between the safe and non safe urls
	private void urlDetailsbtn_Click(object sender, EventArgs e)
	{
	    urlDetailsPanel.Visible = true;
	}

	private void ScanAgainButton_Click(object sender, EventArgs e)
	{
	    fileScanTextBox.Clear();
	    selectedFile = null;
	    urlEntry.Clear();
	    urlResultsPanel.Visible = false;
	    urlDetailsPanel.Visible = false;
	    HomePanel.Visible = true;
	}

	private void SelectFileButton_Click(object sender, EventArgs e)
	{
	    Form_SelectFile formSelectFile = new Form_SelectFile();

	    if (formSelectFile.ShowDialog() == DialogResult.OK)
	    {
		// if select was pressed
		fileScanTextBox.Text = Form_SelectFile.selectedFile.Text;
		selectedFile = Form_SelectFile.selectedFile;
	    }
	}

	private void fileScanner_Click(object sender, EventArgs e)
	{
	    if (selectedFile != null)
	    {
		HomePanel.Visible = false;
		fileResultsPanel.Visible = true;
		selectedFileName.Text = selectedFile.Text;
		selectedFileType.Text = selectedFile.SubItems[1].Text;

		Class_File fileDetails = (Class_File)selectedFile.Tag;
		if (fileDetails.IsMalicious == true)
		{
		    MaliciousPic.Visible = true;
		    SafePic.Visible = false;
		    isMaliciousLBL.Text = "File appears to be malicious according database results";
		}
		else
		{
		    MaliciousPic.Visible = false;
		    SafePic.Visible = true;
		    isMaliciousLBL.Text = "File appears to be safe according database results";
		}
	    }
	}

	private void fileScanButton_Click(object sender, EventArgs e)
	{
	    urlScanPanel.Visible = false;
	    fileScanPanel.Visible = true;
	}
    }
}
