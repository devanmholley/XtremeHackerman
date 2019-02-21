using System.Windows.Forms;


namespace XtremeHackerman
{
    public  partial class Form_Email : Form
    {
        private static Form_Email FormEmail;

        public Form_Email()
        {
            InitializeComponent();
            FormEmail = this;
        }

        public void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        public void button1_Click(object sender, System.EventArgs e)
        {

        }

        public void button1_Click_1(object sender, System.EventArgs e)
        {

        }

        public void button1_Click_2(object sender, System.EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, System.EventArgs e)
        {

        }

        public string setFromTextBox
        {
            get { return email_sourceTXT.Text; }
            set { email_sourceTXT.Text = value; }
        }

        public string BodyTextBox
        {
            get{ return email_bodyTXT.Text; }
            set{ email_bodyTXT.Text = value; }
        }

        private void Form_Email_Load(object sender, System.EventArgs e)
        {
            Get_Body(1);
        }

        public void SetBodyTextBox(string text)
        {
            BodyTextBox = text;
        }
    }
}
