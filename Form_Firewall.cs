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
       
	private void Firewall_Load(object sender, EventArgs e)
	{
	    LandingPanel.BringToFront();
	}

	private void loginButton_Click(object sender, EventArgs e)
	{
	    if (username_field.Text == "admin" && password_field.Text == "password")
	    {
		LandingPanel.Visible = false;
		FirewallSplitContainer.Visible = true;
		HomePanel.BringToFront();
	    }
	}

	private void homeButton_Click(object sender, EventArgs e)
	{
	    // Home button go to welcome page
	    HomePanel.BringToFront();
	}

	private void domainTab_Click(object sender, EventArgs e)
	{
	    // Open Domain Tab
	    DomainPanel.BringToFront();

	    blockedDomainsTB.Clear(); //clear
	    //show currently blocked domains
	    foreach (string domain in Class_Firewall.blockedDomains)
		blockedDomainsTB.Text += domain + Environment.NewLine;

	    Class_Progress.StepCompleted("Phishing Email", 4); //step four completed
	}

	private void webTab_Click(object sender, EventArgs e)
	{
	    //Open Web Access Tab
	    webaccessPanel.BringToFront();
	}

	private void ipTab_Click(object sender, EventArgs e)
	{
	    //Block IPs Tab
	    blockIPPanel.BringToFront();
	}

	private void Logout_Button(object sender, EventArgs e)
	{
	    // The button for logout will close the window but not exit out of the total program. 
	    FirewallSplitContainer.Visible = false;
	    LandingPanel.Visible = true;
	}

	/************* Block Buttons *************/
	private void addDomainButton_Click(object sender, EventArgs e)
	{
	    string domain = domainEntry.Text;
	    if (domain != "")
	    {
		if (domain.Contains("@"))
		{
		    string[] breakUpEmail = domain.Split('@');
		    domain = breakUpEmail[1];
		}
		Class_Firewall.blockedDomains.Add(domain);
		blockedDomainsTB.Text += domain + Environment.NewLine;
	    }

	    if (domain == "phi.sh")
		Class_Progress.StepCompleted("Phishing Email", 5); //step five completed -> Phishing Event completed
	}

	// This is the code behind storing the ip addresses that can be called later 
	private void addIPButton_Click(object sender, EventArgs e)
        {
            //blacklistIPS.Add(ipEntry.Text);
            //testipWindow.Text = "";
            //blacklistIPS.ForEach(i => testipWindow.Text += i + Environment.NewLine);
        }

        private void addWebButton_Click(object sender, EventArgs e)
        {
	    //Block Web Access
            //blacklistWebpages.Add(waccessTextEntry.Text);
            //waccessBLEntry.Text = "";
            //blacklistWebpages.ForEach(i => waccessBLEntry.Text += i + Environment.NewLine);
        }


    }
}
