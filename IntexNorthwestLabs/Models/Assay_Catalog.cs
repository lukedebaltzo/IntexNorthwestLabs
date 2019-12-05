using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IntexNorthwestLabs.Models
{
    [Table("dbo.Assay_Catalog")]
    public class Assay_Catalog
    {
        [Key]
        [Required]
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

        [Display(Name = "Test Name")]
        public string TestName { get; set; }

        [Display(Name = "Test Description")]
        public string TestDescription { get; set; }

        [Display(Name = "Test Type")]
        public string TestType { get; set; }

        [Display(Name = "Test Duration")]
        public int TestDuration { get; set; }

        [Display(Name = "Required Test")]
        public bool RequiredTest { get; set; }

        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }

        [Display(Name = "Material Name")]
        public string MaterialName { get; set; }
    }
}