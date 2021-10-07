using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        public string Client { get; set; }

        public string Manager { get; set; }

        public string Cashier { get; set; }

        public string Administrator { get; set; }
    }
}