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

	public static string ActiveEvent = "Phishing Email"; //what the current event is
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
	    "Enable Safe Mode",
	    "Open Antivirus",
	    "Remove All Threats"
	};

	public static string[] RansomwareHints = new string[]
	{
	    "Where did all the icons go! What else can I click?",
	    "I mean I only got three options.",
	    "This thing looks dangerous. What's the opposite of dangerous?",
	    "Maybe I should scan my computer for bad things.",
	    "OMG! There's a virus on my computer! Kill it!!!"
	};


	public static void Play()
	{
	    /*** FIRST EVENT: PHISHING EMAIL ***/
	    PhishSimulation();
	    /**********************************/
	}

	private static void timer_Tick(object sender, EventArgs e)
	{
	    EventLogic.PhishingEmailAttack();
	}

	public static void StepCompleted(string eventName, int step)
	{
	    //Only increment if the step completed was for the current event
	    if (eventName == ActiveEvent)
	    {
		// five steps, 20 points each
		// Make sure to only increment on the first time the step was compeleted
		if (step == 1 && Percent == 2) //offset, percent starts at 2
		{
		    Percent += 18;
		    //Desktop_BKEND.Notification("You've completed Step " + step + "\n" + Steps[step-1], true);
		    MessageBox.Show("You've completed Step " + step + "\n" + Steps[step - 1]);
		}
		else if (step == 2 && Percent == 20 || step == 3 && Percent == 40 || step == 4 && Percent == 60)
		{
		    Percent += 20;
		    //Desktop_BKEND.Notification("You've completed Step " + step + "\n" + Steps[step-1], true);
		    MessageBox.Show("You've completed Step " + step + "\n" + Steps[step - 1]);
		}
		else if (step == 5 && Percent == 80)
		{
		    MessageBox.Show("You've completed Step " + step + "\n" + Steps[step - 1] + "\n\nYou have successfully recovered from: " + eventName);
		    Percent += 20;
		}
	    }

	    /*** SECOND EVENT: RANSOMWARE ***/
	    if (eventName == "Phishing Email" && Percent == 100)
	    {
		timer.Stop(); //stop populating phishing emails
		RansomwareSimulation();
	    }
	    /**********************************/

	    /*** THIRD EVENT:  Finished***/
	    if (eventName == "Ransomware" && Percent == 100 && ActiveEvent != "Events Completed!")
	    {
		ActiveEvent = "Events Completed!";
		Steps = null;
		Hints = null;
		MessageBox.Show("Want to try again?\n\n Go to command prompt and type:\n\"PHISH%\" to try Phishing Email again or\n\"RANSOMWARE%\" to try Ransomware again.");
	    }
	    /**********************************/
	}

	public static void PhishSimulation()
	{
	    //if (Class_Firewall.blockedDomains.Contains)
	    ActiveEvent = "Phishing Email";
	    Percent = 2; //show on progress bar a little
	    Steps = PhishSteps;
	    Hints = PhishHints;

	    Class_Firewall.blockedDomains.Clear(); //clear domains

	    EventLogic.PhishingEmailAttack(); // the first email

	    //Populate phishing email every 10 seconds
	    timer = new Timer();
	    timer.Tick += new EventHandler(timer_Tick);
	    timer.Interval = 10000;
	    timer.Start();
	}

	public static void RansomwareSimulation()
	{
	    ActiveEvent = "Ransomware";
	    Percent = 2; //show on progress bar
	    Steps = RansomwareSteps;
	    Hints = RansomwareHints;
	    EventLogic.RansomwareAttack();
	}
    }
}
