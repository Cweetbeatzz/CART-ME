using CART_ME.Models;
using CART_ME.SQLconfig;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
           
            return View();
        }

        //########################################################################
        [HttpPost]
        public ActionResult CreateCustomer(CustomersModel customers)
        {
            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMERS(firstname, lastname, email,password, confirm_password)" +
                    " VALUES('" + customers.Firstname + "','" + customers.Lastname + "','" + customers.Email + "','" + customers.Password + "','" + customers.confirm_password + "',)"))
                {
                    if (cnn.State != System.Data.ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            return Content("Successful");
        }





    }
}
