using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Ex04
{
    public partial class frmbai4 : Form
    {
        // Khai báo danh sách các button đại diện cho bảng chữ cái
        private Button[] alphabetButtons;
        public frmbai4()
        {
            InitializeComponent();
            // Tạo các button cho bảng chữ cái
            alphabetButtons = new Button[] 
            { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM
             ,btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ};
        }

        // Sự kiện khi người dùng nhập liệu vào RichTextBox
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;
            if (char.IsLetter(keyChar))
            {
                // Đổi màu button tương ứng sang màu đỏ
                HighlightLetterButton(keyChar, Color.Red);
            }
        }
        
        // Sự kiện khi người dùng thả phím
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;
            if (char.IsLetter(keyChar))
            {
                // Trả lại màu đen cho button
                HighlightLetterButton(keyChar, Color.Black);
            }
        }

        // Đổi màu button theo ký tự
        private void HighlightLetterButton(char letter, Color color)
        {
            Button btn = alphabetButtons.FirstOrDefault
                (b => b.Text.Equals(letter.ToString(), StringComparison.OrdinalIgnoreCase));
            if (btn != null)
            {
                btn.ForeColor = color;
            }
        }

        // Sự kiện nhấn nút "Đếm số"
        private void btnDemSo_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            var distinctDigits = text.Where(char.IsDigit).Distinct();
            txtResult.Text = $"Số chữ số khác nhau có trong xâu = " +
                $"{distinctDigits.Count().ToString()}";
        }
    }
}
