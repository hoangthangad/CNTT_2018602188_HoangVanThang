using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoangVanThang2018602188.Models;

namespace HoangVanThang2018602188.Controllers
{
    public class ContactController : Controller
    {
      
        // GET: Contact
        public ActionResult Index(string id)
        {
            return View();
        }
    }
}