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

	string[] PhishSteps = new string[]
	{
	    "Step 1: Inspect Email",
	    "Step 2: Open Internet",
	    "Step 3: Visit Firewall.com",
	    "Step 4: Block Email Domain"
	};

	
	public void Play()
	{
	    /*** FIRST EVENT: PHISHING EMAIL ***/
	    ActiveEvent = "Phising Email";
	    Percent = 10;
	    Steps = PhishSteps;

	    EventLogic.PhishingEmailAttack(); // the first email

	    //Populate phishing email every 5 seconds
	    timer = new Timer();
	    timer.Tick += new EventHandler(timer_Tick);
	    timer.Interval = 5000; 
	    timer.Start();
	    /**********************************/
	}

	private void timer_Tick(object sender, EventArgs e)
	{
	    EventLogic.PhishingEmailAttack();
	}
    }
}
