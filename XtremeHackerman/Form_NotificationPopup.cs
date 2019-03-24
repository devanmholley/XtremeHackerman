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
            string messagetime = System.DateTime.Now.ToString("ddd  HH:mm:ss");
            string messageBody = "[SAMPLE TEXT]";
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
