using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        public int MaterialCode { get; set; }

        [Display(Name = "Material Name")]
        public string MaterialName { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal QuantityOnHand { get; set; }
    }
}