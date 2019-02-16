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
    public partial class Form_CLI : Form
    {
        string cliInput = null;
        string cliDirectory = "A:User\\HACKERMAN\\>";
        string cliCommand = null;
        string introText = "HACKERMAN [Version 1.0.2] - COMMAND LINE INTERFACE - ";
        int cliCurrentLine = 0;

        public Form_CLI()
        {
            InitializeComponent();
            cliText.AppendText(introText);
            cliText.AppendText(" - PRESS ENTER TO BEGIN - ");
        }

        private void cliText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cliInput = cliCommand;
                checkCommand(cliInput);
                string msg = String.Format("You have entered: {0}", cliInput);
                MessageBox.Show(msg, "COMMAND LINE ARGUMENT");
                cliText.AppendText(cliDirectory);
                cliCurrentLine += 1;
            }
        }

        private void cliText_TextChanged(object sender, EventArgs e)
        {
            cliCommand = cliText.Lines[cliCurrentLine];

        }

        private void checkCommand(string command)
        {
            if (command.Contains("RUN "))
            {
                MessageBox.Show("EVENT CHECK", "SUCCESSFUL");

            }

            if (command.Contains("DELETE "))
            {

            }
            if (command.Contains("DIR "))
            {

            }
            if (command.Contains("ECHO "))
            {

            }
            if (command.Contains("EXIT "))
            {

            }
            if (command.Contains("IPCONFIG "))
            {

            }
            if (command.Contains("EXIT"))
            {

            }

            //switch(command)
            //{
            //    case "cd":
            //        // Implementation
            //        break;
            //    case "delete":
            //        // Implementation
            //        break;
            //    case "dir":
            //        break;
            //    case "echo":
            //        // Implementation
            //        break;
            //    case "exit":
            //        // Implementation
            //        break;
            //    case "ipconfig":
            //       // Implementation 
            //       break;
            //    case "run":
            //        // Implementation
            //        MessageBox.Show("EVENT CHECK", "SUCCESSFUL");
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
