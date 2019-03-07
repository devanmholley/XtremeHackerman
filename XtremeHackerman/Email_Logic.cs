using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace XtremeHackerman
{
    public struct EmailStruct
    {
        public readonly string Source;
        public readonly string Destination;
        public readonly string Subject;
        public readonly string Body;

        public EmailStruct(string emailSource,string emailDestination,string emailSubject, string emailBody)
        {
            Source = emailSource;
            Destination = emailDestination;
            Subject = emailSubject;
            Body = emailBody;
        }
    }

    public partial class FormEmail
    {
        private static Collection<EmailStruct> _emailList;

        private static void RefreshEmailList()
        {
            _emailList = JsonConvert.DeserializeObject<Collection<EmailStruct>>(File.ReadAllText("Resources/Mail/Emails.json"));
            _formEmail.email_inbox.Items.Clear();
            foreach (var emailStruct in _emailList)
            {
                _formEmail.email_inbox.Items.Add(emailStruct);
            }
            _formEmail.email_inbox.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageIndex"></param>
        private static void LoadEmailContents(int messageIndex)
        {
            var currentEmail = _emailList[messageIndex];

            _formEmail.email_sourceTXT.Text = currentEmail.Source;
            _formEmail.email_destTXT.Text = currentEmail.Destination;
            _formEmail.email_subjectTXT.Text = currentEmail.Subject;
            _formEmail.email_bodyTXT.Text = currentEmail.Body;
        }

        public static void GetMail()
        {
            //FormEmail.email_inbox.Items.Add();
        }
    }
}
