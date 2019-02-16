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

        private void startButtonClick(object sender, EventArgs e)
        {
            // Start button implementation 
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
    }
}
