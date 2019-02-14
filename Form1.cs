using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Restart.Visible = true;
            Shutdown.Visible = true;
            AdminFileManager.Visible = true;
            TaskManager.Visible = true;
            InternetBrowser.Visible = true;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            
            
        }
   
        private void Shutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminFileManager_Click(object sender, EventArgs e)
        {
            const string message = "This is the File Manager";
            var result = MessageBox.Show(message);
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {
            const string message = "This is the Task Manager";
            var result = MessageBox.Show(message);
        }

        private void InternetBrowser_Click(object sender, EventArgs e)
        {
            const string message = "You have entered the Internet Browser";
            var result = MessageBox.Show(message);
        }
    }
}
