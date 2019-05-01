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
        
        List<string> blacklistIPS = new List<string>(20);
        List<string> blacklistDomains = new List<string>(10);
        List<string> blacklistWebpages = new List<string>(15);

        private void Firewall_Load(object sender, EventArgs e)
        {

	}
        // The button for logout will close the window but not exit out of the total program. 
        private void Logout_Button(object sender, EventArgs e)
        {
	    FirewallSplitContainer.Visible = false;
	    LandingPanel.Visible = true;
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //top left panel 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // This is the code behind storing the ip addresses that can be called later 
        private void rightArrowforip_Click(object sender, EventArgs e)
        {
            blacklistIPS.Add(ipEntry.Text);
            testipWindow.Text = "";
            blacklistIPS.ForEach(i => testipWindow.Text += i + Environment.NewLine);
        }

        private void ipEntry_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void ipYeahweblocked_Click(object sender, EventArgs e)
        {

        }

        private void blockIP_Click(object sender, EventArgs e)
        {
            // Add the IP entered to the list of blocked IPs when clicked.
            // First, ensure that there is text in the box
            if (ipEntry.Text != "")
            {
                Class_Firewall.blockedIPs.Add(ipEntry.Text);
            }
            
        }

        private void testipWindow_TextChanged(object sender, EventArgs e)
        {

        }

        // Home button set to hide all the individual components
        private void homeButton_Click(object sender, EventArgs e)
        {
	    HomePanel.BringToFront();
        }

        // Will work with the Domain button to display the window for user email domain permissions 
        private void domainSwitch_Click(object sender, EventArgs e)
        {
	    DomainPanel.BringToFront();
        }

        private void domainADD_Click(object sender, EventArgs e)
        {
            blacklistDomains.Add(domainEntry.Text);
            domainEntered.Text = "";
            blacklistDomains.ForEach(i => domainEntered.Text += i + Environment.NewLine);
        }

        private void webpageUsage_Click(object sender, EventArgs e)
        {
	    webaccessPanel.BringToFront();
        }

        private void waccessInBtn_Click(object sender, EventArgs e)
        {
            blacklistWebpages.Add(waccessTextEntry.Text);
            waccessBLEntry.Text = "";
            blacklistWebpages.ForEach(i => waccessBLEntry.Text += i + Environment.NewLine);
        }
        //useless an idea i had that did not work out DJ 3/19
        private void waccessTextEntry_KeyDown(object sender, KeyEventArgs e)
        {

        }

	private void loginButton_Click(object sender, EventArgs e)
	{
	    LandingPanel.Visible = false;
	    FirewallSplitContainer.Visible = true;
	}

	private void blockedIps_Click(object sender, EventArgs e)
	{
	    blockIPPanel.BringToFront();

	}
    }
}
