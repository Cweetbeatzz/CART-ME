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
            var prod = new List<ProductsModel>()
            {
                new ProductsModel()
                {
                   id = 1,
                   Name = " Fair & White",
                   Description = " Complex Toning Skin Care Cream",
                   Category = "Lotion",
                   RetailPrice = 14,
                   QuantityInStock = 55
                },
                  new ProductsModel()
                {
                   id = 1,
                   Name = " CuteGlow",
                   Description = " Herbal Skin Care Cream",
                   Category = "Lotion",
                   RetailPrice = 20,
                   QuantityInStock = 13
                },
                    new ProductsModel()
                {
                   id = 1,
                   Name = " MaxBeauty",
                   Description = " Antiseptic Skin Care Cream",
                   Category = "Lotion",
                   RetailPrice = 28,
                   QuantityInStock = 5
                }
            };
            //ViewBag.ProductsModel = prod;
            return View(prod);
        }
    }
}