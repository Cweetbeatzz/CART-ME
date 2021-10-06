using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CART_ME.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            ViewBag.Name = " Ojo Emmanuel";
            ViewBag.PhoneNumber = " +2347032350521";
            return View();
        }
    }
}