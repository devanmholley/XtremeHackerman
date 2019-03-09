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

namespace XtremeHackerman
{
    public partial class Firewall : Form
    {
        public Firewall()
        {
            InitializeComponent();
        }
        
        string[] ip = new string[20];
        
        
        private void Firewall_Load(object sender, EventArgs e)
        {
           permissionsPage.Hide();
            blockIP.Hide();
            homeButton1perm.Hide();
            blockIPwindow.Hide();
            ipEntry.Hide();
            pageMedian.Hide();
            rightArrowforip.Hide();
            
    }
        // The button for logout will close the window but not exit out of the total program. 
        private void Logout_Button(object sender, EventArgs e)
        {
            this.Close();
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

        private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            permissionsPage.Show();
            blockIP.Show();
            blockIPwindow.Show();
            homeButton1perm.Show();
            ipEntry.Show();
            pageMedian.Show();
            rightArrowforip.Show();
        }

        private void rightArrowforip_Click(object sender, EventArgs e)
        {

            testipWindow.Text = ipEntry.Text;
                      
        }

        private void ipEntry_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void ipYeahweblocked_Click(object sender, EventArgs e)
        {

        }

        private void blockIP_Click(object sender, EventArgs e)
        {

        }

        private void testipWindow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
