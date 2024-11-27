using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex05
{
    public partial class frmbai5 : Form
    {
        public frmbai5()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        // Khởi tạo TreeView với các node từ A đến Z
        private void InitializeTreeView()
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                TreeNode node = new TreeNode(letter.ToString());
                treeView1.Nodes.Add(node);
            }
        }

        // Sự kiện khi nhấn nút "Add Name"
        private void btnAddName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter both First Name and Last Name.");
                return;
            }

            // Lấy ký tự đầu của tên
            char firstChar = firstName.ToUpper()[0];
            TreeNode parentNode = treeView1.Nodes.Cast<TreeNode>().FirstOrDefault(node => node.Text == firstChar.ToString());

            if (parentNode != null)
            {
                // Thêm tên vào node tương ứng với ký tự đầu
                parentNode.Nodes.Add($"{lastName}, {firstName}");
                parentNode.Expand();
            }
        }

        // Sự kiện khi chọn một tên trong TreeView
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Chỉ thực hiện nếu chọn một node con (tên người)
            if (e.Node.Parent != null)
            {
                string[] nameParts = e.Node.Text.Split(',');
                txtLastName.Text = nameParts[0].Trim();
                txtFirstName.Text = nameParts[1].Trim();
            }
        }

        // Sự kiện tìm kiếm người theo tên
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            foreach (TreeNode node in treeView1.Nodes)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    if (subNode.Text.ToLower().Contains(searchText))
                    {
                        treeView1.SelectedNode = subNode;
                        subNode.EnsureVisible();
                        txtFirstName.Text = subNode.Text.Split(',')[1].Trim();
                        txtLastName.Text = subNode.Text.Split(',')[0].Trim();
                        return;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
