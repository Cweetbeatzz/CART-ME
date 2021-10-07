using CART_ME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CART_ME.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult GetProducts()
        {
            //ViewBag.ProductsModel = prod;
            return View();
        }
    }
}