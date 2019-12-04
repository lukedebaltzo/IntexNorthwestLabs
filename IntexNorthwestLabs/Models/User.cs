using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [Required]
        [Display(Name ="User Code")]
        public int UserCode { get; set; }

        [Required]
        [Display(Name = "Your Customer Code")]
        public int CustomerCode { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(30)]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{8,}$", ErrorMessage = "Password must contain at least one letter, at least one number, and be longer than eight charaters.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "User First Name")]
        public string UserFirstName { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "User Last Name")]
        public string UserLastName { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }
    }
}