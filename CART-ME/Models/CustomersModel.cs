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
        [DataType(DataType.Text)]

        public string Firstname //#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Lastname is Reguired")]
        [DisplayName("LAST NAME")]
        [StringLength(50, ErrorMessage = "Lastname must not exceed 50 Characters")]
        [DataType(DataType.Text)]
        public string Lastname //#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Email is Reguired")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("EMAIL")]
        public string Email//#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Phone Number is Reguired")]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11,ErrorMessage = "Phone Number must not exceed 11 Numbers")]
        [MaxLength(11)]
        public string Phone { get; set; }//#########################

        [Required(ErrorMessage = "Password is Reguired")]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Paasword must not exceed 20 Characters")]
        [MaxLength(20)]
        public string Password//#########################
        {
            get; set;
        }
        [Required(ErrorMessage = "Confirmation Password is Reguired")]
        [DisplayName("CONFIRM PASSWORD")]
        [Compare(nameof(Password), ErrorMessage = "Password do not Match")]
        [DataType(DataType.Password)]
        public string confirm_password //#########################
        {
            get; set;
        }
    }
}