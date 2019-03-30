using System.Windows.Forms;

namespace XtremeHackerman
{
    /// <inheritdoc />
    /// <summary>
    /// Application Context for program; top-level handling of events handled here
    /// </summary>
    public class XtremeHackermanAppContext : ApplicationContext
    {
        private XtremeHackermanAppContext()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formTitleScreen = new Form_TitleScreen();
            formTitleScreen.Show();
        }

        /// <summary>
        /// Instantiates XtremeHackerAppContext and runs it.
        /// </summary>
        public static void Main()
        {
            var context = new XtremeHackermanAppContext();
            Application.Run(context);
        }

 }
}
