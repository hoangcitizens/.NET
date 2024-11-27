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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework_Ex05
{
    public partial class frmbai5 : Form
    {
        public frmbai5()
        {
            InitializeComponent();
            
        }
        // Tạo tệp mẫu
        private void CreateSampleFile()
        {           
            string filePath = "SVCK.data";
          
            List<string> studentData = new List<string>
            {
                "SV001,Nguyễn Hữu Hoàng,Thái Bình,2003,8.5,9.0",
                "SV002,Nguyễn Hồng Anh,Hải Phòng,2006,7.5,8.0",
                "SV003,Trần Văn Tuấn,Hà Nội,2005,3.0,3.5",
                "SV004,Phạm Thu Hương,TP Hồ Chí Minh,2004,7.5,9.0",
                "SV005,Lê Quang Hải,Đà Nẵng,2006,1.5,3.5"
            };
            
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string student in studentData)
                {
                    sw.WriteLine(student);
                }
            }

            MessageBox.Show("File SVCK.data đã được tạo thành công với dữ liệu mẫu!");
        }
        public List<SinhVienKhoaCoKhi> ReadFromFile(string filePath)
        {
            List<SinhVienKhoaCoKhi> danhSachSV = new List<SinhVienKhoaCoKhi>();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] details = line.Split(',');
                        SinhVienKhoaCoKhi sv = new SinhVienKhoaCoKhi(details[0], details[1], details[2], int.Parse(details[3]), double.Parse(details[4]), double.Parse(details[5]));
                        danhSachSV.Add(sv);
                    }
                }
            }
            return danhSachSV;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisableTextboxes()
        {
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtNamSinh.Enabled = false;
            txtDiemVeKT.Enabled = false;
            txtDiemCNC.Enabled = false;
        }
        private void frmbai5_Load(object sender, EventArgs e)
        {
            CreateSampleFile();
            // Vô hiệu hóa các textbox
            DisableTextboxes();
        }
        private void EnableTextboxes()
        {
            txtMaSV.Enabled = true;
            txtTenSV.Enabled = true;
            txtNamSinh.Enabled = true;
            txtDiemVeKT.Enabled = true;
            txtDiemCNC.Enabled = true;
        }
        private bool IsValidData()
        {
            // Kiểm tra xem các trường có trống không
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtTenSV.Text) ||
                string.IsNullOrEmpty(txtNamSinh.Text) || string.IsNullOrEmpty(txtDiemVeKT.Text) || string.IsNullOrEmpty(txtDiemCNC.Text))
            {
                MessageBox.Show("Vui lòng điền vào tất cả các trường.");
                return false;
            }

            // Xác thực các giá trị số (năm sinh, điểm số)
            if (!int.TryParse(txtNamSinh.Text, out int namSinh) || txtNamSinh.Text.Length != 4)
            {
                MessageBox.Show("Năm sinh phải là số hợp lệ có 4 chữ số.");
                return false;
            }

            if (!double.TryParse(txtDiemVeKT.Text, out double diemVeKyThuat) ||
                !double.TryParse(txtDiemCNC.Text, out double diemCNC))
            {
                MessageBox.Show("Điểm phải là số.");
                return false;
            }

            return true;
        }
        private void WriteToFile(List<SinhVienKhoaCoKhi> danhSach)
        {
            using (StreamWriter sw = new StreamWriter("SVCK.data"))
            {
                foreach (SinhVienKhoaCoKhi sv in danhSach)
                {
                    sw.WriteLine($"{sv.MaSinhVien},{sv.HoTen},{sv.QueQuan},{sv.NamSinh},{sv.DiemVeKyThuat},{sv.DiemCNC}");
                }
            }
        }
        private void DisplayDataInListView(List<SinhVienKhoaCoKhi> danhSach)
        {
            listViewSinhVien.Items.Clear();
            foreach (SinhVienKhoaCoKhi sv in danhSach)
            {
                ListViewItem item = new ListViewItem(sv.MaSinhVien);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NamSinh.ToString());
                item.SubItems.Add(sv.DiemVeKyThuat.ToString());
                item.SubItems.Add(sv.DiemCNC.ToString());
                item.SubItems.Add(sv.TinhDiemTB().ToString());
                listViewSinhVien.Items.Add(item);
            }
        }
        private void ClearTextboxes()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtNamSinh.Clear();
            txtDiemVeKT.Clear();
            txtDiemCNC.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                EnableTextboxes(); 
                btnThem.Text = "Lưu"; 
            }
            else if (btnThem.Text == "Lưu")
            {
                // Xác thực dữ liệu và lưu vào file
                if (IsValidData())
                {
                    // Tạo một thể hiện sinh viên mới với dữ liệu đã nhập
                    SinhVienKhoaCoKhi newStudent = new SinhVienKhoaCoKhi
                    (
                        txtMaSV.Text,
                        txtTenSV.Text,
                        "",
                        int.Parse(txtNamSinh.Text),
                        double.Parse(txtDiemVeKT.Text),
                        double.Parse(txtDiemCNC.Text)
                    );

                    // Đọc danh sách sinh viên hiện tại từ tệp
                    List<SinhVienKhoaCoKhi> danhSach = ReadFromFile("SVCK.data");

                    // Thêm học sinh mới vào danh sách
                    danhSach.Add(newStudent);

                    // Ghi danh sách đã cập nhật trở lại tệp
                    WriteToFile(danhSach);

                    btnThem.Text = "Thêm"; // Đặt lại nút thành "Thêm"
                    ClearTextboxes(); // Xóa sạch textbox
                    DisableTextboxes(); // Vô hiệu hóa textbox một lần nữa
                }
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            List<SinhVienKhoaCoKhi> danhSach = ReadFromFile("SVCK.data");
            listViewSinhVien.Items.Clear();
            foreach (SinhVienKhoaCoKhi sv in danhSach)
            {
                ListViewItem item = new ListViewItem(sv.MaSinhVien);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NamSinh.ToString());
                item.SubItems.Add(sv.DiemVeKyThuat.ToString());
                item.SubItems.Add(sv.DiemCNC.ToString());
                item.SubItems.Add(sv.TinhDiemTB().ToString());
                listViewSinhVien.Items.Add(item);
            }
        }

        private void btnSVTruot_Click(object sender, EventArgs e)
        {
            List<SinhVienKhoaCoKhi> danhSach = ReadFromFile("SVCK.data");
            listViewSinhVien.Items.Clear();
            foreach (SinhVienKhoaCoKhi sv in danhSach)
            {
                if (sv.TinhDiemTB() < 5)
                {
                    ListViewItem item = new ListViewItem(sv.MaSinhVien);
                    item.SubItems.Add(sv.HoTen);
                    item.SubItems.Add(sv.NamSinh.ToString());
                    item.SubItems.Add(sv.DiemVeKyThuat.ToString());
                    item.SubItems.Add(sv.DiemCNC.ToString());
                    item.SubItems.Add(sv.TinhDiemTB().ToString());
                    listViewSinhVien.Items.Add(item);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listViewSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa!", "Thông báo");
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                // Lấy thông tin sinh viên được chọn
                ListViewItem selectedItem = listViewSinhVien.SelectedItems[0];
                txtMaSV.Text = selectedItem.SubItems[0].Text;
                txtTenSV.Text = selectedItem.SubItems[1].Text;
                txtNamSinh.Text = selectedItem.SubItems[2].Text;
                txtDiemVeKT.Text = selectedItem.SubItems[3].Text;
                txtDiemCNC.Text = selectedItem.SubItems[4].Text;

                // Bật các textbox, trừ mã sinh viên
                txtMaSV.Enabled = false;
                txtTenSV.Enabled = true;
                txtNamSinh.Enabled = true;
                txtDiemVeKT.Enabled = true;
                txtDiemCNC.Enabled = true;

                btnSua.Text = "Cập nhật";
            }
            else if (btnSua.Text == "Cập nhật")
            {
                // Kiểm tra dữ liệu hợp lệ và cập nhật thông tin sinh viên
                // (tương tự như trong nút "Lưu" của chức năng "Thêm")
                // Sau khi cập nhật, ghi lại tệp và hiển thị lại danh sách
                btnSua.Text = "Sửa";
                DisableTextboxes();
            }
        }
        private void UpdateStudentData()
        {
            if (listViewSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa");
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                // Tải dữ liệu học sinh đã chọn vào textbox
                ListViewItem selectedItem = listViewSinhVien.SelectedItems[0];
                txtMaSV.Text = selectedItem.SubItems[0].Text;
                txtTenSV.Text = selectedItem.SubItems[1].Text;
                txtNamSinh.Text = selectedItem.SubItems[2].Text;
                txtDiemVeKT.Text = selectedItem.SubItems[3].Text;
                txtDiemCNC.Text = selectedItem.SubItems[4].Text;

                // Cho phép các textbox ngoại trừ MaSV
                txtTenSV.Enabled = true;
                txtNamSinh.Enabled = true;
                txtDiemVeKT.Enabled = true;
                txtDiemCNC.Enabled = true;
                txtMaSV.Enabled = false; // Mã số sinh viên không được thay đổi

                btnSua.Text = "Cập nhật"; // Thay đổi văn bản nút thành "Cập nhật"
            }
            else if (btnSua.Text == "Cập nhật")
            {
                // Xác thực dữ liệu đầu vào
                if (IsValidData())
                {
                    // Cập nhật thông tin sinh viên
                    UpdateStudentData();
                    btnSua.Text = "Sửa";
                    DisableTextboxes();
                    ClearTextboxes();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listViewSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            ListViewItem selectedItem = listViewSinhVien.SelectedItems[0];
            string maSinhVien = selectedItem.SubItems[0].Text;

            DialogResult dialogResult = MessageBox.Show("Do you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteStudent(maSinhVien);
            }
        }
        private void DeleteStudent(string maSinhVien)
        {
            List<SinhVienKhoaCoKhi> danhSach = ReadFromFile("SVCK.data");

            // Xóa MaSinhVien trùng khớp
            danhSach.RemoveAll(sv => sv.MaSinhVien == maSinhVien);

            // Ghi danh sách đã cập nhật trở lại tệp
            WriteToFile(danhSach);
            DisplayDataInListView(danhSach); // Làm mới ListView sau khi xóa

            MessageBox.Show("Student deleted successfully.");
        }
    }
}
