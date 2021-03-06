﻿using System;
using System.Windows.Forms;
using XtremeHackerman.Classes;

namespace XtremeHackerman
{
    public partial class Form_TitleScreen : Class_BaseForm
    {
        // Define byte[] VCRFont as an embedded resource, to be used for custom font formatting
        private readonly byte[] _vcrFont = Properties.Resources.VCR_OSD_MONO_1_001;
	public static Form_Desktop formDesktop = new Form_Desktop();
	
	public Form_TitleScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Run when TitleScreen is first loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_TitleScreen_Load(object sender, EventArgs e)
        {
            // Set font format for each button on page, but retain existing font size
            foreach(Control button in tableLayoutPanel_Buttons.Controls)
            {
                button.Font = Class_CustomFonts.GetFont(_vcrFont, button.Font.Size);
            }
        }

        /// <summary>
        /// Close TitlePage form. Will likely exit program as well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Hide current TitlePage instance (NOT closing it) and load Admin form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Admin_Click(object sender, EventArgs e)
        {
	    Hide();
            formDesktop.ShowDialog();
	}

        /// <summary>
        /// Hide current TitlePage instance (NOT closing it) and load Hacker form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Hacker_Click(object sender, EventArgs e)
        {
            Hide();
            var formHacker = new Form_Hacker();
            formHacker.ShowDialog();
        }
        /// <summary>
        /// Enables the selection of the Safe Mode Conext Menu upon click of the image button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void safeModeIconButton_MouseClick(object sender, MouseEventArgs e)
        {   
            if (e.Button is MouseButtons.Left)
            {
                safeModeContextStrip.ContextMenu = new ContextMenu();
                safeModeContextStrip.Show(Cursor.Position);
            }
        }

        private void safeModeContextStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void safeModeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Enable Safe Mode Usage 
            BootOptions.enableSafeMode = true;
	    Class_Progress.StepCompleted("Ransomware", 3); //step three completed
	}

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {   // Disallow Safe Mode Usage 
            BootOptions.enableSafeMode = false;

        }

        private void BootOptionsDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BootStatusSettings()
        {
            // This function is in charge of updating the statuses of the Boot Options and updating
            // their status in real time on the initial window


        }

        private void BootStatusTimer_Tick(object sender, EventArgs e)
        {
            // Safe Mode Settings
            if (BootOptions.enableSafeMode == true)
            {
                SafeModeStatus.Text = "Safe Mode: Enabled";
            }
            else
            {
                SafeModeStatus.Text = "Safe Mode: Disabled";
            }
            // Network Settings
            if (BootOptions.enableNetworking == true)
            {
                NetworkingStatus.Text = "Network: Enabled";
	    }
            else
            {
		NetworkingStatus.Text = "Network: Disabled";
	    }
            // Command Prompt Settings
            if (BootOptions.enableCommandPrompt == true)
            {
                CMDAccessStatus.Text = "Command Prompt Access: Enabled";
            }
            else
            {
                CMDAccessStatus.Text = "Command Prompt Access: Disabled";
            }
            
        }

        // Conext Menu Options for Network Persmissions
        private void enableToolStripMenuItem1_Click(object sender, EventArgs e)
        {   // Allow Network Usage
            BootOptions.enableNetworking = true;
        }
            // Disallow Network Usage 
        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BootOptions.enableNetworking = false;
        }

        // Context Menu Options for Command Prompt Access
        private void enableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BootOptions.enableCommandPrompt = true;
        }

        private void disableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BootOptions.enableCommandPrompt = false;
        }

	private void button_About_Click(object sender, EventArgs e)
	{
	    MessageBox.Show("Welcome to the Hacking and Recovery Simulator!\n\nOur objective is to assist training future system administrators and pentration testers."
		+ "\n\nTo begin practicing resolving cyber security attacks, click on the \"ADMIN\" button.\n\nTo begin practicing penetration testing by simulating cyber security attacks click on the \"HACKER\" button.");
	}

	private void securityOptionsToolStripMenuItem_Click(object sender, EventArgs e)
	{

	}
    }
}
