using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using XtremeHackerman.Classes;
using XtremeHackerman.Properties;

namespace XtremeHackerman
{
    public partial class Form_Desktop : Class_BaseForm
    {
        public Form_Desktop()
        {
            InitializeComponent();
	}

        private void internetExplorerClick(object sender, EventArgs e)
        {
            var formInternetBrowser = new Form_InternetBrowser();
            formInternetBrowser.Show();
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

        private void FileManagerButtonClick(object sender, EventArgs e)
        {
	    // FileManager icon button implementation
	    var formFileManager = new Form_FileManager();
	    formFileManager.Show();
    }

        private void cliButtonClick(object sender, EventArgs e)
        {
	    // Command Line implementation
	    var formCLI = new Form_CLI();
            formCLI.Show();
        }

        private void emailButtonClick(object sender, EventArgs e)
        {

            // Email Browser implementation 
            //Form_Email Test = new Form_Email();
            //Test.Show();
            var formEmail = new Form_Email();
            formEmail.Show();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InternetBrowser_Click(object sender, EventArgs e)
        {
            var formInternetBrowser = new Form_InternetBrowser();
            formInternetBrowser.Show();
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the Task Manager";
            var result = MessageBox.Show(message);
        }

        private void FileManager_Click(object sender, EventArgs e)
        {
	    var formFileManager = new Form_FileManager();
	    formFileManager.Show();
	}

        private void toolbarNetworkBTN_Click(object sender, EventArgs e)
        {
            // If the network Icon shows that the network is currently on
            if (Desktop_BKEND.net_ON)
            {
                // Change the network icon to the 'Wifi Off' icon
                toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon_OFF;
                // Change the public status of the network to off
                Desktop_BKEND.net_ON = false;
            }
            // If the network icon shows that the network is currently off
            else
            {
                // Change the network icon to the 'Wifi on; icon
                toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon;
                // Change the public status of the network on on
                Desktop_BKEND.net_ON = true;
            }
        }

        private void Btn_Ransom_Debug_Click(object sender, EventArgs e)
        {
            /// This is JUST a debug button for doing testing on the Ransomware Form.
            /// It should be Deleted or Hidden When the Ransomware event is added.
            var formRansomware = new Form_Ransomware();
            formRansomware.Show();
        }

	private void Form_Desktop_FormClosing(object sender, FormClosingEventArgs e)
	{
	    //Close any forms that open if Desktop is closed
	    //Code Attribution: https://stackoverflow.com/questions/9029351/close-all-open-forms-except-the-main-menu-in-c-sharp
	    List<Form> openForms = new List<Form>();

	    foreach (Form f in Application.OpenForms)
		openForms.Add(f);

	    foreach (Form f in openForms)
	    {
		if (f.Name != "Form_Desktop" && f.Name != "Form_TitleScreen")
		{
		    f.Close();
		}
	    }

	}
    }
}
