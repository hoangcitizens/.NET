using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void load()
        {
            TreeNode node = new TreeNode();
            node.Text = txt.Text;
            tree.Nodes.Add(node);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "All File|*.*";
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(f.FileName,RichTextBoxStreamType.RichText);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = f.Font; 

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton1.Checked == true)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }    
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
             if (toolStripButton3.Checked == true)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Bold);
            }    
        }
    }
}
