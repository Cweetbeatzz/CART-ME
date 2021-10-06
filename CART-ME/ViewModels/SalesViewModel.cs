using CART_ME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.ViewModels
{
    public class SalesViewModel
    {
        public ProductsModel products { get; set; }
        public List<SaleDetailsModel> saleDetails { get; set; }
    }
}