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
        }

        private void email_composeBTN_Click(object sender, System.EventArgs e)
        {
            // When the 'Compose' button is left-clicked, this action will take place.
            // lets just start with making the 'Send' button visible.

            this.btn_Send.Visible = true;
            Date_TXT.Text = System.DateTime.Now.ToString();
            this.Date_TXT.Visible = true;
        }

        private void btn_Send_Click(object sender, System.EventArgs e)
        {
            //start by removing the 'send' button as you can't send the email twice.
            btn_Send.Visible = false;
        }
    }
}
