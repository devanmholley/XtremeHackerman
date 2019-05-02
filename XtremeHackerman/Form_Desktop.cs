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

	private void Form_Desktop_Load(object sender, EventArgs e)
	{
	    eventLBL.Text = Class_Progress.ActiveEvent;
	    eventProgress.Value = Class_Progress.Percent;

	    if (eventLBL.Text == "Ransomware")
	    {
		RansomwareAttack();
	    }
		

	    toolbarTime.Text = DateTime.Now.ToString("h:mm tt");
	    toolbarDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
	    RealTime.Start();
	}

	private void internetExplorerClick(object sender, EventArgs e)
	{
	    var formInternetBrowser = new Form_InternetBrowser();
	    formInternetBrowser.Show();
	}

	private void startButtonClick(object sender, EventArgs e)
	{
	    //Display Start Menu
	    if (StartMenuPanel.Visible == false)
	    {
		StartMenuPanel.Visible = true;
	    }
	    else
	    {
		StartMenuPanel.Visible = false;
	    }
	}

	private void FileManagerButtonClick(object sender, EventArgs e)
	{
	    // FileManager icon button implementation
	    var formFileManager = new Form_FileManager();
	    formFileManager.Show();

	    Desktop_BKEND.Notification("hell yeah");
	}

	private void commandIconClick(object sender, EventArgs e)
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

	private void Form_Desktop_FormClosing(object sender, FormClosingEventArgs e)
	{
	    Desktop_BKEND.CloseOpenForms();
	    StartMenuPanel.Visible = false;
	    RansomwarePanel.Visible = false;
	}

	private void Antivirus_Click(object sender, EventArgs e)
	{
	    var formAntivirus = new Form_Anitvirus();
	    formAntivirus.Show();
	}

	private void desktopBootOptions()
	{   // This function will handle enabling/disabling certain settings based on Boot Options

	    //Disables the Background when in SAFE MODE
	    if (BootOptions.enableSafeMode == true)
	    {
		BackgroundImage = null;
		BackColor = Color.Black;

		
		RansomwarePanel.Visible = false; //disable ransomware
		ProgressPanel.BackColor = Color.Black; //progress panel match the ransomware bg
		StartMenuPanel.BackColor = Color.Black; //startmenu panel match the ransomware bg
	    }
	    //// Enables or disables Network access as defined by the system boot options 
	    //if(BootOptions.enableNetworking == false)
	    //{
	    //    Desktop_BKEND.net_ON = false;
	    //    toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon_OFF;
	    //}

	    // Enables or disables CMD access as defined by the system boot options
	    if (BootOptions.enableCommandPrompt == false)
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

	private void RealTime_Tick(object sender, EventArgs e)
	{
	    toolbarTime.Text = DateTime.Now.ToString("h:mm tt"); //update real time every 10 seconds
	}

	private void WiresharkIcon_Click(object sender, EventArgs e)
	{
		var formWireshark = new Form_Wireshark();
		formWireshark.ShowDialog();
	}
	
	public void RansomwareAttack()
	{
	    Desktop_BKEND.CloseOpenForms(); //close all open forms

	    //Set Ransomwareform to desktop background
	    RansomwarePanel.Visible = true;
	    var formRansomware = new Form_Ransomware();
	    formRansomware.TopLevel = false;
	    RansomwarePanel.Controls.Add(formRansomware);
	    formRansomware.Dock = DockStyle.Fill;
	    formRansomware.Show();
	    RansomwarePanel.BringToFront();

	    eventLBL.Text = Class_Progress.ActiveEvent;
	    eventProgress.Value = Class_Progress.Percent;
	    ProgressPanel.BackColor = Color.Red; //progress panel match the ransomware bg
	    StartMenuPanel.BackColor = Color.Red; //startmenu panel match the ransomware bg
	    StartMenuPanel.BringToFront(); //allow user to still access start menu to boot into safe mode
	}

	private void LogOut_Click(object sender, EventArgs e)
	{
	    Desktop_BKEND.CloseOpenForms();
	    StartMenuPanel.Visible = false;
	    RansomwarePanel.Visible = false;
	    Close();
	}

	private void RansomwareIcon_Click(object sender, EventArgs e)
	{
	    EventLogic.RansomwareAttack();
	}
    }
}
