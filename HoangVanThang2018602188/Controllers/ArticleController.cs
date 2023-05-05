using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoangVanThang2018602188.Models;

namespace HoangVanThang2018602188.Controllers
{
    public class ArticleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Article
        public ActionResult Index(string alias)
        {
            var item = db.Posts.FirstOrDefault(x => x.Alias == alias);
            return View(item);
        }
    }
}