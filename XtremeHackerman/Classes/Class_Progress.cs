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
	public static string[] Hints; //list of hints

	public static string[] PhishSteps = new string[]
	{
	    "Inspect Email",
	    "Open Internet",
	    "Visit Firewall.com",
	    "Open Domain Tab",
	    "Block Email Domain"
	};

	public static string[] PhishHints = new string[]
	{
	    "Why do I keep getting so many emails?",
	    "Maybe I should check online.",
	    "How do I put a wall between me and these emails?",
	    "What's that thing called after the @ sign in an email?",
	    "There has to be a way to block this person!"
	};

	public static string[] RansomwareSteps = new string[]
	{
	    "Open Start Menu",
	    "Logoff or Restart",
	    "Enable Safemode",
	    "Open Antivirus",
	    "Remove All Threats"
	};

	public static string[] RansomwareHints = new string[]
	{
	    "Where did all the icons go! What else can I click?",
	    "What happens if I ",
	    "This thing looks dangerous. What's the opposite of dangerous?",
	    "Maybe I should scan my computer for bad things.",
	    "OMG! There's a virus on my computer! Kill it!!!"
	};


	public void Play()
	{
	    /*** FIRST EVENT: PHISHING EMAIL ***/
	    ActiveEvent = "Phishing Email";
	    Percent = 10;
	    Steps = PhishSteps;
	    Hints = PhishHints;

	    EventLogic.PhishingEmailAttack(); // the first email

	    //Populate phishing email every 10 seconds
	    timer = new Timer();
	    timer.Tick += new EventHandler(timer_Tick);
	    timer.Interval = 10000; 
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
		    //Desktop_BKEND.Notification("You've completed Step " + step + "\n" + Steps[step-1], true);
		    MessageBox.Show("You've completed Step " + step + "\n" + Steps[step - 1]);
		}
		else if (step == 5 && Percent == 82)
		{
		    MessageBox.Show("You've completed Step " + step + "\n" + Steps[step - 1] + "\n\nYou have successfully recovered from: " + activeEvent);
		    Percent += 18;
		}
	    }

	    /*** SECOND EVENT: RANSOMWARE ***/
	    if (activeEvent == "Phishing Email" && Percent == 100)
	    {
		timer.Stop(); //stop populating phishing emails
		ActiveEvent = "Ransomware";
		Percent = 10; //begin at 10
		Steps = RansomwareSteps;
		Hints = RansomwareHints;
		EventLogic.RansomwareAttack();	   
	    }
	    /**********************************/

	    /*** THIRD EVENT:  Finished***/
	    if (activeEvent == "Ransomware" && Percent == 100)
	    {
		ActiveEvent = "You Win!";
		Percent = 0;
		Steps = null;
	    }
	    /**********************************/

	}
    }
}
