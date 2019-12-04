using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        [Display(Name = "Assay Code")]
        public int AssayCode { get; set; }
        
        [Display(Name = "Assay Type")]
        [StringLength(20)]
        public string AssayType { get; set; }
        
        [Display(Name = "Assay Name")]
        [StringLength(50)]
        public string AssayName { get; set; }
        
        [StringLength(300)]
        [Display(Name = "Assay Description")]
        public string AssayDescription { get; set; }

        [StringLength(300)]
        [Display(Name = "Assay Literature References")]
        public string AssayLiteratureRefs { get; set; }
        
        [Display(Name = "Typical Assay Duration")]
        public int AssayDuration { get; set; }//add days

    }
}