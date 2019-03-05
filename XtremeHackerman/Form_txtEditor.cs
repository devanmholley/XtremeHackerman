using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;


namespace XtremeHackerman
{
    public partial class Form_txtEditor : Form
    {
        public Form_txtEditor()
        {
            InitializeComponent();
        }

        private void DDBtn_save_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(string.Join("", "Resources/", "1", ".txt"));
            txt.Write(BodyTXT.Text);
            txt.Close();
        }

        private void DDBtn_load_Click(object sender, EventArgs e)
        {
            string strFileText = File.ReadAllText(string.Join("", "Resources/", "1", ".txt"));
            BodyTXT.Text = strFileText;
        }
    }
}
