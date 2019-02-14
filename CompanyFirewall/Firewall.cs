using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyFirewall
{
    public partial class Firewall : Form
    {
        public Firewall()
        {
            InitializeComponent();
        }

        private void Firewall_Load(object sender, EventArgs e)
        {
           
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
    }
}
