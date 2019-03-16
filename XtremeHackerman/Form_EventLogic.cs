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
    public partial class Form_EventLogic : Form
    {
        public Form_EventLogic()
        {
            InitializeComponent();
        }
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
        
        private void StateAction(Object obj)
        {

        }

        // Keeps track of the current state of the system in progress during each event.
        Dictionary<StateType, Action<Object>> StateMethods = new Dictionary<StateType, Action<Object>>
        {
            {StateType.ACTION, StateAction},
            {StateType.IDLE, StateIdle}
        };

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



        }

        private static void PhishingEmailAttack()
        {
            //Event Trigger
        }
        private static void PhishingEmailRecovery()
        {
            //Steps for recovering in the system for this event.
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
        

    }
}
