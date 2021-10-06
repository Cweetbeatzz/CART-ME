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

        //######################################################################## CREATE USER
        [HttpPost]
        public ActionResult CreateCustomer(CustomersModel customers)
        {
            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMERS(firstname, lastname, email,password, confirm_password)" +
                    " VALUES('" + customers.Firstname + "','" + customers.Lastname + "','" + customers.Email + "','" + customers.Password + "','" + customers.confirm_password + "',)"))
                {
                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            return Content("Successful");
        }
        //######################################################################## GET USER
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

                    SqlDataReader output = cmd.ExecuteReader(); //FETCHING DATA FROM THE DATABASE

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
                                 //Password = datarows["Password"].ToString(),
                                 //confirm_password = datarows["ConfirmPassword"].ToString(),
                             }

                            );
                    }
                }
            }
            return View();
        }
        //######################################################################## DELETE USER

        public ActionResult Delete(int id)
        {
            if (id < 0)
            {
                return HttpNotFound();
            }
            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE Id = '" + id + "'", cnn))
                {
                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    cmd.ExecuteNonQuery();
                }
            }
            return RedirectToAction("GetAllCustomers");
        }
        //######################################################################## UPDATE USER

        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return HttpNotFound();
            }

            var _customersToEdit = new CustomersModel();

            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE Id = '" + id + "'", cnn))
                {
                    if (cnn.State != ConnectionState.Open)
                    {
                        cnn.Open();
                    }

                    SqlDataReader output = cmd.ExecuteReader();

                    DataTable dt = new DataTable();


                    if (output.HasRows)
                    {
                        dt.Load(output);
                        DataRow dataRow = dt.Rows[0];

                        _customersToEdit.Firstname = dataRow["FirstName"].ToString();
                        _customersToEdit.Lastname = dataRow["LastName"].ToString();
                        _customersToEdit.Email = dataRow["Email"].ToString();
                        _customersToEdit.Password = dataRow["Password"].ToString();
                        _customersToEdit.confirm_password = dataRow["ConfirmPassword"].ToString();

                        return View("CreateCustomer", _customersToEdit);
                    }
                    else
                    {
                        return HttpNotFound();
                    }
                }
            }
            return RedirectToAction("GetAllCustomers");
        }
    }
}
