using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("OrderAssay")]
    public class OrderAssay
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        [Display(Name = "Order Code")]
        public int OrderCode { get; set; } //from the order tables

        [Key]
        [Column(Order = 2)]
        [Required]
        [Display(Name = "Assay Code")]
        public int AssayCode { get; set; } //from the assay table
        
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; } //assigned when they receive the project

        [Required]
        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; } 

        [Required]
        [Display(Name = "Compound Weight")]
        public decimal CompoundWeight { get; set; }

        [Required]
        [Display(Name = "Compound Weight Units")]
        public string CompoundWeightUnit { get; set; }
        
        [Display(Name = "Compound Quantity")]
        public string CompoundQuantity { get; set; }//added by employee when compund is received
        
        [Display(Name = "Compound Quantity Units")]
        public string CompoundQuantityUnit { get; set; }//added by employee when compund is received
        
        [Display(Name = "Compund Description")]
        public string CoumpundDescription { get; set; } //added by employee when compund is received
        
        [Display(Name = "Compound Molecular Mass")]
        public string CompoundMolecularMass { get; set; } //added by employee when compund is received
        
        [Display(Name = "Maximum Tolerated Dose")]
        public string MaximumToleratedDose { get; set; } //added by employee when compund is received

        [Required]
        [Display(Name = "I would like all assay tests to be completed regardless of the results.")]
        public bool RequestAllTests { get; set; }//added by employee when compund is received

    }
}