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

        }

        private void DDBtn_load_Click(object sender, EventArgs e)
        {

        }

        private void S_File1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(string.Join("", "Resources/", "1", ".txt"));
            txt.Write(BodyTXT.Text);
            txt.Close();
        }

        private void S_File2_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(string.Join("", "Resources/", "2", ".txt"));
            txt.Write(BodyTXT.Text);
            txt.Close();
        }

        private void S_File3_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(string.Join("", "Resources/", "3", ".txt"));
            txt.Write(BodyTXT.Text);
            txt.Close();
        }

        private void L_File1_Click(object sender, EventArgs e)
        {
            string strFileText = File.ReadAllText(string.Join("", "Resources/", "1", ".txt"));
            BodyTXT.Text = strFileText;
        }

        private void L_File2_Click(object sender, EventArgs e)
        {
            string strFileText = File.ReadAllText(string.Join("", "Resources/", "2", ".txt"));
            BodyTXT.Text = strFileText;
        }

        private void L_File3_Click(object sender, EventArgs e)
        {
            string strFileText = File.ReadAllText(string.Join("", "Resources/", "3", ".txt"));
            BodyTXT.Text = strFileText;
        }
    }
}
