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

	/// <summary>
	/// Desktop Popup Notification Message
	/// </summary>
	/// <param name="message"></param>
	public static void Notification(string message)
	{
	    //Do Not show notifcations on titlescreen
	    if (Application.OpenForms.Count == 1 && Application.OpenForms[0].Name == "Form_TitleScreen")
		return;

	    string messagetime = System.DateTime.Now.ToString("ddd  h:mm tt"); //Display current time
	    string messageBody = message;
	    var popupNotifier = new PopupNotifier();
	    popupNotifier.TitleText = messagetime;
	    popupNotifier.ContentText = messageBody;
	    popupNotifier.IsRightToLeft = false;
	    popupNotifier.TitleColor = Color.White;
	    popupNotifier.BodyColor = Color.MediumPurple;
	    popupNotifier.HeaderColor = Color.MediumPurple;

	    popupNotifier.Popup();
	}
    }
}
