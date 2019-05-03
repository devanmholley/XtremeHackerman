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
	    //desktopBootOptions();
	}

	private void Form_Desktop_Load(object sender, EventArgs e)
	{
	    BackgroundRefresh();
	}

	private void desktopBootOptions()
	{   // This function will handle enabling/disabling certain settings based on Boot Options



	    //// Enables or disables Network access as defined by the system boot options 
	    if (BootOptions.enableNetworking == false)
	    {
		Desktop_BKEND.net_ON = false;
		toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon_OFF;
	    }
	    else
	    {
		Desktop_BKEND.net_ON = true;
		toolbarNetworkBTN.BackgroundImage = Resources.WifiIcon;		
	    }

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

	private void RefreshTimer_Tick(object sender, EventArgs e)
	{
	    /*** Timer that refreshes things every second ***/
	   
	    //This simple Tick will refresh the permissions of the Desktop form over time 
	    //desktopBootOptions();

	    //Update Event Progress
	    eventLBL.Text = Class_Progress.ActiveEvent;
	    eventProgress.Value = Class_Progress.Percent;

	    //Update Date and Time
	    toolbarTime.Text = DateTime.Now.ToString("h:mm tt");
	    toolbarDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
	}

	public void BackgroundRefresh()
	{
	    //Disables the Background when in SAFE MODE
	    if (BootOptions.enableSafeMode == true)
	    {
		//SafeMode Background
		BackgroundImage = null;
		BackColor = Color.Black;
		IconsPanel.Visible = true;
		RansomwarePanel.Visible = false; 
		ProgressPanel.BackColor = Color.Black; //progress panel match the ransomware bg
		StartMenuPanel.BackColor = Color.Black; //startmenu panel match the ransomware bg
	    }
	    else if (Class_Progress.ActiveEvent == "Ransomware" && BootOptions.enableSafeMode == false)
	    {
		//Ransomware Background
		IconsPanel.Visible = false;
		RansomwarePanel.Visible = true;
		ProgressPanel.BackColor = Color.Red; //progress panel match the ransomware bg
		StartMenuPanel.BackColor = Color.Red; //startmenu panel match the ransomware bg
	    }
	    else
	    {
		//Regular Background
		BackgroundImage = Resources.Background_Desktop; //Regular Background
		IconsPanel.Visible = true;
		RansomwarePanel.Visible = false;
		ProgressPanel.BackColor = Color.Transparent; //progress panel match the ransomware bg
		StartMenuPanel.BackColor = Color.Transparent; //startmenu panel match the ransomware bg
	    }
	}

	private void HintButton_Click(object sender, EventArgs e)
	{
	    int step = 0;
	    if (Class_Progress.Percent == 10)
		step = 0;
	    else if (Class_Progress.Percent == 28)
		step = 1;
	    else if (Class_Progress.Percent == 46)
		step = 2;
	    else if (Class_Progress.Percent == 64)
		step = 3;
	    else if (Class_Progress.Percent == 82)
		step = 4;
	    MessageBox.Show(Class_Progress.Steps[step]);
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
	}

	/****************************************
	* START MENU STUFF
	* **************************************/

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

	    Class_Progress.StepCompleted("Ransomware", 1); //step one completed
	}

	private void LogOut_Click(object sender, EventArgs e)
	{
	    Desktop_BKEND.CloseOpenForms();
	    StartMenuPanel.Visible = false;
	    Close();
	}

	private void Restart_Click(object sender, EventArgs e)
	{
	    RestartBootOptions.ContextMenu = new ContextMenu();
	    RestartBootOptions.Show(Cursor.Position);
	    Class_Progress.StepCompleted("Ransomware", 2); //step two completed
	}

	private void Shutdown_Click(object sender, EventArgs e)
	{
	    Application.Exit();
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
	    this.Opacity = 100;
	    RestartBootOptions.Close();
	    BackgroundRefresh();
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
	    BackgroundRefresh();
	    Class_Progress.StepCompleted("Ransomware", 3); //step three completed
	}

	/****************************************
	* ICON STUFF
	* **************************************/
	private void CommandIcon_Click(object sender, EventArgs e)
	{
	    // Command Line implementation

	    if (Desktop_BKEND.CMD_ON == false)
	    {
		const string message = "Command Prompt Access Restricted in Current Boot Options.";
		var result = MessageBox.Show(message);
		return;

	    }
	    var formCLI = new Form_CLI();
	    formCLI.Show();

	    Process.newProcess("Command Prompt", DateTime.Now);
	}
	private void InternetIcon_Click(object sender, EventArgs e)
	{
	    var formInternetBrowser = new Form_InternetBrowser();
	    formInternetBrowser.Show();
	    Class_Progress.StepCompleted("Phishing Email", 2); //step two completed
	    Process.newProcess("Internet Browser", DateTime.Now);
	}

	private void EmailIcon_Click(object sender, EventArgs e)
	{
	    var formEmail = new Form_Email();
	    formEmail.Show();
	    Process.newProcess("Email Client", DateTime.Now);
	}

	private void FileManagerIcon_Click(object sender, EventArgs e)
	{
	    // FileManager icon button implementation
	    var formFileManager = new Form_FileManager();
	    formFileManager.Show();
	    Process.newProcess("File Explorer", DateTime.Now);
	}

	private void Antivirus_Click(object sender, EventArgs e)
	{
	    var formAntivirus = new Form_Anitvirus();
	    formAntivirus.Show();
	    Class_Progress.StepCompleted("Ransomware", 4); //step four completed
	    Process.newProcess("Best Antivirus", DateTime.Now);
	}

	private void WiresharkIcon_Click(object sender, EventArgs e)
	{
	    var formWireshark = new Form_Wireshark();
	    formWireshark.ShowDialog();
	    Process.newProcess("Network Analyzer", DateTime.Now);
	}

	private void TaskManagerIcon_Click(object sender, EventArgs e)
	{
	    var formTaskManager = new Form_TaskManager();
	    formTaskManager.ShowDialog();
	    Process.newProcess("Task Manager", DateTime.Now);
	}
    }
}
