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
    public partial class Form_InternetBrowser : Class_BaseForm
    {
        List<string> safeUrls = new List<string>(15) { "viruses.com", "thebest.com" };
        public Form_InternetBrowser()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
	    if (AddressBar.Text == "virustotals.com")
	    {
		GoToWebsite("virustotals.com");
	    }
	    else if (AddressBar.Text == "firewall.com")
	    {
		GoToWebsite("firewall.com");
	    }
	    else
	    {
		//Error Page
		WebsitePanel.Visible = false;
		ErrorPanel.Visible = true;
	    }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Code for go-back button
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            // code for go-forward button
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            // code for refresh button
        }

        private void Home_Click(object sender, EventArgs e)
        {
	    // Visit Home
	    WebsitePanel.Visible = false;
	    ErrorPanel.Visible = false;
	    AddressBar.Text = "";
        }

        private void companyFirewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
	    //Visit Firewall
	    GoToWebsite("firewall.com");
	}


        private void virusTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {

	    //Visit VirusTotals.com
	    GoToWebsite("virustotals.com");
	}

	//simulate opening a website in internet browser
	private void GoToWebsite(string website)
	{
	    WebsitePanel.Visible = true;
	    ErrorPanel.Visible = false;

	    if (website == "firewall.com")
	    {
		//Visit Firewall
		var formFirewall = new Form_Firewall();
		formFirewall.TopLevel = false;
		WebsitePanel.Controls.Add(formFirewall);
		formFirewall.Dock = DockStyle.Fill;
		formFirewall.Show();
		AddressBar.Text = "firewall.com";
		Class_Progress.StepCompleted("Phishing Email", 3); //step three completed
	    }
	    else if (website == "virustotals.com")
	    {
		//Visit virustotals.com
		var formVirusTotal = new Form_VirusTotal();
		formVirusTotal.TopLevel = false;
		WebsitePanel.Controls.Add(formVirusTotal);
		formVirusTotal.Dock = DockStyle.Fill;
		AddressBar.Text = "virustotals.com";
		formVirusTotal.Show();
	    }
	    
	}
    }
}
