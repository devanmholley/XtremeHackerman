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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void btn_internet_Click(object sender, EventArgs e)
        {
            // This opens the internet browser
            XtremeHackermanForms._formBrowser.ShowDialog();
        }
    }
}