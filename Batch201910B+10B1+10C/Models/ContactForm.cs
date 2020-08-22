using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Batch201910B_10B1_10C.Models
{
    public class ContactForm
    {
        [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Full Name is Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Email is requrired")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email is Invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Addreess is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Messsage is Required")]
        public string Message { get; set; }
    }
}