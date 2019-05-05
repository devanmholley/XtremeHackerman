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
		//Visit VirusTotals.com
		WebsitePanel.Visible = true;
		ErrorPanel.Visible = false;
		var formVirusTotal = new Form_VirusTotal();
		formVirusTotal.TopLevel = false;
		WebsitePanel.Controls.Add(formVirusTotal);
		formVirusTotal.Dock = DockStyle.Fill;
		AddressBar.Text = "virustotals.com";
		formVirusTotal.Show();
	    }
	    else if (AddressBar.Text == "firewall.com")
	    {
		//Visit Firewall
		WebsitePanel.Visible = true;
		ErrorPanel.Visible = false;
		var formFirewall = new Form_Firewall();
		formFirewall.TopLevel = false;
		WebsitePanel.Controls.Add(formFirewall);
		formFirewall.Dock = DockStyle.Fill;
		formFirewall.Show();
		AddressBar.Text = "firewall.com";
		Class_Progress.StepCompleted("Phishing Email", 3); //step three completed
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
        }

        private void companyFirewallToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void virusTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
	    //Visit VirusTotals.com
	    var formVirusTotal = new Form_VirusTotal();
	    formVirusTotal.TopLevel = false;
	    WebsitePanel.Controls.Add(formVirusTotal);
	    formVirusTotal.Dock = DockStyle.Fill;
	    AddressBar.Text = "virustotals.com";
	    formVirusTotal.Show();
	}
    }
}
