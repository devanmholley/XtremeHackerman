using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using XtremeHackerman.Classes;

namespace XtremeHackerman
{
    public partial class FormTitleScreen : Form
    {
        // Define byte[] VCRFont as an embedded resource, to be used for custom font formatting
        private readonly byte[] _vcrFont = Properties.Resources.VCR_OSD_MONO_1_001;

        public FormTitleScreen()
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
                button.Font = CustomFonts.GetFont(_vcrFont, button.Font.Size);
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
            XtremeHackermanForms.FormDesktop.ShowDialog();
        }

        /// <summary>
        /// Hide current TitlePage instance (NOT closing it) and load Hacker form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Hacker_Click(object sender, EventArgs e)
        {
            Hide();
            XtremeHackermanForms.FormHacker.ShowDialog();
        }

    }
}
