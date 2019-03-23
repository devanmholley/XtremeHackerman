using System;
using System.Windows.Forms;
using XtremeHackerman.Classes;

namespace XtremeHackerman
{
    public partial class Form_TitleScreen : Class_BaseForm
    {
        // Define byte[] VCRFont as an embedded resource, to be used for custom font formatting
        private readonly byte[] _vcrFont = Properties.Resources.VCR_OSD_MONO_1_001;

        public Form_TitleScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Run when TitleScreen is first loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_TitleScreen_Load(object sender, EventArgs e)
        {
            // Set font format for each button on page, but retain existing font size
            foreach(Control button in tableLayoutPanel_Buttons.Controls)
            {
                button.Font = Class_CustomFonts.GetFont(_vcrFont, button.Font.Size);
            }
        }

        /// <summary>
        /// Close TitlePage form. Will likely exit program as well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Hide current TitlePage instance (NOT closing it) and load Admin form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Admin_Click(object sender, EventArgs e)
        {
            Hide();
            var formDesktop = new Form_Desktop();
            formDesktop.ShowDialog();
        }

        /// <summary>
        /// Hide current TitlePage instance (NOT closing it) and load Hacker form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Hacker_Click(object sender, EventArgs e)
        {
            Hide();
            var formHacker = new Form_Hacker();
            formHacker.ShowDialog();
        }

    }
}
