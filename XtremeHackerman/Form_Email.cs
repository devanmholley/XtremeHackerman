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

        public string SourceTextBox
        {
            get => email_sourceTXT.Text;
            set => email_sourceTXT.Text = value;
        }

        public string BodyTextBox
        {
            get => email_bodyTXT.Text;
            set => email_bodyTXT.Text = value;
        }

        private void Form_Email_Load(object sender, System.EventArgs e)
        {
            RefreshEmailList();
            LoadEmailContents(0);
            //EmailList.Add(new EmailStruct("sender@ma.il", "Welcome"));
        }

        public void SetBodyTextBox(string text)
        {
            BodyTextBox = text;
        }

        private void email_inbox_SelectedValueChanged(object sender, System.EventArgs e)
        {
            LoadEmailContents(email_inbox.SelectedIndex);
        }
    }
}
