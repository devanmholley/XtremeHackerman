using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static XtremeHackerman.Form_Email;

namespace XtremeHackerman
{
    public partial class Form_Email
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mail"></param>
        public static void Get_Body(int mail)
        {
            int emailcase;
            // Identify which email is being called
            switch(mail)
            {
                case 1:
                    // The welcome email.
                    FormEmail.email_sourceTXT.Text = "sender@ma.il";
                    FormEmail.email_subjectTXT.Text = "Welcome";
                    emailcase = 1;
                    break;
                case 2:
                    FormEmail.email_sourceTXT.Text = "NigerianPrince@phi.sh";
                    FormEmail.email_subjectTXT.Text = "Want Free Money for Money";
                    break;
                default:
                    break;
            }
            // Fetch the text of the email from the corresponding txt file
            string body = File.ReadAllText(string.Join("","Resources/Mail/",mail.ToString(),".txt"));
            FormEmail.email_bodyTXT.Text = body;
        }
    }
}
