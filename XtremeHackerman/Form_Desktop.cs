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

	private void Form_Desktop_Load(object sender, EventArgs e)
	{
	    BackgroundRefresh();
	    desktopBootOptions();
	}

	private void desktopBootOptions()
	{   // This function will handle enabling/disabling certain settings based on Boot Options

	    //// Relect the wifi icon on or off as defined by the system boot options
	    if (BootOptions.enableNetworking == false)
	    {
		toolbarNetworkBTN.Image = Resources.Wifi_Off;
	    }
	    else
	    {
		toolbarNetworkBTN.Image = Resources.Wifi_On;
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
	    //update completed stepsView
	    if (Class_Progress.Percent <= 10) //no steps done
	    {
		StepsView.Items[0].Text = "Step 1:";
		StepsView.Items[0].ImageIndex = 0;
		StepsView.Items[1].Text = "Step 2:";
		StepsView.Items[1].ImageIndex = 0;
		StepsView.Items[2].Text = "Step 3:";
		StepsView.Items[2].ImageIndex = 0;
		StepsView.Items[3].Text = "Step 4:";
		StepsView.Items[3].ImageIndex = 0;
		StepsView.Items[4].Text = "Step 5:";
		StepsView.Items[4].ImageIndex = 0;
	    }
	    else
	    {
		if (Class_Progress.Percent >= 28) //step 1 done
		{
		    StepsView.Items[0].Text = Class_Progress.Steps[0];
		    StepsView.Items[0].ImageIndex = 2;
		}
		if (Class_Progress.Percent >= 46) // step 2 done
		{
		    StepsView.Items[1].Text = Class_Progress.Steps[1];
		    StepsView.Items[1].ImageIndex = 2;
		}
		if (Class_Progress.Percent >= 64) //step 3 done
		{
		    StepsView.Items[2].Text = Class_Progress.Steps[2];
		    StepsView.Items[2].ImageIndex = 2;
		}
		if (Class_Progress.Percent >= 82) //step 4 done
		{
		    StepsView.Items[3].Text = Class_Progress.Steps[3];
		    StepsView.Items[3].ImageIndex = 2;
		}
		if (Class_Progress.Percent == 100) //step 5 done
		{
		    StepsView.Items[4].Text = Class_Progress.Steps[4];
		    StepsView.Items[4].ImageIndex = 2;
		}
	    }
	    //update completed events
	    if (eventLBL.Text == "Ransomware")
	    {
		CompletedEventsList.Text = "Phishing Email";
	    }
	    else if (eventLBL.Text == "You Win!")
	    {
		CompletedEventsList.Text = "Phishing Email\nRansomware";
	    }

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
	    MessageBox.Show(Class_Progress.Hints[step]);
	}

	private void toolbarNetworkBTN_Click(object sender, EventArgs e)
	{
	    // If the network Icon shows that the network is currently on
	    if (BootOptions.enableNetworking == true)
	    {
		// Change the public status of the network to off
		BootOptions.enableNetworking = false;
		// Change the network icon to the 'Wifi Off'
		toolbarNetworkBTN.Image = Resources.Wifi_Off;
	    }
	    // If the network icon shows that the network is currently off
	    else
	    {
		// Change the public status of the network on on
		BootOptions.enableNetworking = true;
		// Change the network icon to the 'Wifi On' icon
		toolbarNetworkBTN.Image = Resources.Wifi_On;
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
	    Class_Progress.StepCompleted("Ransomware", 2); //step two completed
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

	    if (BootOptions.enableCommandPrompt == false)
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

	private void eventLBL_DoubleClick(object sender, EventArgs e)
	{
	    if (eventLBL.Text == "Phishing Email")
		MessageBox.Show("\"Phishing is a type of online scam where criminals send an email that appears to be from a legitimate company and ask you to provide sensitive information. This is usually done by including a link that will appear to take you to the company’s website to fill in your information – but the website is a clever fake and the information you provide goes straight to the crooks behind the scam.\n\nThe term ’phishing’ is a spin on the word fishing, because criminals are dangling a fake ’lure’ (the email that looks legitimate, as well as the website that looks legitimate) hoping users will ’bite’ by providing the information the criminals have requested – such as credit card numbers, account numbers, passwords, usernames, and more.\"\n\n - WebRoot.com");

	    if (eventLBL.Text == "Ransomware")
		MessageBox.Show("\"Ransomware is a type of malicious software (or “malware”) that infects computers, then encrypts various files and demands a ransom to get them back. Even if you pay the money within the timeframe the criminals set, there’s no guarantee you’ll get your files back. Typical ransoms are at least $500, but some of them ask for much more (particularly if they hit a larger business that can’t function without immediate and reliable access to its data, such as a hospital.\"\n\n - Webroot.com");
	}
    }
}
