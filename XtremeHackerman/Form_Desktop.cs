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
	public static Form_FileManager formFileManager; //declare my form once -KN

        public Form_Desktop()
        {
            InitializeComponent();
            desktopBootOptions();
	}

        private void Form_Desktop_Load(object sender, EventArgs e)
        {
	    // LOADING THE DESKTOP
	    formFileManager = new Form_FileManager(); //declare my form once -KN
	}

        private void searchEntry(object sender, EventArgs e)
        {
            // Search bar implementation
        }

        private void internetExplorerClick(object sender, EventArgs e)
        {
            var formInternetBrowser = new Form_InternetBrowser();
            formInternetBrowser.ShowDialog();
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
	    formFileManager.ShowDialog();
    }

        private void cliButtonClick(object sender, EventArgs e)
        {
	    // Command Line implementation

            if (Desktop_BKEND.CMD_ON == false)
            {
                const string message = "Command Prompt Access Restricted in Current Boot Options.";
                var result = MessageBox.Show(message);
                return;
                
            }
	        var formCLI = new Form_CLI();
            formCLI.ShowDialog();
        }

        private void emailButtonClick(object sender, EventArgs e)
        {

            // Email Browser implementation 
            //Form_Email Test = new Form_Email();
            //Test.Show();
            var formEmail = new Form_Email();
            formEmail.ShowDialog();
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
            formInternetBrowser.ShowDialog();
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {
            const string message = "You have opened the Task Manager";
            var result = MessageBox.Show(message);
        }

        private void FileManager_Click(object sender, EventArgs e)
        {
	    formFileManager.ShowDialog();
	}

        private void label1_Click(object sender, EventArgs e)
        {

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
            formRansomware.ShowDialog();
        }

        private void desktopBootOptions()
        {   // This function will handle enabling/disabling certain settings based on Boot Options
            
            //Disables the Background when in SAFE MODE
            if(BootOptions.enableSafeMode == true)
            {
                BackgroundImage = null;
                BackColor = Color.Black;
            }
            
            // Enables or disables Network access as defined by the system boot options 
            if(BootOptions.enableNetworking == false)
            {
                Desktop_BKEND.net_ON = false;
                toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon_OFF;
            }

            // Enables or disables CMD access as defined by the system boot options
            if(BootOptions.enableCommandPrompt == false)
            {
                Desktop_BKEND.CMD_ON = false;
            }
        }

        private void DesktopPermissions_Tick(object sender, EventArgs e)
        { // This simple Tick will refresh the permissions of the Desktop form over time 
            desktopBootOptions();
        }
    }
}
