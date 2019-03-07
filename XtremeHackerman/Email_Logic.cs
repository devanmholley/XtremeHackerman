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

        public static void Move_To_Trash(int mail)
        {       // Moves the selected mail into the trash folder
            string sourceFile = string.Join("", "Resources/Mail/", mail.ToString(), ".txt");
            string targetFile = string.Join("", "Resources/Mail/Trash/", mail.ToString(), ".txt");

            // this is the line that moves the File from the source to the target
            System.IO.File.Move(sourceFile, targetFile);
            // Clear the text                                                                   <--- This may be changed later
            FormEmail.email_sourceTXT.Text = "";
            FormEmail.email_subjectTXT.Text = "";
            FormEmail.email_bodyTXT.Text = "";
        }

        public static void Move_To_Spam(int mail)
        {       // Moves the selected mail into the spam folder
            string sourceFile = string.Join("", "Resources/Mail/", mail.ToString(), ".txt");
            string targetFile = string.Join("", "Resources/Mail/Spam/", mail.ToString(), ".txt");

            // this is the line that moves the File from the source to the target
            System.IO.File.Move(sourceFile, targetFile);
            // Clear the text                                                                   <--- This may be changed later
            FormEmail.email_sourceTXT.Text = "";
            FormEmail.email_subjectTXT.Text = "";
            FormEmail.email_bodyTXT.Text = "";
        }
    }
}
