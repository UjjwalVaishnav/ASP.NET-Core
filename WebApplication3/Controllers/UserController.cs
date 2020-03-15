using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        private readonly IAddUserDetails addUserDetails;
        public UserController(IAddUserDetails addUserDetails)
        {
            this.addUserDetails = addUserDetails;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User userDetail)
        {

            addUserDetails.AddUsers(userDetail);
            return View("index");

        }
        //public ActionResult List(string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        UserListViewModel userListViewModel = new UserListViewModel()
        //        {
        //            userListViewModel = addUserDetails.GetUser.OrderBy(p => p.Name)
        //        };
        //        return View();
        //    }
        //    else
        //        return View();
        //}
    }
}
