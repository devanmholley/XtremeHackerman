using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace XtremeHackerman.Classes
{
    internal class Class_Email
    {
        /// <summary>
        /// 
        /// </summary>
        public struct EmailStruct
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="emailSource"></param>
            /// <param name="emailDestination"></param>
            /// <param name="emailDate"></param>
            /// <param name="emailSubject"></param>
            /// <param name="emailBody"></param>
            public EmailStruct(string emailSource, string emailDestination, string emailDate, string emailSubject, string emailBody)
            {
                Source = emailSource;
                Destination = emailDestination;
                Date = emailDate;
                Subject = emailSubject;
                Body = emailBody;
            }

            public string Source { get; set; }

            public string Destination { get; set; }

            public string Date { get; set; }

            public string Subject { get; set; }

            public string Body { get; set; }
        }

        public static IList<EmailStruct> EmailList { get; set; } = JsonConvert.DeserializeObject<IList<EmailStruct>>(File.ReadAllText("Resources/Form_Email/Emails.json"));
    }
}
