using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class InventoryModel
    {
        //FOREGIN KEY
        public int ProductId//#########################
        {
            get; set;
        }
        //[Required(ErrorMessage = "Quantity is Reguired")]
        public int Quantity//#########################
        {
            get; set;
        }

        public decimal PurchasePrice//#########################
        {
            get; set;
        }
        public DateTime PurchaseDate//#########################
        {
            get; set;
        }
    }
}
