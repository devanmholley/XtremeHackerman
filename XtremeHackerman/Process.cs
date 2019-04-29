using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeHackerman
{
    public class Process
    {
        public string Name;
        public DateTime Spawntime;
        public DateTime StopTime;

        public Process()
        {
            
            Spawntime = DateTime.Now;        

        }


    }
}
