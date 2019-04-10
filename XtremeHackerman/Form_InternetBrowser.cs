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
            var formLandingPage = new Form_LandingPage();
            formLandingPage.Show();
        }

        private void Form_InternetBrowser_Load(object sender, EventArgs e)
        {

        }

        private void virusTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            virusTotal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urlScan.Show();
        }

        //this the code behind making the button work for shifting between virus totals panels
        private void urlScanner_Click(object sender, EventArgs e)
        {
            
               if (safeUrls.Contains(urlEntry.Text))
                {
                    urlResults.Show();
                    urlTextbox.Text = "https://" + urlEntry.Text;
                    hostTextbox.Text = urlEntry.Text;
                }
               else
               {
                    safeUrlpanel.Show();
                    safe_url_Display_Txb.Text = "https://" + urlEntry.Text;
                    safe_url_Host_Txb.Text = urlEntry.Text;
                    safe_final_url_Txtb.Text = safe_url_Display_Txb.Text;
                }
              
            
                
        }
         // button click events under here are for showing the various details between the safe and non safe urls
        private void urlDetailsbtn_Click(object sender, EventArgs e)
        {
            urlDetailsview.Show();
        }

        private void safeurlDetailsbtn_Click(object sender, EventArgs e)
        {
            safe_URL_details_Pnl.Show();
        }

        private void url_home_Btn_Click(object sender, EventArgs e)
        {
            urlResults.Hide();
            virusTotal.Show();
        }

        private void safe_url_Btn_Click(object sender, EventArgs e)
        {
            safeUrlpanel.Hide();
            virusTotal.Show();
        }
    }
}
