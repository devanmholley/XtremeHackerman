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
    public partial class Form_Admin : Class_BaseForm
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
            var formInternetBrowser = new Form_InternetBrowser();
            formInternetBrowser.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formInternetBrowser = new Form_InternetBrowser();
            formInternetBrowser.ShowDialog();
        }
    }
}
