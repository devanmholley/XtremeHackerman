using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XtremeHackerman.Classes
{
    class EmailLogic
    {
        /// <summary>
        /// 
        /// </summary>
        public struct EmailStruct
        {
            private string _source;
            private string _destination;
            private string _date;
            private string _subject;
            private string _body;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="emailSource"></param>
            /// <param name="emailDestination"></param>
            /// <param name="emailSubject"></param>
            /// <param name="emailBody"></param>
            public EmailStruct(string emailSource, string emailDestination, string emailDate, string emailSubject, string emailBody)
            {
                _source = emailSource;
                _destination = emailDestination;
                _date = emailDate;
                _subject = emailSubject;
                _body = emailBody;
            }

            public string Source
            {
                get => _source;
                set => _source = value;
            }

            public string Destination
            {
                get => _destination;
                set => _destination = value;
            }

            public string Date
            {
                get => _date;
                set => _date = value;
            }

            public string Subject
            {
                get => _subject;
                set => _subject = value;
            }

            public string Body
            {
                get => _body;
                set => _body = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static IList<EmailStruct> _emailList = JsonConvert.DeserializeObject<IList<EmailStruct>>(File.ReadAllText("Resources/Mail/Emails.json"));

        public static IList<EmailStruct> EmailList
        {
            get => _emailList;
            set => _emailList = value;
        }
    }
}
