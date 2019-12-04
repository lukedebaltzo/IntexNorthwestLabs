using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Display(Name = "Employee Code")]
        public int EmployeeCode { get; set; }

        [Display(Name = "Employee First Name")]
        [StringLength(30)]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Employee Last Name")]
        [StringLength(30)]
        public string EmployeeLastName { get; set; }

        [Display(Name =  "Username")]
        [StringLength(30)]
        public string EmployeeUserName { get; set; }

        [Display(Name = "Password")]
        [StringLength(30)]
        public string EmployeePassword { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [StringLength(30)]
        public string EmployeeEmail { get; set; }
    }
}