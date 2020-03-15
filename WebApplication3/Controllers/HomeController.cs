using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(User admin)
        {
            var id = from u in db.user
                     where u.Email == admin.Email
                     select u;
            foreach(var i in id)
            {
                ViewBag.Role = i.UserId;
            }
            var _admin = db.user.Where(s => s.Email == admin.Email);
                if (_admin.Where(s => s.Password == admin.Password).Any())
                {
                // HttpContext.Session.SetInt32("uid", admin.UserId);

                return RedirectToAction("index", "Post");
                }
                else
                {
                    return View();
                }
           
        }
        public ActionResult User()
        {

            return View("../user/index");
        }
        
    }
}
