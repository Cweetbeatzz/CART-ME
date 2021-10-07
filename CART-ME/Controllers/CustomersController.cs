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
            return View(new CustomersModel { Id = 0 });
        }

        //######################################################################## CREATE USER
        [HttpPost]
        public ActionResult CreateCustomer(CustomersModel customers)
        {
            //string SQLinsert = "";
            //string SQLupdate = "";
            if (ModelState.IsValid)
            {
                using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
                {
                    using (SqlCommand cmd = new SqlCommand("Customer_REG", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", customers.Id);
                        cmd.Parameters.AddWithValue("@firstname", customers.Firstname);
                        cmd.Parameters.AddWithValue("@lastanme", customers.Lastname);
                        cmd.Parameters.AddWithValue("@password", customers.Password);
                        cmd.Parameters.AddWithValue("@confirm_password", customers.confirm_password);

                        if (cnn.State != ConnectionState.Open)
                        {
                            cnn.Open();
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                return RedirectToAction("GetAllCustomers");

            }
            return View("CreateCustomer", customers);

        }
        //######################################################################## GET USER
        [HttpGet]
        public ActionResult GetAllCustomers()
        {
            List<CustomersModel> Customerlist = new List<CustomersModel>();

            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("Customers_GetAll", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

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
                                 Id = Convert.ToInt32(datarows["Id"]),
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
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (id < 0)
            {
                return HttpNotFound();
            }
            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("Customer_DEL", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);

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

        [HttpPatch]
        public ActionResult Edit(int? id)
        {
            if (id <= 0)
            {
                return HttpNotFound();
            }

            var _customersToEdit = new CustomersModel();

            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("Customers_UPDATE", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);

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
                        _customersToEdit.Id = Convert.ToInt32(dataRow["Id"]);
                        _customersToEdit.Firstname = dataRow["FirstName"].ToString();
                        _customersToEdit.Lastname = dataRow["LastName"].ToString();
                        _customersToEdit.Email = dataRow["Email"].ToString();
                        //_customersToEdit.Password = dataRow["Password"].ToString();
                        //_customersToEdit.confirm_password = dataRow["ConfirmPassword"].ToString();

                        return View("CreateCustomer", _customersToEdit);
                    }
                    else
                    {
                        return HttpNotFound();
                    }
                }
            }
        }

        //######################################################################## SEARCH

        [HttpGet]
        //public ActionResult Search(string search)
        //{
        //    List<CustomersModel> list = new List<CustomersModel>();
        //}
        //######################################################################## 
        public List<CustomersModel> customer_list(string storedProcedure, string search)
        {
            List<CustomersModel> Customerlist = new List<CustomersModel>();

            using (SqlConnection cnn = new SqlConnection(SQLconnection.GetConnectionString("CART-ME-DB")))
            {
                using (SqlCommand cmd = new SqlCommand("Customers_GetAll", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //if (search != string.Empty)                                            //SEARCH
                    //{                                                                      //SEARCH
                    //    cmd.Parameters.AddWithValue("@Filther", search);                   //SEARCH
                    //}

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
                                 Id = Convert.ToInt32(datarows["Id"]),
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

            return Customerlist;
        }

        //######################################################################## 

        //protected override void Dispose(bool diposing)
        //{
        //    if (diposing)
        //    {
        //        _context.Dispose();
        //    }
        //    base.Dispose(diposing);
        //}

    }
}
