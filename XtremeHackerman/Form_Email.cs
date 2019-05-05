using System;
using System.Windows.Forms;
using XtremeHackerman.Classes;


namespace XtremeHackerman
{
    public  partial class Form_Email : Class_BaseForm
    {
        private static Form_Email _formEmail;

        public Form_Email()
        {
            InitializeComponent();
            _formEmail = this;
        }

        private void FormEmail_Load(object sender, System.EventArgs e)
        {
            emailInboxBindingSource.DataSource = Class_Email.EmailList;
            email_inbox.DisplayMember = "Subject";
            email_sourceTXT.DataBindings.Add("Text", emailInboxBindingSource, "Source");
            email_destTXT.DataBindings.Add("Text", emailInboxBindingSource, "Destination");
            email_dateTXT.DataBindings.Add("Text", emailInboxBindingSource, "Date");
            email_subjectTXT.DataBindings.Add("Text", emailInboxBindingSource, "Subject");
            email_bodyTXT.DataBindings.Add("Text", emailInboxBindingSource, "Body");
	    timer1.Start();
        }

        private void email_composeBTN_Click(object sender, System.EventArgs e)
        {
            /// When the 'Compose' button is left-clicked, this action will take place.
            
            // lets just start with making the 'Send' button visible.
            btn_Send.Visible = true;
            // set the date of the composition
            Date_TXT.Text = System.DateTime.Now.ToString();
            Date_TXT.Visible = true;
            // clear the previous email
            email_fromSTXT.Visible = false;
            email_dateTXT.Visible = false;
            email_destTXT.Visible = false;
            email_sourceTXT.Visible = false;
            email_subjectTXT.Text = "";
            email_bodyTXT.Text = "";

            // allow for entering a target 
            targetTXT.Visible = true;
            // and be able to write the email.
            email_subjectTXT.ReadOnly = false;
            email_bodyTXT.ReadOnly = false;
        }

        private void btn_Send_Click(object sender, System.EventArgs e)
        {
            /// check to see if the target field has a valid address

            string target = targetTXT.Text;
            if (target.Contains("@") && target.Contains("."))
            {
                if (this.email_subjectTXT.Text == "")
                {
                    const string mes = "Your email should have a subject.";
                    var res = MessageBox.Show(mes);
                }
                else
                {
                    if (this.email_bodyTXT.Text == "")
                    {
                        const string mes = "Your email should have a body.";
                        var res = MessageBox.Show(mes);
                    }
                    else
                    {
                        // Valid Address
                        const string message = "Email has been sent.";
                        var result = MessageBox.Show(message);

                        this.Dispose();
                        var formEmail = new Form_Email();
                        formEmail.ShowDialog();
                    }
                }
            }

            else
            {
                // Invalid Address
                const string message = "You have entered an invalid email address";
                var result = MessageBox.Show(message);
            }
        }

        private void LL_Phish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// this is where we download the attachment.
            //EventLogic.RansomwareAttack();
        }

        private void email_inbox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.email_sourceTXT.Text == "ChaseBank@fake.com")
            {
                this.LL_Phish.Visible = true;
                this.LL_Phish.Enabled = true;
		Class_Progress.StepCompleted("Phishing Email", 1); //step one completed
            }
            else
            {
                this.LL_Phish.Visible = false;
                this.LL_Phish.Enabled = false;
            }
        }

	private void saveLinkToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
	    string fileName = String.Join("", LL_Phish.Text.Split('\\', '/', ':', '*', '?', '"', '<', '>', '|')); //remove invalid characters
	    Class_File.Save(null, fileName, "HTML Document", true, null); // save into downloads
	}

	private void saveLinkAsToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
	    string fileName = String.Join("", LL_Phish.Text.Split('\\', '/', ':', '*', '?', '"', '<', '>', '|')); //remove invalid characters
	    Class_File.SaveAs(fileName, "HTML Document", true, null); //save into chosen folder, and allow user to edit filename
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	    emailInboxBindingSource.ResetBindings(false); //refresh email
	}
    }
}
