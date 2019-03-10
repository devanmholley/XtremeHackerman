using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XtremeHackerman.Classes;


namespace XtremeHackerman
{
    public partial class Form_LandingPage : Class_BaseForm
    {
        public Form_LandingPage()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        // The functionality of the two user and password fields will try and run parallel with the password manager to log them in 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // The button will hide the window for the firewall login and display the next window 
        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Firewall formFirewall = new Form_Firewall();
            formFirewall.Show();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
