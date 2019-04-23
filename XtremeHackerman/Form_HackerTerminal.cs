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
    public partial class Form_HackerTerminal : Form
    {
        //Stores the user command into a string
        string TerminalInput;
        //Stores the current directory into a string
        string TerminalDirectory;
        //Stores the user and machine name
        string UserComp;
        //Stores the current command
        string TerminalCommand;

        // Initialize the form and display the startup text
        public Form_HackerTerminal()
        {
            InitializeComponent();
            UserComp = "Hackerman@Comp";
            HackerTerminal_TXT.AppendText(UserComp);
        }

        private void HackerTerminal_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        //If a known command is passed in run the associated command
        private void Eval_Commands(string command)
        {
            // If switching ip forwarding on
            if(command == "echo 1 | sudo tee /proc/sys/net/ipv4/ip_forward")
            {
                //prompt for user password
                
                //Check the password
            }

            // If checking the status of ip forwarding
            if(command == "cat /proc/sys/net/ipv4/ip_forward")
            {
                if(Classes.Class_HackerTerminal.ipforwarding == true)
                {
                    // if ip forwarding is enabled display 1
                }
                else
                {
                    // if ip forwarding is off display 0
                }
            }

        }


    }
}
