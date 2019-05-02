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
    public partial class Form_Anitvirus : Form
    {
        public Form_Anitvirus()
        {
            InitializeComponent();
        }

        private void antivirusScan_BTN_Click(object sender, EventArgs e)
        {
	    //When the scan button is clicked, hide the start screen.
	    //Show the scanning screen.
	    AntiVirus_scanPNL.BringToFront();

	    Class_Antivirus.ScanResults();
	    Header_LBL.Text += Class_Antivirus.MalwareList.Count(); //display number of threats

	    foreach (ListViewItem file in Class_Antivirus.MalwareList)
	    {
		malwareListBox.Items.Add(file.Text); //show up in UI
	    }

	    if (Class_Antivirus.MalwareList.Count() == 0)
	    {
		removeButton.Enabled = false;
	    }
	}

	private void removeButton_Click(object sender, EventArgs e)
	{
	    foreach (ListViewItem malware in Class_Antivirus.MalwareList)
		if (malware.Text == "not ransomware")
		    Class_Progress.StepCompleted("Ransomware", 5); //step five completed -> Ransomware Event completed
	    Class_Antivirus.RemoveAllThreats();
	    malwareListBox.Items.Clear(); //delete in UI
	}
    }
}
