using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }

        public List<CategoryModel> CategoryNames { get; set; }
    }
}