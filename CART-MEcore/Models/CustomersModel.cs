using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CART_MEcore.Models
{
    public class CustomersModel
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "FIRST NAME")]
        [StringLength(50, ErrorMessage = "Firstname should be less than 50 Characters")]
        public string Firstname
        {
            get; set;
        }
        [Required]
        [DisplayName("LAST NAME")]
        public string Lastname
        {
            get; set;
        }
        [Required]
        [EmailAddress]
        [DisplayName("EMAIL")]
        public string Email
        {
            get; set;
        }
        [Required]
        public string Password
        {
            get; set;
        }
        [Required]
        [DisplayName("CONFIRM PASSWORD")]
        [Compare(nameof(Password), ErrorMessage = "Password do not Match")]
        public string confirm_password
        {
            get; set;
        }
    }
}
