using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using XtremeHackerman.Classes;


namespace XtremeHackerman
{
    public partial class Form_NotificationPopup : Form
    {
        public Form_NotificationPopup()
        {
            InitializeComponent();
        }

        private void testNotificationButton_Click(object sender, EventArgs e)
        {
            // Initialization of Notification Popup 

            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "He who desires, but acts not, breeds pestilence.";
            popupNotifier.ContentText = "The Mysterious One, V";
            popupNotifier.IsRightToLeft = false;
            popupNotifier.BodyColor = Color.Purple;
            popupNotifier.Popup();

        }
    }
}
