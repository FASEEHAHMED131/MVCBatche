using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Batch201910B_10B1_10C.Models
{
    [Table("TblEmployee")]
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        [Required(ErrorMessage = "Employee Name is Required")]
        public string Emp_Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email is Invalid")]
        public string Emp_Email { get; set; }
        [Required(ErrorMessage = "Password is Requried")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " Confirm Password is Requried")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password Doesn't Match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "CNIC is Required")]
        [StringLength(13,ErrorMessage = "Not More Than 13 Characters")]
        public string CNIC { get; set; }
        [Required(ErrorMessage = "Please Mention Your Birthday.")]
        public DateTime BirthDay { get; set; }
        [Required]
        public bool Agree { get; set; }
    }
}