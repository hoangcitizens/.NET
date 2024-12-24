using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab08_NguyenHuuHoang_DHTI15A5HN_15_11.Models;

namespace Lab08_NguyenHuuHoang_DHTI15A5HN_15_11.Controllers
{
    public class BooksController : Controller
    {
        private BookEntities db = new BookEntities();

        // GET: Books
        public ActionResult Index()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            return View(books.ToList());
        }
        public ActionResult TimKiem(string searchString)
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            return View(books.ToList());
        }
        public ActionResult TinhToan()
        {
            var SumPrice = db.Books
                //.Where(b => b.Author.AuthorName.Contains("Anh"))
                .Sum(b => b.Price);
            var MaxPrice = db.Books.Max(b => b.Price);
            var MinPrice = db.Books.Min(b => b.Price);
            var AVGPrice = db.Books.Average(b => b.Price);
            var MaxPriceBooks = db.Books.Where(b => b.Price == MaxPrice);
            ViewBag.SumPrice = SumPrice;
            ViewBag.MaxPrice = MaxPrice;
            ViewBag.MinPrice = MinPrice;
            ViewBag.AVGPrice = AVGPrice;
            string thongbao;
            var kt = db.Books.Any(b => b.Price > 200000);
            if (kt == true)
                thongbao = "Có cuốn sách có giá > 20000";
            else
                thongbao = "Không có cuốn sách có giá > 20000";
            ViewBag.thongbao = thongbao;

            var sopt = db.Books.Count();
            var sosachcuaanh = db.Books.Count(b => b.Author.AuthorName.Contains("Anh"));
            ViewBag.sosachcuaanh = sosachcuaanh;
            return View(MaxPriceBooks.ToList());
        }

        public ActionResult HaiCuonSachGiaMax()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            books = books.OrderByDescending(b => b.Price).Skip(1).Take(2); // Skip(1) : bỏ qua sách 1 quyển đầu tiên, Take(2) : hiển thị 2 sách
            return View(books.ToList());
        }

        public ActionResult SachGiaLH20()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            books = books.Where(b => b.Price > 20000 && b.Author.AuthorName.Contains("Anh"));
            return View(books.ToList());
        }

        public ActionResult SapXep()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            //books = books.OrderBy(b => b.Title); // Sắp xếp chiều tăng dần alpha B
            books = books.OrderBy(b => b.Price); // Sắp xếp chiều tăng dần giá
            //books = books.OrderByDescending(b => b.Price); // Sắp xếp chiều giảm dần giá
            return View(books.ToList());
        }

        public ActionResult FirstBookTacGiaAnh()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            var book = books.FirstOrDefault(b=>b.Author.AuthorName.Contains("Anh"));
            return View(book);
        }
        public ActionResult SelectTilePrice() // Phép chiếu
        {
            var books = db.Books.Select(b => new BookViewModel{ Title = b.Title, Price = b.Price });           
            return View(books.ToList());
        }
        public ActionResult GroupedBookByCategory()
        {
            var gBooks = db.Books.GroupBy(b => b.Category.CategoryName)
                .Select(g => new BookByCategory
                { CategoryName=g.Key, BookCount=g.Count(), PriceSum=g.Sum(b=>b.Price)});
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            return View(books.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            ViewBag.AuthorID = new SelectList(db.Authors, "AuthorID", "AuthorName");
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookID,Title,AuthorID,Price,Images,CategoryID,Description,Published,ViewCount")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorID = new SelectList(db.Authors, "AuthorID", "AuthorName", book.AuthorID);
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", book.CategoryID);
            return View(book);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorID = new SelectList(db.Authors, "AuthorID", "AuthorName", book.AuthorID);
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", book.CategoryID);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookID,Title,AuthorID,Price,Images,CategoryID,Description,Published,ViewCount")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorID = new SelectList(db.Authors, "AuthorID", "AuthorName", book.AuthorID);
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", book.CategoryID);
            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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
