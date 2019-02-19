using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace XtremeHackerman
{
    public partial class Form_Desktop : Form
    {
        public Form_Desktop()
        {
            InitializeComponent();
        }

        private void Form_Desktop_Load(object sender, EventArgs e)
        {
            // LOADING THE DESKTOP
        }

        private void searchEntry(object sender, EventArgs e)
        {
            // Search bar implementation
        }

        private void internetExplorerClick(object sender, EventArgs e)
        {
            XtremeHackermanForms._formBrowser.ShowDialog();
        }




        private void explorerButtonClick(object sender, EventArgs e)
        {
            // Explorer button implementation
        }

        private void cliButtonClick(object sender, EventArgs e)
        {
            // Command Line implementation
        }

        private void emailButtonClick(object sender, EventArgs e)
        {
            // Email Browser implementation 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Desktop desktop = new Form_Desktop();

        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void internetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtremeHackermanForms._formBrowser.ShowDialog();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the Task Manager";
            var result = MessageBox.Show(message);
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the File Manager";
            var result = MessageBox.Show(message);
        }
    }
      
}
