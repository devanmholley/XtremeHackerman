using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace XtremeHackerman
{
    /// <summary>
    /// Static class containing the form variables; used for global access
    /// </summary>
    internal static class XtremeHackermanForms
    {
        public static FormAdmin FormAdmin;
        public static Form_Hacker FormHacker;
        public static FormTitleScreen FormTitleScreen;
        public static FormInternetBrowser FormBrowser;
        public static Form_Desktop FormDesktop;
        public static FormEmail FormEmail;
        public static Firewall FormFirewall;
        public static Landing_page FormLandingPage;


    }

    /// <summary>
    /// Application Context for program; top-level handling of events handled here
    /// </summary>
    public class XtremeHackermanAppContext : ApplicationContext
    {
        //String list containing the names of the currently active forms
        private readonly List<string> _activeForms = new List<string>();

        private XtremeHackermanAppContext()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Creates each form and appends event handlers to them.
            XtremeHackermanForms.FormTitleScreen = new FormTitleScreen();
            XtremeHackermanForms.FormTitleScreen.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormTitleScreen.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormTitleScreen.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormAdmin = new FormAdmin();
            XtremeHackermanForms.FormAdmin.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormAdmin.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormAdmin.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormDesktop = new Form_Desktop();
            XtremeHackermanForms.FormDesktop.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormDesktop.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormDesktop.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormHacker = new Form_Hacker();
            XtremeHackermanForms.FormHacker.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormHacker.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormHacker.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormBrowser = new FormInternetBrowser();
            XtremeHackermanForms.FormBrowser.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormBrowser.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormBrowser.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormEmail = new FormEmail();
            XtremeHackermanForms.FormEmail.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormEmail.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormEmail.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormFirewall = new Firewall();
            XtremeHackermanForms.FormFirewall.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormFirewall.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormFirewall.Load += new EventHandler(OnFormLoad);

            XtremeHackermanForms.FormLandingPage = new Landing_page();
            XtremeHackermanForms.FormLandingPage.Closed += new EventHandler(OnFormClosed);
            XtremeHackermanForms.FormLandingPage.Closing += new CancelEventHandler(OnFormClosing);
            XtremeHackermanForms.FormLandingPage.Load += new EventHandler(OnFormLoad);
            #endregion

            XtremeHackermanForms.FormTitleScreen.Show();
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
