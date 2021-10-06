using CART_ME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.ViewModels
{
    public class SalesViewModel
    {
        public SaleDetailsModel products_quantity { get; set; }
        public List<SaleModel> saleDetails { get; set; }
    }
}