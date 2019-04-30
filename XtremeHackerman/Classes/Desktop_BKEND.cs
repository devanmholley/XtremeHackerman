using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeHackerman.Classes
{
    // A class to manage the backend processes of the desktop and toolbar
    class Desktop_BKEND
    {
        /// <summary>
        /// A 'global' variable of the current network status. The desktop
        /// assumes the default network status as 'On'.
        /// </summary>
        public static bool net_ON = true;

        /// <summary>
        /// A 'global' variable that defines access to the CMD. The desktop
        /// assumes the default network status as 'Enabled'.
        /// </summary>
        public static bool CMD_ON = true;
    }
}
