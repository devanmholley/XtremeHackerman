using System;
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
            DateTime expiryDate = DateTime.Now.AddDays(3);
            Label_date.Text = expiryDate.ToString();
        }
    }
}
