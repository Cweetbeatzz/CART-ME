using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class SaleDetailDBModel
    {
        public string SaleId
        {
            get; set;
        }
        public int ProductId
        {
            get; set;
        }
        public decimal PurchasePPrice
        {
            get; set;
        }
        public decimal Tax
        {
            get; set;
        }
        public int Quantity
        {
            get; set;
        }
    }
}