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
        //Stores the current line number
        int TerminalCurrentLine = 0;

        // Initialize the form and display the startup text
        public Form_HackerTerminal()
        {
            InitializeComponent();
            UserComp = "Hackerman@Comp";
            HackerTerminal_TXT.AppendText(UserComp);
        }

        private void HackerTerminal_TXT_TextChanged(object sender, EventArgs e)
        {
            // The current command is whatever is written on the current line
            TerminalCommand = HackerTerminal_TXT.Lines[TerminalCurrentLine];
        }

        // Prompt for the password and check it
        private void prompt_Pass()
        {
            //prompt for user password
            HackerTerminal_TXT.AppendText(Environment.NewLine +
                "Password for Hackerman:");
            //Increment the line counter
            TerminalCurrentLine += 1;
            //get the password
            string userinput = TerminalCommand;
            //Check the password
            if (Classes.Class_HackerTerminal.Check_Pass(userinput) == true)
            {
                TerminalCurrentLine += 1;
            }
            else
            {
                HackerTerminal_TXT.AppendText(Environment.NewLine + 
                    "Incorrect password.");
                TerminalCurrentLine += 1;
            }
        }

        //If a known command is passed in run the associated command
        private void Eval_Commands(string command)
        {
            // If switching ip forwarding on
            if(command == "echo '1' | sudo tee /proc/sys/net/ipv4/ip_forward")
            {
                TerminalCurrentLine += 1;
                // prompt for the password
                prompt_Pass();
                // enable ip forwarding
                Classes.Class_HackerTerminal.ipforwarding = true;
            }
            // Turn off ip forwarding
            if(command == "echo '0' | sudo tee /proc/sys/net/ipv4/ip_forward")
            {
                TerminalCurrentLine += 1;
                prompt_Pass();
                Classes.Class_HackerTerminal.ipforwarding = false;
            }
            // If checking the status of ip forwarding
            if(command == "cat /proc/sys/net/ipv4/ip_forward")
            {
                if(Classes.Class_HackerTerminal.ipforwarding == true)
                {
                    // if ip forwarding is enabled display 1
                    HackerTerminal_TXT.AppendText(Environment.NewLine +"1");
                    TerminalCurrentLine += 1;
                }
                else
                {
                    // if ip forwarding is off display 0
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "0");
                    TerminalCurrentLine += 1;
                }
            }
            // Get the network configurations
            if(command == "ifconfig")
            {
                HackerTerminal_TXT.AppendText(Environment.NewLine + "wlp5s0: " +
                    "flags=4319<UP,BORADCASE,RUNNING,MULTICAST> mtu 1500");
                TerminalCurrentLine += 1;
                // The user ip, netmask etc.
                HackerTerminal_TXT.AppendText(Environment.NewLine + "\t inet " +
                    Classes.Class_HackerTerminal.UserIP + "netmask 255.255.255.0  " +
                    "broadcast 192.171.0.100");
                TerminalCurrentLine += 1;
                HackerTerminal_TXT.AppendText(Environment.NewLine + "\t inet6 " +
                    "fe80::26e5:eef7:3e70:4b0c  prefixlen 64  scopeid 0x20<link>");
                TerminalCurrentLine += 1;
                HackerTerminal_TXT.AppendText(Environment.NewLine + "\t ether" +
                    "00:26:c7:77:88:48  txqueuelen 1000 (Ethernet)");
                TerminalCurrentLine += 1;
                HackerTerminal_TXT.AppendText(Environment.NewLine + "\t RX packets" +
                    " 164  bytes 34810  (34.8 KB");
            }

        }


    }
}
