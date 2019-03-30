using System;
using System.Windows.Forms;

namespace XtremeHackerman.Classes
{
    public class Class_BaseForm : Form
    {
        public Class_BaseForm()
        {
            this.FormClosed += OnFormClosed;
        }

        /// <summary>
        /// Event logic for when form has closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosed(object sender, EventArgs e)
        {
            // If sender is second-to-last form, show FormTitleScreen upon closing. If sender IS FormTitleScreen, exit the program.
            switch (Application.OpenForms.Count)
            {
                case 1:
                    Application.OpenForms["Form_TitleScreen"]?.Show();
                    break;
                case 0:
                    Application.ExitThread();
                    break;
            }
        }
    }
}