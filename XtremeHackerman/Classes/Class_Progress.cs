using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman.Classes
{
    class Class_Progress
    {
	public static Timer timer;

	public static string ActiveEvent; //what the current event is
	public static int Percent; //how far user has completed steps
	public static string[] Steps; //list of recovery steps

	public static string[] PhishSteps = new string[]
	{
	    "Inspect Email",
	    "Open Internet",
	    "Visit Firewall.com",
	    "Open Domain Tab",
	    "Block Email Domain"
	};

	public static string[] RansomwareSteps = new string[]
	{
	    "Open Start Menu",
	    "Click Restart",
	    "Enable Safemode",
	    "Open Antivirus",
	    "Remove All Threats"
	};

	
	public void Play()
	{
	    /*** FIRST EVENT: PHISHING EMAIL ***/
	    ActiveEvent = "Phishing Email";
	    Percent = 10;
	    Steps = PhishSteps;

	    EventLogic.PhishingEmailAttack(); // the first email

	    //Populate phishing email every 15 seconds
	    timer = new Timer();
	    timer.Tick += new EventHandler(timer_Tick);
	    timer.Interval = 15000; 
	    timer.Start();
	    /**********************************/
	}

	private void timer_Tick(object sender, EventArgs e)
	{
	    EventLogic.PhishingEmailAttack();
	}

	public static void StepCompleted(string activeEvent, int step)
	{
	    //Only increment if the step completed was for the current event
	    if (activeEvent == ActiveEvent)
	    {
		// five steps, 18 points each
		// Make sure to only increment on the first time the step was compeleted
		if (step == 1 && Percent == 10 || step == 2 && Percent == 28 || step == 3 && Percent == 46 || step == 4 && Percent == 64)
		{
		    Percent += 18;
		    Desktop_BKEND.Notification("You've completed Step " + step + "\n" + Steps[step-1], true);
		}
		else if (step == 5 && Percent == 82)
		{
		}
	    }

	    /*** SECOND EVENT: RANSOMWARE ***/
	    if (activeEvent == "Phishing Email" && Percent == 100)
	    {
		timer.Stop(); //stop populating phishing emails
		ActiveEvent = "Ransomware";
		Percent = 10; //begin at 10
		Steps = RansomwareSteps;
		EventLogic.RansomwareAttack();	   
	    }
	    /**********************************/
	}
    }
}
