using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Location")]
    public class Location
    {

        [Required]
        [Display(Name = "Location Code")]
        public int LocationCode { get; set; }

        [Required]
        [Display(Name = "Office")]
        public string LocationName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string LocationAddress { get; set; }

        [Display(Name = "Street Address 2")]
        public string LocationAddress2 { get; set; }

        [Required]
        [Display(Name = "City")]
        public string LocationCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string LocationState { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string LocationPostalCode { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string LocationCountry { get; set; }
    }
}