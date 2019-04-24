using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XtremeHackerman.Classes;
using XtremeHackerman.Properties;
using Newtonsoft.Json;

namespace XtremeHackerman
{
    public partial class Form_Wireshark : Form
    {
        public Form_Wireshark()
        {
            InitializeComponent();
        }

        private void Form_Wireshark_Load(object sender, EventArgs e)
        {

        }

        private void DisplayFilterText_TextChanged(object sender, EventArgs e)
        {
            // If the text is empty
            if (string.IsNullOrEmpty(DisplayFilterText.Text))
            {
                // Set Default Message
                DisplayFilterText.Text = "Apply a display filter...";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProfileStatus_Click(object sender, EventArgs e)
        {

        }

        private void WiFIConnectionBTN_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void EthernetConnectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EthernetConnectionPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EthernetConnectionBTN_Click(object sender, EventArgs e)
        {
            WiresharkEthernetData.JSONSerialize();
            //WiresharkEthernetData.JSONDeserialize();
            dynamic source = WiresharkEthernetData.JSONSerialize();
            var entry = JsonConvert.DeserializeObject<WiresharkEthernetData>(source);
            NumberFieldEntry.Text = entry.No;
            TimeFieldEntry.Text = entry.Time;
            SourceFieldEntry.Text = entry.Source;
            DestinationFieldEntry.Text = entry.Destination;
            ProtocolFieldEntry.Text = entry.Protocol;
            LengthFieldEntry.Text = entry.Length;
            InfoFieldEntry.Text = entry.Info;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
