using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Discount")]
    public class Discount
    {
        [StringLength(2, MinimumLength = 2)]
        public string DiscountCode { get; set; }


        public decimal DiscountPercent { get; set; }

        [StringLength(30)]
        public string DiscountName { get; set; }
    }
}