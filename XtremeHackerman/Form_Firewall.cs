using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using XtremeHackerman.Classes;

namespace XtremeHackerman
{
    public partial class Form_Firewall : Class_BaseForm
    {
        public Form_Firewall()
        {
            InitializeComponent();
        }
        
        List<string> blacklistIPS = new List<string>();
        List<string> blacklistDomains = new List<string>();
        List<string> blacklistWebpages = new List<string>();

	private void loginButton_Click(object sender, EventArgs e)
	{
	    LandingPanel.Visible = false;
	    FirewallSplitContainer.Visible = true;
	}

	private void Firewall_Load(object sender, EventArgs e)
        {
	    HomePanel.BringToFront();
	}

	
	private void homeButton_Click(object sender, EventArgs e)
	{
	    // Home button go to welcome page
	    HomePanel.BringToFront();
	}

	private void Logout_Button(object sender, EventArgs e)
        {
	    // The button for logout will close the window but not exit out of the total program. 
	    FirewallSplitContainer.Visible = false;
	    LandingPanel.Visible = true;
        }

        // This is the code behind storing the ip addresses that can be called later 
        private void rightArrowforip_Click(object sender, EventArgs e)
        {
            blacklistIPS.Add(ipEntry.Text);
            testipWindow.Text = "";
            blacklistIPS.ForEach(i => testipWindow.Text += i + Environment.NewLine);
        }

        private void blockIP_Click(object sender, EventArgs e)
        {
            // Add the IP entered to the list of blocked IPs when clicked.
            // First, ensure that there is text in the box
        }

        
        private void domainSwitch_Click(object sender, EventArgs e)
        {
	    // Open Domain Tab
	    DomainPanel.BringToFront();
	    Class_Progress.StepCompleted("Phishing Email", 4); //step four completed
	}

        private void domainADD_Click(object sender, EventArgs e)
        {
            blacklistDomains.Add(domainEntry.Text);
            domainEntered.Text = "";
            blacklistDomains.ForEach(i => domainEntered.Text += i + Environment.NewLine);

	    if (domainEntered.Text != "")
	    {
		Class_Firewall.blockedDomains.Add(domainEntered.Text);
	    }

	    if (domainEntered.Text.Contains("fake"))
		Class_Progress.StepCompleted("Phishing Email", 5); //step five completed -> Phishing Event completed
	}

        private void webpageUsage_Click(object sender, EventArgs e)
        {
	    //Open Web Access Tab
	    webaccessPanel.BringToFront();
        }

        private void waccessInBtn_Click(object sender, EventArgs e)
        {
	    //Block Web Access
            blacklistWebpages.Add(waccessTextEntry.Text);
            waccessBLEntry.Text = "";
            blacklistWebpages.ForEach(i => waccessBLEntry.Text += i + Environment.NewLine);
        }

	private void blockedIps_Click(object sender, EventArgs e)
	{
	    //Block IPs Tab
	    blockIPPanel.BringToFront();
	}
    }
}
