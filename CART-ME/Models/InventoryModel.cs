using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class InventoryModel
    {
        public int ProductId
        {
            get; set;
        }
        public int Qunatity
        {
            get; set;
        }

        public decimal PurchasePrice
        {
            get; set;
        }
        public DateTime PurchaseDate
        {
            get; set;
        }
    }
}
