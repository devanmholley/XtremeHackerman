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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Internet_Click(object sender, EventArgs e)
        {
            XtremeHackermanForms._formBrowser.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtremeHackermanForms._formBrowser.ShowDialog();
        }
    }
}
