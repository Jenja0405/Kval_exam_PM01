using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class FormGlavnaja : Form
    {
        public static string adr_file;
        public FormGlavnaja()
        {
            InitializeComponent();
    }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez = openFileDialog1.ShowDialog();
            if (rez == DialogResult.OK)
            {
                adr_file = openFileDialog1.FileName;
                panel1.Visible = true;
            }

        }
    }
}
