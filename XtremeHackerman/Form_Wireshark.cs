using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman
{
    public partial class Form_Wireshark : Form
    {
        public Form_Wireshark()
        {
            InitializeComponent();
        }

        private void Form_Wireshark_Load(object sender, EventArgs e)
        {

        }

        private void DisplayFilterText_TextChanged(object sender, EventArgs e)
        {
            // If the text is empty
            if (string.IsNullOrEmpty(DisplayFilterText.Text))
            {
                // Set Default Message
                DisplayFilterText.Text = "Apply a display filter...";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
