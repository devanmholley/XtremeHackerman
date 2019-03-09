﻿using System;
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
            XtremeHackermanForms.FormBrowser.ShowDialog();
        }

        private void startButtonClick(object sender, EventArgs e)
        {
            
            bool i = ! Restart.Visible;
            if (i == true)
            {
                Restart.Visible = true;
                Shutdown.Visible = true;
                InternetBrowser.Visible = true;
                FileManager.Visible = true;
                TaskManager.Visible = true;
                EmailClient.Visible = true;
            }
            else 
            {
                Restart.Visible = false;
                Shutdown.Visible = false;
                InternetBrowser.Visible = false;
                FileManager.Visible = false;
                TaskManager.Visible = false;
                EmailClient.Visible = false;
            }
                

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
            //FormEmail Test = new FormEmail();
            //Test.Show();
            XtremeHackermanForms.FormEmail.Show();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Close();
            Form_Desktop desktop = new Form_Desktop();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InternetBrowser_Click(object sender, EventArgs e)
        {
            XtremeHackermanForms.FormBrowser.ShowDialog();
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the Task Manager";
            var result = MessageBox.Show(message);
        }

        private void FileManager_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the File Manager";
            var result = MessageBox.Show(message);
        }
    }
}
