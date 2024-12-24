using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02_NguyenHuuHoang.Controllers
{
    public class TestViewController : Controller
    {
        // GET: TestView
        // Dùng Layout mặc định
        public ActionResult DungLayoutMacDinh()
        {
            return View();
        }
        // Dùng Layout chỉ định
        public ActionResult DungLayoutChiDinh()
        {
            return View();
        }
        // Không dùng Layout 
        public ActionResult KhongDungLayout()
        {
            return View();
        }
        // Dùng Layout từ đường dẫn không cùng controller
        public ActionResult DungLayoutControllerKhac()
        {
            return View("~/Views/Home/About,");
        }
        // 
        public ActionResult TruyenDuLieu()
        {
            ViewData["HoTen"] = "Nguyễn Hữu Hoàng";
            ViewBag.QueQuan = "Thái Bình";
            TempData["Tuổi"] = "21";
            // return View();
            return RedirectToAction("DungLayoutChiDinh");
        }

        // Giải phương trình ax + b = 0
        public ActionResult GiaiPhuongTrinhBac1(decimal x, decimal y)
        {
            ViewBag.a = x;
            ViewBag.b = y;
            return View();
        }

        // In ra các số lẻ từ 1 đến n
        public ActionResult InCacSoLe(int n)
        {
            ViewBag.x = n;
            return View();
        }

        // In và tính tổng các phần tử lẻ trong mảng
        public ActionResult TinhTongCacSoLe(int[] a)
        {
            ViewBag.x = a;     
            return View();
        }

        public ActionResult TestHTMLHelper()
        {            
            return View();
        }
    }
}