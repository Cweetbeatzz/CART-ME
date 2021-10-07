using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class ProductsModel
    {
        [Key]
        public int Id { get; set; }//#########################

        [Required(ErrorMessage = "Name is Reguired")]
        [StringLength(50, ErrorMessage = "Name must not exceed 50 Characters")]
        public string Name { get; set; }//#########################

        [Required(ErrorMessage = "Description is Reguired")]
        [StringLength(50, ErrorMessage = "Description must not exceed 50 Characters")]
        public string Description { get; set; }//#########################

        [Required(ErrorMessage = "Category is Reguired")]
        public string Category { get; set; }//#########################   public CategoryModel Category { get; set; }

        [Required(ErrorMessage = "Price is Reguired")]
        public decimal RetailPrice { get; set; }//#########################

        [Required(ErrorMessage = "Quantity In Stock is Reguired")]
        public int QuantityInStock { get; set; }//#########################
    }
}