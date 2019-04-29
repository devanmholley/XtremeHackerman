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
	    Header_LBL.Text += Class_Antivirus.malwares.Count(); //display number of threats

	    foreach (ListViewItem file in Class_Antivirus.malwares)
	    {
		malwareListBox.Items.Add(file.Text); //show up in UI
	    }
	}

	private void removeButton_Click(object sender, EventArgs e)
	{
	    foreach (ListViewItem malware in Class_Antivirus.malwares) //delete files from dictionary
		malware.Remove();
	    malwareListBox.Items.Clear(); //delete in UI
	}
    }
}
