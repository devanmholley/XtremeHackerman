﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeHackerman
{
    public partial class Form_TaskManager : Form
    {

        private static List<Process> tasks;
        private static List<Process> history;

        private Process process;
        
        



        public Form_TaskManager()
        {
            InitializeComponent();
            tasks = new List<Process>();
            history = new List<Process>();
        }

      



        private void TaskManager_Load(object sender, EventArgs e)
        {
            process = new Process();
            tasks.Add(process);
            
        }

        private void TaskView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Process p in tasks)
            {
                TaskView.Columns[0].ListView.Items.Add(p.Name);
                TaskView.Columns[1].ListView.Items.Add(p.Spawntime.ToString());
              
            }



        }

        private void HistoryView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Process p in history)
            {
                HistoryView.Columns[0].ListView.Items.Add(p.Name);
                HistoryView.Columns[1].ListView.Items.Add(p.StopTime.ToString());
                HistoryView.Items.Add(p.Name + " " + p.Spawntime.ToString("dd HH:mm:ss"));
                int ended = (int)DateTime.Now.Subtract(p.StopTime).TotalSeconds;
            }

        }

        private void BtnEndTask_Click_1(object sender, EventArgs e)
        {
            tasks.Remove(process);
            history.Add(process);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TaskView.Items.Clear();
            foreach (Process p in tasks)
            {
                TaskView.Items.Add(p.Name + " " + p.Spawntime.ToString("dd HH:mm:ss"));
                int elapsed = (int)DateTime.Now.Subtract(p.Spawntime).TotalSeconds;
            }
        }
    }








}
   

  
