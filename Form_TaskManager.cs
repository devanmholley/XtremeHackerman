using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman
{
    public partial class Form_TaskManager : Form
    {
        public Form_TaskManager()
        {
            InitializeComponent();
        }

        Process[] proc;

        void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach(Process p in proc)
            {
                listBox1.Items.Add(p.ProcessName);
                listBox1.Items.Add(p.PagedMemorySize64);
                //listBox1.Items.Add(item: p.StartTime);
                
                    
            }
            listBox2.Items.Clear();
            foreach (Process p in proc)
            {
                listBox2.Items.Add(p.ProcessName);
                listBox2.Items.Add(p.PagedMemorySize64);
                //listBox2.Items.Add(item: p.StartTime);
                

            }
        }

        private void Form_TaskManager_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void BtnEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                proc[listBox1.SelectedIndex].Kill();
                proc[listBox2.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
