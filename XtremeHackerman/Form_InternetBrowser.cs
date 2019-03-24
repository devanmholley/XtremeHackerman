using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman
{
    public partial class FormInternetBrowser : Form
    {
        public FormInternetBrowser()
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
            XtremeHackermanForms.FormLandingPage.Show();
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
    }
}
