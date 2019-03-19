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
  public partial class Form_FileManager : Form
  {
    public Form_FileManager()
    {
      InitializeComponent();
      treeView1.ExpandAll(); // Automatically expands all folders
    }

    private void toolStripComboBox1_Click(object sender, EventArgs e)
    {

    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {

    }
  }
}
