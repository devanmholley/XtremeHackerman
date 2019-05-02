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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // code for "begin search here" button
            errorLabel.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Code for go-back button
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // code for go-forward button
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // code for refresh button
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // code for home button here
        }

        private void companyFirewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFirewall = new Form_Firewall();
	    formFirewall.TopLevel = false;
	    WebsitePanel.Controls.Add(formFirewall);
	    formFirewall.Dock = DockStyle.Fill;
	    formFirewall.Show();
	    Class_Progress.StepCompleted("Phishing Email", 3); //step three completed
	}

        private void Form_InternetBrowser_Load(object sender, EventArgs e)
        {

        }

        private void virusTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
	    var formVirusTotal = new Form_VirusTotal();
	    formVirusTotal.TopLevel = false;
	    WebsitePanel.Controls.Add(formVirusTotal);
	    formVirusTotal.Dock = DockStyle.Fill;
	    formVirusTotal.Show();
	}
    }
}
