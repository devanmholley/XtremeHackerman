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
            cliText.AppendText( Environment.NewLine + "- PRESS ENTER TO BEGIN - ");
        }

        private void cliText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cliCurrentLine == 0) //If we are initializing the Command Line interface
                { // Initialize CLI with default command
                    cliText.Text = introText + "\r\n";
                    cliText.AppendText("STARTING AT DEFAULT PATH || FOR A LIST OF COMMANDS VIEW (TBD) - PRESS ENTER TO BEGIN");
                    cliText.Select(cliText.Text.Length, 0);
                    cliCurrentLine = 2;
                    return;
                }
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
                string action = command;
                MessageBox.Show("EVENT CHECK", "SUCCESSFUL");
                MessageBox.Show(action, "COMMAND");

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
