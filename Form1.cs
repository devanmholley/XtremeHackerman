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

namespace StartMenu
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {


        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the File Manager";
            var result = MessageBox.Show(message);
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the Task Manager";
            var result = MessageBox.Show(message);
        }

        private void internetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the Internet Browser";
            var result = MessageBox.Show(message); ;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
