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
        public string Name;
        public DateTime Spawntime;
        public DateTime StopTime;
       

        public Process()
        {
            Name = Application.OpenForms.ToString();
            Spawntime = DateTime.Now;

        }
    }
        
}
