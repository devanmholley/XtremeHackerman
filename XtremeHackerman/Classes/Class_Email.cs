using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace XtremeHackerman.Classes
{
    // Allows us to add Emails to the Json file.
    [JsonObject(MemberSerialization.OptIn)]
    internal class Class_Email
    {
        // Adds new mail into the JSON file so it appears in the inbox.
        public void AddMail(string src, string dst, string dt, string sbjt, string bdy)
        {
            EmailStruct newMail = new EmailStruct
            {
                // Creates a new email with the passed in values.
                Source = src,
                Destination = dst,
                Date = dt,
                Subject = sbjt,
                Body = bdy
            };

            //Then we add the new email to the inbox.
            EmailList.Add(newMail);

            //Serialize the new object into the JSON file.
            JsonConvert.SerializeObject(EmailList, Formatting.Indented);
        }


        public struct EmailStruct
        {
            // Set the values of 
            public EmailStruct(string emailSource, string emailDestination, string emailDate, string emailSubject, string emailBody)
            {
                Source = emailSource;
                Destination = emailDestination;
                Date = emailDate;
                Subject = emailSubject;
                Body = emailBody;
            }

            //Establishes the objects as properties of a Json file.

            public string Source { get; set; }

            public string Destination { get; set; }

            public string Date { get; set; }

            public string Subject { get; set; }

            public string Body { get; set; }
        }

        //Pulls the information from the Json file and adds it to the email inbox.
        public static IList<EmailStruct> EmailList { get; set; } = JsonConvert.DeserializeObject<IList<EmailStruct>>(File.ReadAllText("Resources/Form_Email/Emails.json"));
    }
}