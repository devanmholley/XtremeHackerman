using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

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

	/// <summary>
	/// Close all open forms upon exiting the Desktop and return back to title screen
	/// </summary>
	public static void CloseOpenForms()
	{
	    //Close any forms that are open if Desktop is closed, to go back to title screen
	    //Code Attribution: https://stackoverflow.com/questions/9029351/close-all-open-forms-except-the-main-menu-in-c-sharp
	    List<Form> openForms = new List<Form>();

	    foreach (Form f in Application.OpenForms)
		openForms.Add(f);

	    foreach (Form f in openForms)
	    {
		if (f.Name != "Form_Desktop" && f.Name != "Form_TitleScreen")
		{
		    f.Close();
		}
	    }
	}

	public static void Notification(string message)
	{
	    // Initialization of Notification Popup 
	    string messagetime = System.DateTime.Now.ToString("ddd  HH:mm:ss");
	    string messageBody = message;
	    var popupNotifier = new PopupNotifier();
	    popupNotifier.TitleText = messagetime;
	    popupNotifier.ContentText = messageBody;
	    popupNotifier.IsRightToLeft = false;
	    popupNotifier.BodyColor = Color.Purple;
	    popupNotifier.Delay = 10000;
	    popupNotifier.Popup();
	}
    }
}
