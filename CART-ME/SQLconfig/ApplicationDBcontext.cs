using CART_ME.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CART_ME.SQLconfig
{
    public class ApplicationDBcontext:DbContext
    {
        public DbSet<CustomersModel> Customers { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
    }
}