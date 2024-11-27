using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._3_Menu_VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            DialogResult kq = dl.ShowDialog();
            if (kq == DialogResult.OK)
            {
                StreamReader f = new StreamReader(dl.FileName);
                richTextBox1.Text = f.ReadToEnd();
                f.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dl = new SaveFileDialog();
            DialogResult kq = dl.ShowDialog();
            if (kq == DialogResult.OK)
            {
                StreamWriter f = new StreamWriter(dl.FileName);
                foreach (string line in richTextBox1.Lines)
                {
                    f.WriteLine(line);
                }
                f.Close();
            }      
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
