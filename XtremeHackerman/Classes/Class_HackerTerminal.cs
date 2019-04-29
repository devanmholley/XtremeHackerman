using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeHackerman.Classes
{
    class Class_HackerTerminal
    {
        // Root_Password keeps track of the current root password
        private static string Root_password;

        // Command History keeps a list of previous commands so we can
        // filter back through them
        public static List<String> CommandHistory;

        // If IP forwarding is set to true then see the setting as enabled.
        public static bool ipforwarding;

        // The UserIP object keeps track of the IP of the user on that instance
        // of the terminal. It's not static since multiple terminals can have 
        // unique IPs.
        public static string UserIP;
        public string wirelessModule = "";

        public void Set_Password()
        {
        }

        // Check that the given password is equal to the root password
        public static bool Check_Pass(string password)
        {
            if(password == Root_password)
            {
                return true;
            }
            return false;
        }

    }
}
