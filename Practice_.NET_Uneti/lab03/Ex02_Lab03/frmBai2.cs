using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_Lab03
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            rtbHauTo.Visible = false; // Ẩn RichTextBox biểu thức hậu tố
            btnChuyenHauTo.Enabled = false; // Vô hiệu hóa nút "Chuyển hậu tố"
            btnThoat.Enabled = true; // Nút "Thoát" luôn sáng
        }

        private void rtbTrungTo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbTrungTo.Text))
            {
                btnChuyenHauTo.Enabled = true; // Bật nút "Chuyển hậu tố" khi người dùng nhập biểu thức
            }
            else
            {
                btnChuyenHauTo.Enabled = false; // Vô hiệu hóa nếu người dùng xóa hết nội dung
            }
        }

        // Khi nhấn nút "Chuyển hậu tố"
        private void btnChuyenHauTo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTrungTo.Text))
            {
                MessageBox.Show("Vui lòng nhập biểu thức trung tố.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vô hiệu hóa RichTextBox trung tố sau khi chuyển đổi
            rtbTrungTo.Enabled = false;

            // Thực hiện chuyển đổi từ biểu thức trung tố sang hậu tố
            string infixExpression = rtbTrungTo.Text;
            string postfixExpression = ConvertToPostfix(infixExpression);

            // Hiển thị biểu thức hậu tố
            rtbHauTo.Visible = true;
            rtbHauTo.Text = postfixExpression;
        }

        // Khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kết thúc chương trình
        }

        // Chuyển biểu thức trung tố sang hậu tố
        private string ConvertToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder result = new StringBuilder();

            foreach (char c in infix)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result.Append(c); // Nếu là số hoặc chữ thì thêm vào kết quả
                }
                else if (c == '(')
                {
                    stack.Push(c); // Nếu là dấu mở ngoặc thì đưa vào stack
                }
                else if (c == ')')
                {
                    // Nếu là dấu đóng ngoặc thì pop các toán tử cho đến khi gặp dấu mở ngoặc
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result.Append(stack.Pop());
                    }
                    stack.Pop(); // Loại bỏ dấu mở ngoặc
                }
                else
                {
                    // Xử lý các toán tử
                    while (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        result.Append(stack.Pop());
                    }
                    stack.Push(c); // Thêm toán tử vào stack
                }
            }

            // Pop các toán tử còn lại trong stack
            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
            }

            return result.ToString();
        }

        // Độ ưu tiên của các toán tử
        private int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
