using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05_lab04
{
    public partial class frmbai5 : Form
    {
        public frmbai5()
        {
            InitializeComponent();
        }

        private void frmbai5_Load(object sender, EventArgs e)
        {
            // Lấy danh sách tất cả các font chữ hiện có trên hệ thống
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name); // Thêm tên font vào ComboBox
            }

            comboBoxFont.SelectedIndexChanged += comboBoxFont_SelectedIndexChanged;
        }

        // Khi người dùng chọn font chữ trong ComboBox
        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = comboBoxFont.SelectedItem.ToString(); // Lấy font được chọn

            // Đặt font mới cho văn bản trong RichTextBox
            if (!string.IsNullOrEmpty(selectedFont))
            {
                richTextBoxVanBan.Font = new Font(selectedFont, richTextBoxVanBan.Font.Size);
            }
        }
    }
}
