using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week3_NguyenHuuHoang.Models;

namespace week3_NguyenHuuHoang.Controllers
{
    public class GiaiBaiToanController : Controller
    {
        public ActionResult NhanDL(Users u)
        {
            string msg = $"{u.Id}<br/>{u.Name}<br/>{u.Address}<br/>{u.Email}<br/>{u.Password}<br/>{u.Gender}<br/>";
            return Content(msg);
        }
        public ActionResult Truyen1DoiTuong()
        {
            var user = new Users
            {
                Id = 1,
                Name = "Hoàng",
                Address = "Thái Bình",
                Email = "hoang@gmail.com",
                Password = "123456",
                Gender = true
            };
            //ViewBag.user = user;
            return View(user);
        }
        // GET: GiaiBaiToan
        public ActionResult TimUCLN()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TimUCLN(int a,int b)
        {
            string msg = $"UCLN của {a} và {b} là: ";
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            msg += $"{a}";
            ViewBag.msg = msg;
            return View();
        }

        public ActionResult TruyenTapDoiTuong()
        {
            var users = new List<Users>
            {
                new Users
                {
                    Id = 1,
                    Name = "Hoàng",
                    Address = "Thái Bình",
                    Email = "hoang@gmail.com",
                    Password = "123456",
                    Gender = true
                },
                new Users
                {
                    Id = 2,
                    Name = "Vinh",
                    Address = "Hưng Yên",
                    Email = "vinh@gmail.com",
                    Password = "654321",
                    Gender = true
                },
                new Users
                {
                    Id = 3,
                    Name = "Đạt",
                    Address = "Hải Dương",
                    Email = "dat@gmail.com",
                    Password = "888888",
                    Gender = false
                }
            };
            //ViewBag.users = users;
            return View(users);
        }
        public ActionResult TimUCLN2(UCLN ucln)
        {
            int a = ucln.a;
            int b = ucln.b;
            string msg = $"UCLN của {a} và {b} là: ";
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            msg += $"{a}";
            ViewBag.msg = msg;
            return View();
        }
    }
}