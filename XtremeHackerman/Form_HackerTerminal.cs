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
        //Stores the user and machine name
        string UserComp = "Hackerman@Comp$ ";
        //Stores the current command
        string TerminalCommand;
        //Stores the current line number
        int TerminalCurrentLine = 0;


        // Initialize the form and display the startup text
        public Form_HackerTerminal()
        {
            InitializeComponent();
            HackerTerminal_TXT.AppendText(UserComp);
        }


        private void HackerTerminal_TXT_TextChanged(object sender, EventArgs e)
        {
            GetLinePos();
            // The current command is whatever is written on the current line
            TerminalCommand = HackerTerminal_TXT.Lines[TerminalCurrentLine];
        }

      
        private void TerminalTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string terminalInput = TerminalCommand;
                Eval_Commands(terminalInput);
            }
        }


        private void GetLinePos()
        {
            // Gets the position of the cursor
            int cursorIndex = HackerTerminal_TXT.SelectionStart;
            // Gets the line that the cursor index is in and sets TerminalCurrentLine to it
            TerminalCurrentLine = HackerTerminal_TXT.GetLineFromCharIndex(cursorIndex);
        }


        //If a known command is passed in run the associated command
        private void Eval_Commands(string command)
        {
            // New lines can leave the return and newline characters at the beginning
            // of the string. Remove these so that the command can be read.
            if (command.Contains("\r\n"))
            {
                command = command.Replace("\r\n", "");
            }

            switch (command)
            {
                // If switching ip forwarding on
                case "Hackerman@Comp$ echo '1' | sudo tee /proc/sys/net/ipv4/ip_forward":
                    Classes.Class_HackerTerminal.ipforwarding = true;
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    break;

                // Turn off ip forwarding
                case "Hackerman@Comp$ echo '0' | sudo tee /proc/sys/net/ipv4/ip_forward":
                    Classes.Class_HackerTerminal.ipforwarding = false;
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    break;

                // If checking the status of ip forwarding
                case "Hackerman@Comp$ cat /proc/sys/net/ipv4/ip_forward":
                    if (Classes.Class_HackerTerminal.ipforwarding)
                    {
                        HackerTerminal_TXT.AppendText(Environment.NewLine + "1");
                        HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    }
                    else
                    {
                        HackerTerminal_TXT.AppendText(Environment.NewLine + "0");
                        HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    }
                    break;

                // Get the network configurations
                case "Hackerman@Comp$ ifconfig":
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "wlp5s0: " +
                        "flags=4319<UP,BORADCASE,RUNNING,MULTICAST> mtu 1500");
                    // The user ip, netmask etc.
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t inet " +
                        Classes.Class_HackerTerminal.UserIP + "netmask 255.255.255.0  " +
                        "broadcast 192.171.0.100");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t inet6 " +
                        "fe80::26e5:eef7:3e70:4b0c  prefixlen 64  scopeid 0x20<link>");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t ether" +
                        "00:26:c7:77:88:48  txqueuelen 1000 (Ethernet)");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t RX packets" +
                        " 164  bytes 34810  (34.8 KB");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t RX errors " +
                        "0  dropped 1  overruns 0  frame 0");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t TX Packets 49 " +
                        " bytes 7840 (7.8 KB)");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "\t TX errors 0 " +
                        " dropped 0 overruns 0 carrier 0  collisions 0");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    break;

                // When telling the client you are the server
                case "Hackerman@Comp$ sudo arpspoof -i wlp5s0 -t 138.93.0.10 172.217.9.14":
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "0:26:c7:77:88:48 " +
                    "8:0:27:5f:58:20 0806 42: arp reply 192.168.0.168 is-at " +
                    "0:26:c7:77:88:48");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    Classes.Class_HackerTerminal.CSarp = true;
                    break;

                // When telling the server you are the client
                case "Hackerman@Comp$ sudo arpspoof -i wlp5s0 -t 172.217.9.14 138.93.0.10":
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "0:26:c7:77:88:48 " +
                                        "8:0:27:5f:58:20 0806 42: arp reply 192.168.0.168 is-at " +
                                        "0:26:c7:77:88:48");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    Classes.Class_HackerTerminal.SCarp = true;
                    break;
                
                // Sniff network traffic
                case "Hackerman@Comp$ sudo dsniff -c":
                    // Header
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "tcp 172.217.9.14.33322" +
                        " -> 138.93.0.10.21 (ftp)");
                    // Packet body
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "USER root");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "PASS password123");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    break;

                default:
                    HackerTerminal_TXT.AppendText(Environment.NewLine + "Invalid command");
                    HackerTerminal_TXT.AppendText(Environment.NewLine + UserComp);
                    break;
            }
        }
    }
}
