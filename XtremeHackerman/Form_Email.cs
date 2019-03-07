using System.Windows.Forms;
using XtremeHackerman.Classes;


namespace XtremeHackerman
{
    public  partial class FormEmail : Form
    {
        private static FormEmail _formEmail;

        public FormEmail()
        {
            InitializeComponent();
            _formEmail = this;
        }

        private void FormEmail_Load(object sender, System.EventArgs e)
        { 
            emailInboxBindingSource.DataSource = EmailLogic.EmailList;
            email_inbox.DisplayMember = "Subject";
            email_sourceTXT.DataBindings.Add("Text", emailInboxBindingSource, "Source");
            email_destTXT.DataBindings.Add("Text", emailInboxBindingSource, "Destination");
            email_dateTXT.DataBindings.Add("Text", emailInboxBindingSource, "Date");
            email_subjectTXT.DataBindings.Add("Text", emailInboxBindingSource, "Subject");
            email_bodyTXT.DataBindings.Add("Text", emailInboxBindingSource, "Body");
        }
    }
}
