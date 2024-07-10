using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form2 : Form
    {
        List<SinhVien> dssv = new List<SinhVien>();
        public Form2()
        {
            InitializeComponent();
        }
        public void loadSv()
        {
            listView1.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                ListViewItem item = new ListViewItem(sv.MaSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToShortDateString());
                item.SubItems.Add(sv.GioiTinh);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.SoDienThoai);
                listView1.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = txtMaSinhVien.Text;
            sv.HoTen = txtHoVaTen.Text;
            sv.NgaySinh = dateTimePicker1.Value;
            if (radNam.Checked == true)
                sv.GioiTinh = "Nam";
            else if (radNu.Checked == true)
                sv.GioiTinh = "Nữ";
            sv.DiaChi = txtDiaChi.Text;
            sv.Email = txtEmail.Text;
            sv.SoDienThoai = txtSoDienThoai.Text;
            dssv.Add(sv);
            loadSv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự có muốn xóa", "Xác thực xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    dssv.RemoveAt(listView1.SelectedIndices[0]);
                    loadSv();
                }
                else
                    MessageBox.Show("Vui lòng chọn 1 phần tử muốn xóa", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin này", "Xác thực chọn",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    SinhVien sv = dssv[listView1.SelectedIndices[0]];
                    sv.MaSV = txtMaSinhVien.Text;
                    sv.HoTen = txtHoVaTen.Text;
                    sv.NgaySinh = dateTimePicker1.Value;
                    if (radNam.Checked == true)
                        sv.GioiTinh = "Nam";
                    else if (radNu.Checked == true)
                        sv.GioiTinh = "Nữ";
                    sv.DiaChi = txtDiaChi.Text;
                    sv.Email = txtEmail.Text;
                    sv.SoDienThoai = txtSoDienThoai.Text;
                    loadSv();
                }
                else
                    MessageBox.Show("Vui lòng chọn 1 thông tin muốn sửa", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string maSinhVien = selectedItem.SubItems[0].Text;
                string hovaten = selectedItem.SubItems[1].Text;
                string ngaysinh = selectedItem.SubItems[2].Text;
                string gioitinh = selectedItem.SubItems[3].Text;
                string diachi = selectedItem.SubItems[4].Text;
                string email = selectedItem.SubItems[5].Text;
                string sdt = selectedItem.SubItems[6].Text;
                txtMaSinhVien.Text = maSinhVien;
                txtHoVaTen.Text = hovaten;
                dateTimePicker1.Text = ngaysinh;
                if (gioitinh == "Nam")
                    radNam.Checked = true;
                else if (gioitinh == "Nữ")
                    radNu.Checked = true;
                txtDiaChi.Text = diachi;
                txtEmail.Text = email;
                txtSoDienThoai.Text = sdt;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            List<SinhVien> timkiem = dssv.FindAll(sv =>
                sv.MaSV.ToLower().Contains(keyword) ||
                sv.HoTen.ToLower().Contains(keyword) ||
                sv.NgaySinh.ToString().Contains(keyword) ||
                sv.GioiTinh.ToLower().Contains(keyword) ||
                sv.Email.ToLower().Contains(keyword) ||
                sv.SoDienThoai.ToLower().Contains(keyword)
            );
            listView1.Items.Clear();
            foreach (SinhVien sv in timkiem)
            {
                ListViewItem item = new ListViewItem(sv.MaSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToShortDateString());
                item.SubItems.Add(sv.GioiTinh);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.SoDienThoai);
                listView1.Items.Add(item);
            }
        }
    }
}


