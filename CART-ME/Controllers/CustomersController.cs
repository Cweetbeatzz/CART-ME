using CART_ME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CART_ME.Controllers
{
    public class CustomersController : Controller
    {


        // GET: Customers
        public ActionResult Customers()
        {
            List<CustomersModel> CustomerList = new List<CustomersModel>()
            {
                new CustomersModel()
                {
                     Firstname = "ojo",
                     Lastname = "Emmanuel",
                     Email = "Ojo.emmanuel@Outlook.com",
                     Password = "123456789",
                     confirm_password = "123456789",
                },
                new CustomersModel()
                {
                     Firstname = "Bumi",
                     Lastname = "Temi",
                     Email = "Bumi.Temi@Outlook.com",
                     Password = "123456789",
                     confirm_password = "123456789",
                },
                new CustomersModel()
                {
                     Firstname = "Shade",
                     Lastname = "Layo",
                     Email = "Shade.Layo@Outlook.com",
                     Password = "123456789",
                     confirm_password = "123456789",
                }

            };


            //CustomersModel customers = new CustomersModel()
            //{
            //    Firstname = "ojo",
            //    Lastname = "Emmanuel",
            //    Email = "Ojo.emmanuel@Outlook.com",
            //    Password = "123456789",
            //    confirm_password = "123456789",
            //};

            ViewBag.CustomersModel = CustomerList;
            return View();
        }



    }
}
