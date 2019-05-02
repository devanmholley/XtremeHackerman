using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using XtremeHackerman.Classes;


namespace XtremeHackerman
{
    class EventLogic
    {
        public enum StateType
        {
            ACTION,
            IDLE
        }
        public class Broadcaster // Sends a signal which the subscribers to it will trigger events
        {
            private int count;
            private event Action ChangeEvent;
            public event Action OnChange
            {
                add
                {
                    count++;
                    ChangeEvent += value;
                }
                remove
                {
                    count--;
                    ChangeEvent -= value;
                }
            }

            public void FireChangeEvent() =>
                ChangeEvent.Invoke();
        }

        /* private void StateAction(Object obj)
         {

         }

         // Keeps track of the current state of the system in progress during each event.
         Dictionary<StateType, Action<Object>> StateMethods = new Dictionary<StateType, Action<Object>>
         {
             {StateType.ACTION, StateAction},
             {StateType.IDLE, StateIdle}
         };*/

        public static void Main()
        {
            // In the main program will contain the broadcaster signals for each kind of attack event and invoke the subscribers to trigger each event.
            //Phishing Email Event
            Broadcaster phishing = new Broadcaster();
            phishing.OnChange += PhishingEmailAttack;
            phishing.OnChange += PhishingEmailRecovery;

            // DDos Event
            Broadcaster DDos = new Broadcaster();
            DDos.OnChange += DDosAttack;
            DDos.OnChange += DDosRecovery;

            //Bruteforce Event
            Broadcaster Bruteforce = new Broadcaster();
            Bruteforce.OnChange += BruteforceAttack;
            Bruteforce.OnChange += BruteforceRecovery;

            //Session Hijacking Event
            Broadcaster Session = new Broadcaster();
            Session.OnChange += SessionAttack;
            Session.OnChange += SessionRecovery;

            //Wireshark Event
            Broadcaster Wireshark = new Broadcaster();
            Wireshark.OnChange += WiresharkAttack;
            Wireshark.OnChange += WiresharkRecovery;


            //Wireshark Event
            Broadcaster Keylogger = new Broadcaster();
            Keylogger.OnChange += KeyloggerAttack;
            Keylogger.OnChange += KeyloggerRecovery;


            //Wireshark Event
            Broadcaster Procmon = new Broadcaster();
            Procmon.OnChange += ProcmonAttack;
            Procmon.OnChange += ProcmonRecovery;

            //Ransomeware Event
            Broadcaster Ransomware = new Broadcaster();
            Ransomware.OnChange += RansomwareAttack;
            Ransomware.OnChange += RansomwareRecovery;


            //File Manager
            Broadcaster File = new Broadcaster();
            File.OnChange += FileManager;

            //Task Manager
            Broadcaster Task = new Broadcaster();
            Task.OnChange += TaskManager;

            //Email Client
            Broadcaster Email = new Broadcaster();
            Email.OnChange += EmailClient;

            //Command Line
            Broadcaster Cmd = new Broadcaster();
            Cmd.OnChange += CommandLine;

            //Internet Browers
            Broadcaster Internet = new Broadcaster();
            Internet.OnChange += InternetBrowser;

            //Company Firewall
            Broadcaster Firewall = new Broadcaster();
            Internet.OnChange += CompanyFirewall;




        }

        public static void PhishingEmailAttack()
        {
	    string sender = "ChaseBank@fake.com";
            string destination = "SysAdmin@meganopoly.com";
            string sentdate = "April 10, 2019";
            string subject = "Problem with your bank account- For Real";
            string body = "We have noticed suspicious activity on your account. Please reply with your " +
            "credit card number as well as the expiration date and the 3 magic numbers on the " +
            "back to validate your identity. This is not a phishing email. I am cereal.";
            Class_Email.AddMail(sender, destination, sentdate, subject, body);
	    Desktop_BKEND.Notification("You've got mail!", false);
        }

	private static void PhishingEmailRecovery()
        {
            //Steps for recovering in the system for this event.
        }

	public static void RansomwareAttack()
	{
	    //Event Trigger
	    Desktop_BKEND.CloseOpenForms(); //close all open forms
	    Class_File.Save(Class_FileManager.root, "not ransomware", "Totally Not Ransomware", true, null); //create a file in filemanager
	    Form_TitleScreen.formDesktop.BackgroundRefresh(); //start the attack by changing desktop bg and disable icons
	}

	private static void RansomwareRecovery()
	{
	    // Steps for recovering in the system for this event
	}

	private static void DDosAttack()
        {
            //Event Trigger
        }
        private static void DDosRecovery()
        {
            //Steps for recovering in the system for this event.
        }

        private static void BruteforceAttack()
        {
            //Event Trigger
        }
        private static void BruteforceRecovery()
        {
            //Steps for recovering in the system for this event.
        }

        private static void SessionAttack()
        {
            //Event Trigger
        }
        private static void SessionRecovery()
        {
            //Steps for recovering in the system for this event.
        }

        private static void WiresharkAttack()
        {
            //Event Trigger
        }
        private static void WiresharkRecovery()
        {
            //Steps for recovering in the system for this event.
        }


        private static void KeyloggerAttack()
        {
            //Event Trigger
        }
        private static void KeyloggerRecovery()
        {
            //Steps for recovering in the system for this event.
        }


        private static void ProcmonAttack()
        {
            //Event Trigger
        }
        private static void ProcmonRecovery()
        {
            //Steps for recovering in the system for this event.
        }


        private static void DesktopNotifications()
        {
            //Event for activating the Desktop Notifications
        }

        private static void FileManager()
        {
            //Event for opening the File Manager
        }

        private static void TaskManager()
        {
            //Event for opening the Task Manager
        }

        private static void EmailClient()
        {
            //Event for opening the Email Client
        }

        private static void CommandLine()
        {
            //Event for opening the Command Line
        }

        private static void InternetBrowser()
        {
            //Event for opening the Internet Browser
        }

        private static void CompanyFirewall()
        {
            //Event for opening the Company Firewall
        }




        //This code for the current events is taken from https://stackoverflow.com/questions/5923767/simple-state-machine-example-in-c
        public enum ProcessState
        {
            Inactive,
            Active,
            Paused,
            Terminated
        }

        public enum Command
        {
            Begin,
            End,
            Pause,
            Resume,
            Exit
        }

        public class Process
        {
            class StateTransition
            {
                readonly ProcessState CurrentState;
                readonly Command Command;


                public StateTransition(ProcessState currentState, Command command)
                {
                    CurrentState = currentState;
                    Command = command;
                }
            }

            Dictionary<StateTransition, ProcessState> transitions;
            public ProcessState CurrentState { get; private set; }

            public Process()
            {
                CurrentState = ProcessState.Inactive;
                transitions = new Dictionary<StateTransition, ProcessState>
            {
                { new StateTransition(ProcessState.Inactive, Command.Exit), ProcessState.Terminated },
                { new StateTransition(ProcessState.Inactive, Command.Begin), ProcessState.Active },
                { new StateTransition(ProcessState.Active, Command.End), ProcessState.Inactive },
                { new StateTransition(ProcessState.Active, Command.Pause), ProcessState.Paused },
                { new StateTransition(ProcessState.Paused, Command.End), ProcessState.Inactive },
                { new StateTransition(ProcessState.Paused, Command.Resume), ProcessState.Active }
            };
            }

            //Transistions between step
            public ProcessState GetNext(Command command)
            {
                StateTransition transition = new StateTransition(CurrentState, command);
                ProcessState nextState;
                if (!transitions.TryGetValue(transition, out nextState)) // Handles the case where the transition to the next step is invalid in which case throws and exceptions to get the values from the next step.
                    throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
                return nextState;
            }

            //Moves to the next step in the event once cleared through its previous step.
            public ProcessState MoveNext(Command command)
            {
                CurrentState = GetNext(command);
                return CurrentState;
            }
        }

        // Main Program to go through Events as they are being called.
        public class Program
        {
            static void Main(string[] args)
            {
                Process p = new Process();
                Console.WriteLine("Current State = " + p.CurrentState);

            }







        }
    }
}