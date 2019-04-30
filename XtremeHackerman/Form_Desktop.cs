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
            desktopBootOptions();
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
            formEmail.Show();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            RestartBootOptions.ContextMenu = new ContextMenu();
            RestartBootOptions.Show(Cursor.Position);
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

	private void Antivirus_Click(object sender, EventArgs e)
	{
	    var formAntivirus = new Form_Anitvirus();
	    formAntivirus.Show();
	}

        private void desktopBootOptions()
        {   // This function will handle enabling/disabling certain settings based on Boot Options
            
            //Disables the Background when in SAFE MODE
            if(BootOptions.enableSafeMode == true)
            {
                BackgroundImage = null;
                BackColor = Color.Black;
            }
            //// Enables or disables Network access as defined by the system boot options 
            //if(BootOptions.enableNetworking == false)
            //{
            //    Desktop_BKEND.net_ON = false;
            //    toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon_OFF;
            //}

            // Enables or disables CMD access as defined by the system boot options
            if(BootOptions.enableCommandPrompt == false)
            {
                Desktop_BKEND.CMD_ON = false;
            }
            else
            {
                Desktop_BKEND.CMD_ON = true;
            }
        }

        private void DesktopPermissions_Tick(object sender, EventArgs e)
        { // This simple Tick will refresh the permissions of the Desktop form over time 
            desktopBootOptions();
        }

        private async void restartNoChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Handles simulation of a restart in the Desktop form by hiding the form for a few frames, updating, and then making it visible again
            BootOptions.enableSafeMode = false;
            BootOptions.enableNetworking = true;
            BootOptions.enableCommandPrompt = false;
            this.Opacity = 0;
            await Task.Delay(300);
            desktopBootOptions();
            BackgroundImage = Resources.Background_Desktop;
            this.Opacity = 100;
            RestartBootOptions.Close();
            
        }

        private async void safeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Handles simulation of a restart (Safe Mode) in the Desktop form by hiding the form for a few frames, updating, and then making it visible again
            BootOptions.enableSafeMode = true;
            BootOptions.enableNetworking = false;
            BootOptions.enableCommandPrompt = true;
            this.Opacity = 0;
            await Task.Delay(300);
            desktopBootOptions();
            this.Opacity = 100;
            RestartBootOptions.Close();
        }
    }
}
