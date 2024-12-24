using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using De32.Models;

namespace De32.Controllers
{
    public class HoaDonBanController : Controller
    {
        private QLSachEntities db = new QLSachEntities();

        // GET: HoaDonBan
        public ActionResult Index()
        {
            var hoaDonBans = db.HoaDonBans.Include(h => h.KhachHang).Include(h => h.Sach);
            return View(hoaDonBans.ToList());
        }
        // Tìm kiếm theo tên khách hàng
        public ActionResult Timkiem(string txtTenKH)
        {
            string ten = txtTenKH.Trim().ToLower();
            var ds = db.HoaDonBans.Include("Sach").Include("KhachHang").Where(x => x.KhachHang.HoTen.Contains(ten)).ToList();
            return View("Index", ds);
        }
        // Đưa ra doanh thu cao nhất 
        public ActionResult DoanhThuMax()
        {
            // Tính tổng doanh thu theo mã sách
            var ds = db.HoaDonBans.Include("Sach").GroupBy(x => x.MaSach).Select(g => new
            {
                MaSach = g.Key,
                TenSach = g.FirstOrDefault().Sach.TenSach,
                TheLoai = g.FirstOrDefault().Sach.TheLoai,
                DonGia = g.FirstOrDefault().Sach.DonGia,
                SoLuongTon = g.FirstOrDefault().Sach.SoLuongTon,
                Tongtien = g.Sum(x => x.SoLuong * x.Sach.DonGia)
            }).ToList();
            // bước 2 -Tìm max
            decimal max = 0;
            if (ds.Any()) max = ds.Max(x => x.Tongtien);
            ViewBag.Max = max;  // gửi biến Max lên View thông qua đối tượng ViewBag
            // Bước 3 Đưa ra danh sách max - Ở bài này, cô làm thêm 1 cách khác cách lần trước đó là cô không tạo kiểu dữ liệu mới mà cô dùng Viewbag
            var dsmax = ds.Where(x => x.Tongtien == max).Select(x => new Sach
            {
                MaSach = x.MaSach,
                TenSach = x.TenSach,
                TheLoai = x.TheLoai,
                DonGia = x.DonGia,
                SoLuongTon = x.SoLuongTon
            }).ToList();
            return View(dsmax);
        }
        // Hiển thị danh sách hoá đơn có số lượng nhiều nhất
        public ActionResult SoluongMax()
        {
            HoaDonBan hd = db.HoaDonBans.OrderByDescending(x => x.SoLuong).FirstOrDefault();
            int max = 0;
            if (hd != null) max = hd.SoLuong;
            var dsmax = db.HoaDonBans.Where(x => x.SoLuong == max).ToList();
            return View(dsmax);
        }
        // GET: HoaDonBan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            if (hoaDonBan == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonBan);
        }

        // GET: HoaDonBan/Create
        public ActionResult Create()
        {
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen");
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach");
            return View();
        }

        // POST: HoaDonBan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHD,MaSach,MaKH,NgayBan,SoLuong")] HoaDonBan hoaDonBan)
        {
            if (ModelState.IsValid)
            {
                db.HoaDonBans.Add(hoaDonBan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", hoaDonBan.MaKH);
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBan.MaSach);
            return View(hoaDonBan);
        }

        // GET: HoaDonBan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            if (hoaDonBan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", hoaDonBan.MaKH);
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBan.MaSach);
            return View(hoaDonBan);
        }

        // POST: HoaDonBan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHD,MaSach,MaKH,NgayBan,SoLuong")] HoaDonBan hoaDonBan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoaDonBan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKH = new SelectList(db.KhachHangs, "MaKH", "HoTen", hoaDonBan.MaKH);
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", hoaDonBan.MaSach);
            return View(hoaDonBan);
        }

        // GET: HoaDonBan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            if (hoaDonBan == null)
            {
                return HttpNotFound();
            }
            return View(hoaDonBan);
        }

        // POST: HoaDonBan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoaDonBan hoaDonBan = db.HoaDonBans.Find(id);
            db.HoaDonBans.Remove(hoaDonBan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
