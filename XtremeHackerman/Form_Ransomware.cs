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
    public partial class Form_Ransomware : Form
    {
        public Form_Ransomware()
        {
            InitializeComponent();

            // Create and set the expiration date.
            DateTime currentDate = DateTime.Now;            // this current date will be used to create the timer later.
            DateTime expiryDate = DateTime.Now.AddDays(3);
            Label_date.Text = expiryDate.ToString();
        }

        private void Btn_Next_Ransom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
