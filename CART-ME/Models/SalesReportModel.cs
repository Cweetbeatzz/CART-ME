using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class SalesReportModel
    {
        public DateTime SaleDate
        {
            get; set;
        }
        public decimal Tax
        {
            get; set;
        }
        public decimal Subtotal
        {
            get; set;
        }
        public decimal Total
        {
            get; set;
        }
        public string Firstname
        {
            get; set;
        }
        public string Lastname
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
    }
}