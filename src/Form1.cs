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
                Uri uri = new Uri(adr_file);
                webBrowser1.Url = uri;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1);
            double y = Convert.ToDouble(textBox2);

            if (proverka1(x, y) == true)
                MessageBox.Show("входит в область");
            else
                MessageBox.Show("не входит в область");
        }
        public static bool proverka1(double x, double y)
        {
            if (x < -8 || y < -3 || y > 4 || x > 10)
                return false;
            if ((x >= -8 && x <= 10) && (y <= 0 && y >= -3))
                return true;
            if ((x >= -4) && (x <= 4) && (y >= -3 && y <= 4))
                return true;
            else return false;
        }
    }
}
