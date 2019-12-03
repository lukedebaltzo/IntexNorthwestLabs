using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    public class User
    {
        [Required]
        [Display(Name ="User Code")]
        public int UserCode { get; set; }

        [Required]
        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "User First Name")]
        public string UserFirstName { get; set; }

        [Required]
        [Display(Name = "User Last Name")]
        public string UserLastName { get; set; }

        [Required]
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }
    }
}