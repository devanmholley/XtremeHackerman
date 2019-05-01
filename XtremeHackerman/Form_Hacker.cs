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
    public partial class Form_Hacker : Class_BaseForm
    {
        public Form_Hacker()
        {
            InitializeComponent();
            // Show the instructions at startup
            Form startup = new Form_HackerStartup();
            startup.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        // Open a new terminal
        private void toolStripDropDownTerminal_Click(object sender, EventArgs e)
        {
            var formTerminal = new Form_HackerTerminal();
            formTerminal.Show();
        }

        private void toolStripDropDownShutdown_Click(object sender, EventArgs e)
        {
            // Shut down the program
            this.Close();
        }

        private void toolStripDropDownRestart_Click(object sender, EventArgs e)
        {

        }
    }
}
