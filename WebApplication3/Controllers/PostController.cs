using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class PostController : Controller
    {
        private readonly IAddPostData pd;

        private readonly IAddUserDetails ud;
        public int Id { get; set; }
        public PostController(IAddPostData pd,IAddUserDetails ud)
        {
            this.pd = pd;
            this.ud = ud;
        }
        // GET: Post
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index()
        {
            
            return View(from Post in pd.GetAllPost()
                        join User in ud.GetUser on Post.UserId equals User.UserId
                        select Post);
        }
        [HttpPost]
        public ActionResult Index(Post post)
        {

            pd.AddPosts(post);
            return RedirectToAction("index","Post");
        }
        public ActionResult post()
        {

            return View("post");
        }
    }
}
