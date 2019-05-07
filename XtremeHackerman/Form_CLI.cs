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
    public partial class Form_CLI : Form
    {
        string cliInput = null;
        string cliDirectory = "A:User\\HACKERMAN\\>";
        string cliCommand = null;
        string introText = "HACKERMAN [Version 1.9.2] - COMMAND LINE INTERFACE - ";
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
                    cliText.AppendText("STARTING AT DEFAULT PATH || FOR A LIST OF COMMANDS TYPE HELP% - PRESS ENTER TO BEGIN");
                    cliText.Select(cliText.Text.Length, 0);
                    cliCurrentLine = 2;
                    return;
                }
                string cliInput = cliCommand;
                checkCommand(cliInput);
                //string msg = String.Format("You have entered: {0}", cliInput);
                //MessageBox.Show(msg, "COMMAND LINE ARGUMENT");
                //cliText.AppendText(cliDirectory);
                cliCurrentLine += 1;
            }
        if(e.KeyCode == Keys.Back)
        {
            if(cliText.Lines[cliCurrentLine].Length == 0)
            {
                e.SuppressKeyPress = true;
            }
        }
        }

        private void cliText_TextChanged(object sender, EventArgs e)
        {
            cliCommand = cliText.Lines[cliCurrentLine];

        }

        private void checkCommand(string command)
        {
            if (command.Contains("RUN%"))
            {
                string[] action = command.Split(' ');

                MessageBox.Show("EVENT CHECK", "SUCCESSFUL");
                MessageBox.Show(action[1], "COMMAND");

                switch (action[1])
                {
                    case "Form_Email":
			var formEmail = new Form_Email();
			formEmail.Show();
                        break;
                    case "Form_InternetBrowser":
			var formInternetBrowser = new Form_InternetBrowser();
			formInternetBrowser.Show();
                        break;
                    default:
                        return;
                }
            }

            if (command.Contains("DELETE%"))
            {
                // TBD: ONCE FILE MANAGEMENT IS IMPLEMENTED 
            }
            if (command.Contains("DIR%"))
            {
                string[] path = command.Split(' ');
                string currentDir = path.Last();
                cliDirectory += "\\" + currentDir;
                cliText.AppendText(Environment.NewLine + cliDirectory);
                cliCurrentLine += 1;
            }
            if (command.Contains("ECHO%"))
            {
                string[] output = command.Split(' ');
                foreach (string segment in output)
                {
                    cliText.AppendText(Environment.NewLine + segment);
                }
                cliCurrentLine += output.Length;
            }
            if (command.Contains("EXIT%"))
            {
                Application.Exit();
            }
            if (command.Contains("IPCONFIG%"))
            {
                cliText.AppendText(Environment.NewLine + "IP Address. . . . . . . . . . . . : 192.168.201.245");
                cliText.AppendText(Environment.NewLine + "Subnet Mask . . . . . . . . . . . : 255.255.255.0");
                cliText.AppendText(Environment.NewLine + "Default Gateway . . . . . . . . . : 192.168.201.1");
                cliCurrentLine += 3;
            }

            if (command.Contains("HELP%"))
            {
                cliText.AppendText(Environment.NewLine + "---------------- COMMAND LINE INSTRUCTIONS ----------------");
                cliText.AppendText(Environment.NewLine + "HERE YOU CAN ENTER A COMMAND FOR THE HACKERMAN SOFTWARE TO TRIGGER CERTAIN ACTIONS");
                cliText.AppendText(Environment.NewLine + "TO TRIGGER A CERTAIN ACTION, ENTER THE KEYWORD FOLLOWED BY %");
                cliText.AppendText(Environment.NewLine + "COMMANDS ARE LISTED BELOW");
                cliText.AppendText(Environment.NewLine + "RUN_X - RUNS A SPECIFIC DESKTOP APPLICATION ");
                cliText.AppendText(Environment.NewLine + "ECHO_X - ECHOS THE ENTERED TEXT ");
                cliText.AppendText(Environment.NewLine + "EXIT - EXITS THE COMMAND LINE INTERFACE");
                cliText.AppendText(Environment.NewLine + "IPCONFIG - DISPLAYS INTERNET PROTOCOL INFORMATION");
                cliText.AppendText(Environment.NewLine + "-----------------------------------------------------------");
                cliCurrentLine += 9;
            }

            if (command.Contains("PHISH%"))
            {
		cliText.AppendText(Environment.NewLine + "---------------- TRIGGERING PHISHING SIMULATION ----------------");
		Class_Progress.PhishSimulation();
                cliCurrentLine += 1;
            }

            if (command.Contains("RANSOMWARE%"))
            {
		cliText.AppendText(Environment.NewLine + "---------------- TRIGGERING RANSOMWARE SIMULATION ----------------");
		Class_Progress.RansomwareSimulation();
                cliCurrentLine += 1;
            }
        }
    }
}
