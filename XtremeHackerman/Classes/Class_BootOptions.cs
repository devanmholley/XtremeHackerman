using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeHackerman.Classes
{
    public static class BootOptions
    {
        // This is a class in charge of handling the tracking various boot options of the system
        // Several forms will reference these values in order to enable/disable features based on the current listed boot options

        public static bool enableSafeMode = false; // Enables or Disables safe mode on boot
        public static bool enableNetworking = true; // Enables or Disables the Networking features of the program
	public static bool enableCommandPrompt = true; // Enables or Disables the Networking features of the program 
    }
}
