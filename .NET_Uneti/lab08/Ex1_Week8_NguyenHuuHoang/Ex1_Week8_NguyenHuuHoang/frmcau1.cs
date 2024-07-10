using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Week8_NguyenHuuHoang
{
    public partial class frmcau1 : Form
    {
        public frmcau1()
        {
            InitializeComponent();
        }

        // save
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text(*.txt)|*.txt|RichText File(*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }    
        }

        // open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Text|*.txt|RichText File|*.rtf";
            f.FilterIndex = 1;
            f.InitialDirectory = @"D:\";
            if (f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(f.FileName, RichTextBoxStreamType.RichText);
            }
        }

        // clear
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        // CĂN LỀ TRÁI
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton1.Checked == true)
            {
                toolStripButton2.Checked = false;
                toolStripButton3.Checked = false;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripButton2.Checked == true)
            {
                toolStripButton1.Checked = false;
                toolStripButton3.Checked = false;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripButton3.Checked == true)
            {
                toolStripButton1.Checked = false;
                toolStripButton2.Checked = false;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        // IN ĐẬM
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripButton4.Checked == true)      
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Bold);
            else
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (toolStripButton5.Checked == true)
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Italic);
            else
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Italic);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (toolStripButton6.Checked == true)
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Underline);
            else
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Underline);
        }

        // FONT CHỮ
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = f.Font;
        }

        // MÀU CHỮ
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = f.Color;
        }

        private void mởFormBàiTậpTreeviewListviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcau2 f = new frmcau2();
            f.Show();
        }

        private void mởFormBàiTậpDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // thoát
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
