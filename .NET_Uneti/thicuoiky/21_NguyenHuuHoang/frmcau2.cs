using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_NguyenHuuHoang
{
    public partial class frmcau2 : Form
    {
        public frmcau2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Text(*.txt)|*.txt";
            f.InitialDirectory = @"D:\";
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(f.FileName, RichTextBoxStreamType.RichText);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Text(*.txt)|*.txt";
            f.InitialDirectory = @"D:\";
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(f.FileName, RichTextBoxStreamType.RichText);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = f.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = f.Color;
        }
    }
}
