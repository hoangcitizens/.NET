/*
    Bài 1. Kế thừa
    - Xây dựng lớp Người gồm có các thành phần Họ tên và Năm sinh. Viết các phương thức như hàm tạo không tham số, 
      hàm tạo nhiều tham số, hàm nhập, hiển thị dữ liệu.
    - Xây dựng lớp Thí sinh kế thừa lớp này, trong lớp Thí sinh có Số báo danh và Điểm các môn toán, lý, hóa.
    Hãy xây dựng thêm các hàm tạo, hàm nhập, xuất
    Viết chương trình với các công việc sau:
        -  Nhập vào một danh sách có n thí sinh
        -  Hiển thị danh sách thí sinh có tổng điểm ba môn tăng dần;
        -  Tìm một thí sinh khi biết Số báo danh.
        -  Thống kê xem có bao nhiêu phần trăm thí sinh đạt yêu cầu (cả ba môn có điểm lớn hơn hoặc bằng 5).
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());
            Candidates []cand = new Candidates[n];
            Candidates.importList(cand, n);
            // Hiển thị danh sách thí sinh vừa nhập
            Console.WriteLine("______________________________________________" +
               "DANH SÁCH THÍ SINH______________________________________________");
            Candidates.title();
            Candidates.displayList(cand, n);
            // Hiển thị danh sách thí sinh có tổng điểm ba môn tăng dần
            Candidates.upScore(cand, n);
            // Tìm một thí sinh khi biết Số báo danh
            Candidates.findID(cand, n);
            // Thống kê xem có bao nhiêu phần trăm thí sinh đạt yêu cầu(cả ba môn có điểm lớn hơn hoặc bằng 5).
            Candidates.statistical(cand, n);
            Console.ReadLine();
        }
    }
}
