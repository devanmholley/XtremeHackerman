using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeHackerman.Classes
{
    public static class Class_Firewall
    {
        // The firewall contains the variable for IPs and maintains a list of
        // blocked IPs.
        public static string IP;
        public static List<String> blockedIPs = new List<String>();
    }
}
