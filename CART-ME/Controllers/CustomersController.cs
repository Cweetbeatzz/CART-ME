using CART_ME.Models;
using CART_ME.SQLconfig;
using System;
using System.Collections.Generic;
using System.Data;
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
        //########################################################################
        [HttpGet]
        public ActionResult GetAllCustomers()
        {
            List<CustomersModel> Customerlist = new List<CustomersModel>();

            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", cnn))
                {
                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                   SqlDataReader output =  cmd.ExecuteReader(); //FETCHING DATA FROM THE DATABASE

                    DataTable dt = new DataTable();

                    dt.Load(output); //LOADS ALL RECORDS RO A TABLE

                    foreach (DataRow datarows in dt.Rows)
                    {
                        Customerlist.Add
                            (
                             new CustomersModel
                             {
                                 Firstname = datarows["FirstName"].ToString(),
                                 Lastname = datarows["LastName"].ToString(),
                                 Email = datarows["Email"].ToString(),
                                 Password = datarows["Password"].ToString(),
                                 confirm_password = datarows["ConfirmPassword"].ToString(),
                             }

                            ) ;
                    }
                }
            }
            return View();
        }





    }
}
