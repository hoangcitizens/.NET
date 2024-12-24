using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lab06_NguyenHuuHoang_1_11.Models;

namespace lab06_NguyenHuuHoang_1_11.Controllers
{
    public class OrdersController : Controller
    {
        private ShopDataContext db = new ShopDataContext();

        // GET: Orders
        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Customer);
            //orders = orders.OrderBy(o => o.Price); // Sắp xếp theo chiều tăng dần của giá
            orders = orders.OrderByDescending(o => o.Quantity); // Sắp xếp theo chiều giảm dần theo số lượng
            var sophantu = orders.Count();
            //var kiemtra = orders.All(u => u.Price > 10000); // Kiểm tra tất cả đơn giá có lớn hơn 10k không
            // var kiemtra = orders.Any(u => u.Price > 12000); // kiểm tra Any(bất kỳ) 1 cái duy nhất là trả về true ;
            orders = orders.Skip(1).Take(2); // Bỏ qua phần tử đầu tiên Chỉ lấy 2 phần tử
            return View(orders.ToList());
        }
        public ActionResult TimKiem()
        {
            var orders = db.Orders.Include(o => o.Customer);
            // orders = orders.Where(o => o.Customer.Name.Contains("Hoàng"));
            var thanhtienmax = orders.Max(u => u.Price * u.Quantity);
            var thanhtienmin = orders.Min(u => u.Price * u.Quantity);
            var trungbinhthanhtien = orders.Average(u => u.Price * u.Quantity);
            var tongthanhtien = orders.Sum(u => u.Price * u.Quantity);
            orders = orders.Where(o => o.Quantity == thanhtienmax);
            ViewBag.thanhtienmax = thanhtienmax;
            ViewBag.thanhtienmin = thanhtienmin;
            ViewBag.trungbinhthanhtien = trungbinhthanhtien;
            ViewBag.tongthanhtien = tongthanhtien;
            return View(orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductName,Price,Quantity,CustomerId")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", order.CustomerId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", order.CustomerId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductName,Price,Quantity,CustomerId")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "Name", order.CustomerId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
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
