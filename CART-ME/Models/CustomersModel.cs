using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CART_ME.Models
{
    public class CustomersModel
    {
        [Key]
        public int Id { get; set; } //#########################


        [Required(ErrorMessage = "Firstname is Reguired")]
        [DisplayName("FIRST NAME")]
        [StringLength(50,ErrorMessage = "Firstname must not exceed 50 Characters")]
        public string Firstname //#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Lastname is Reguired")]
        [DisplayName("LAST NAME")]
        [StringLength(50, ErrorMessage = "Lastname must not exceed 50 Characters")]
        public string Lastname //#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Email is Reguired")]
        [EmailAddress]
        [DisplayName("EMAIL")]
        public string Email//#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Password is Reguired")]
        public string Password//#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Confirmation is Reguired")]
        [DisplayName("CONFIRM PASSWORD")]
        [Compare(nameof(Password), ErrorMessage = "Password do not Match")]
        public string confirm_password //#########################
        {
            get; set;
        }
    }
}