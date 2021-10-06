using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class ProductsModel
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public decimal RetailPrice { get; set; }

        public int QuantityInStock { get; set; }
    }
}