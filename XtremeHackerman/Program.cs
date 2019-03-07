﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;
using System.ComponentModel;

namespace XtremeHackerman
{
    /// <summary>
    /// Static class containing the form variables; used for global access
    /// </summary>
    static class XtremeHackermanForms
    {
        public static Form_Admin _formAdmin;
        public static Form_Hacker _formHacker;
        public static Form_TitleScreen _formTitleScreen;
        public static Form_InternetBrowser _formBrowser;
        public static Form_Desktop _formDesktop;
        public static Form_Email _formEmail;
        public static Firewall _formFirewall;
        public static Landing_page _formLandingPage;


    }

    /// <summary>
    /// Application Context for program; top-level handling of events handled here
    /// </summary>
    public class XtremeHackermanAppContext : ApplicationContext
    {
        //String list containing the names of the currently active forms
        private List<string> _activeForms = new List<string>();

        private XtremeHackermanAppContext()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Creates each form and appends event handlers to them.
            XtremeHackermanForms._formTitleScreen = new Form_TitleScreen();
            XtremeHackermanForms._formTitleScreen.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formTitleScreen.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formTitleScreen.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formAdmin = new Form_Admin();
            XtremeHackermanForms._formAdmin.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formAdmin.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formAdmin.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formDesktop = new Form_Desktop();
            XtremeHackermanForms._formDesktop.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formDesktop.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formDesktop.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formHacker = new Form_Hacker();
            XtremeHackermanForms._formHacker.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formHacker.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formHacker.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formBrowser = new Form_InternetBrowser();
            XtremeHackermanForms._formBrowser.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formBrowser.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formBrowser.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formEmail = new Form_Email();
            XtremeHackermanForms._formEmail.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formEmail.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formEmail.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formFirewall = new Firewall();
            XtremeHackermanForms._formFirewall.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formFirewall.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formFirewall.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms._formLandingPage = new Landing_page();
            XtremeHackermanForms._formLandingPage.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms._formLandingPage.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms._formLandingPage.Load += new EventHandler(OnFormLoad);
            #endregion

            XtremeHackermanForms._formTitleScreen.Show();
        }

        /// <summary>
        /// Event logic for when form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosing(object sender, CancelEventArgs e)
        {
        }

        /// <summary>
        /// Event logic for when form has closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosed(object sender, EventArgs e)
        {
            // If closing form is not TitleScreen, restore hidden TitleScreen's visibility
            if (!(sender is Form_TitleScreen))
                XtremeHackermanForms._formTitleScreen.Show();

            // Remove closed form from _activeForms
            _activeForms.Remove(sender.ToString());

            // If _activeForms is empty, exit program
            if (_activeForms.Count == 0)
                ExitThread();
        }

        /// <summary>
        /// Event logic for when form is opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad(object sender, EventArgs e)
        {
            // Add newly-loaded form to _activeForms
            _activeForms.Add(sender.ToString());
        }

        /// <summary>
        /// Instantiates XtremeHackerAppContext and runs it.
        /// </summary>
        public static void Main()
        {
            XtremeHackermanAppContext context = new XtremeHackermanAppContext();
            Application.Run(context);
        }

 }
}
