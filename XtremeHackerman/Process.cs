using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman
{
    class Process
    {
	public static List<Process> tasks = new List<Process>();
	public static List<Process> history = new List<Process>();

	public string Name;
        public DateTime Spawntime;
	public int Duration;
        public DateTime StopTime;
       

        public Process(string name, DateTime spawnTime)
        {
	    //Name = Application.OpenForms.ToString();
	    //Spawntime = DateTime.Now;
	    Name = name;
	    Spawntime = spawnTime;
        }

	public static void newProcess(string name, DateTime spawnTime)
	{
	    Process p = new Process(name, spawnTime);
	    tasks.Add(p);
	}
    }
        
}
