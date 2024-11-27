using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex02
{
    public partial class frmbai2 : Form
    {
        public frmbai2()
        {
            InitializeComponent();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateLabels()
        {
            label4.Text = $"Tổng số: {listBox1.Items.Count}";
            label5.Text = $"Tổng số: {listBox2.Items.Count}";
        }
        // Remove selected items from a ListBox
        private void RemoveSelectedItems(ListBox listBox)
        {
            while (listBox.SelectedItems.Count > 0)
            {
                listBox.Items.Remove(listBox.SelectedItems[0]);
            }
            UpdateLabels();
        }
        // Move selected items between ListBoxes
        private void MoveItems(ListBox source, ListBox target)
        {
            var selectedItems = source.SelectedItems;
            while (selectedItems.Count > 0)
            {
                target.Items.Add(selectedItems[0]);
                source.Items.Remove(selectedItems[0]);
            }
            UpdateLabels();
        }
        // Move all items between ListBoxes
        private void MoveAllItems(ListBox source, ListBox target)
        {
            foreach (var item in source.Items)
            {
                target.Items.Add(item);
            }
            source.Items.Clear();
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxNhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to the corresponding ListBox based on the selected group
            if (comboBoxNhom.SelectedItem.ToString() == "Nhóm 1")
            {
                listBox1.Items.Add(txtTenSV.Text);
            }
            else if (comboBoxNhom.SelectedItem.ToString() == "Nhóm 2")
            {
                listBox2.Items.Add(txtTenSV.Text);
            }

            txtTenSV.Clear();
            UpdateLabels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveItems(listBox1, listBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveItems(listBox2, listBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveAllItems(listBox1, listBox2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoveAllItems(listBox2, listBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                RemoveSelectedItems(listBox1);
            }
            else if (listBox2.SelectedItems.Count > 0)
            {
                RemoveSelectedItems(listBox2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MoveAllItems(listBox2, listBox1);
            MoveAllItems(listBox1, listBox2);
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxNhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to the corresponding ListBox based on the selected group
            if (comboBoxNhom.SelectedItem.ToString() == "Nhóm 1")
            {
                listBox1.Items.Add(txtTenSV.Text);
            }
            else if (comboBoxNhom.SelectedItem.ToString() == "Nhóm 2")
            {
                listBox2.Items.Add(txtTenSV.Text);
            }

            txtTenSV.Clear();
            UpdateLabels();
        }
    }
}
