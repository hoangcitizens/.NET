using QuanLyNguoiDung_week4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNguoiDung_week4.Controllers
{
    public class UsersController : Controller
    {
        public static List<Users> users = new List<Users>
        {
            new Users{Id=1, Name="Hoàng",Address="Thái Bình", Email="hoang@gmail.com",Password="123456",Age=21,Gender=true},
            new Users{Id=2, Name="Phượng",Address="Nam Định", Email="phuong@gmail.com",Password="123456",Age=18,Gender=false},
            new Users{Id=3, Name="Ly",Address="Hải Phòng", Email="ly@gmail.com",Password="123456",Age=20,Gender=false},
            new Users{Id=4, Name="Long",Address="Quảng Ninh", Email="long@gmail.com",Password="123456",Age=30,Gender=true}
        };
        // GET: Users
        public ActionResult Index()
        {           
            return View(users);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            List <SelectListItem> addressList = new List<SelectListItem>
            {
                new SelectListItem{Text="Thái Bình",Value="Thái Bình"},
                new SelectListItem{Text="Hải Phòng",Value="Hải Phòng"},
                new SelectListItem{Text="Quảng Ninh",Value="Quảng Ninh"},
                new SelectListItem{Text="Nam Định",Value="Nam Định"},
                new SelectListItem{Text="Hà Nội",Value="Hà Nội"}
            };
            ViewBag.addressList = new SelectList(addressList, "Value", "Text");
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(Users newUser)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    newUser.Id = users.Max(u => u.Id) + 1;
                    users.Add(newUser);
                    return RedirectToAction("Index");
                }
                return View(newUser);
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Users updateUsers)
        {
            try
            {
                // TODO: Add update logic here
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    return HttpNotFound();
                }    
                else if (ModelState.IsValid)
                {
                    user.Name = updateUsers.Name;
                    user.Address = updateUsers.Address;
                    user.Email = updateUsers.Email;
                    user.Age = updateUsers.Age;
                    user.Password = updateUsers.Password;
                    user.Gender = updateUsers.Gender;
                    return RedirectToAction("Index");
                }    
                return View(updateUsers);
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    users.Remove(user);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
