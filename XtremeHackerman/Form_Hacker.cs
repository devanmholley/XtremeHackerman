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
	Form startup = new Form_HackerStartup();

	public Form_Hacker()
        {
            InitializeComponent();
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

	private void Form_Hacker_Load(object sender, EventArgs e)
	{
	    // Show the instructions at startup
	    startup.Show();
	}

	private void Form_Hacker_Shown(object sender, EventArgs e)
	{
	    startup.BringToFront();
	}
    }
}
