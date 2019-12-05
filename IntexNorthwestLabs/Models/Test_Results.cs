using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Test_Results")]
    public class Test_Results
    {
        [Display(Name = "Assay Name")]
        [StringLength(50)]
        public string AssayName { get; set; }

        [Display(Name = "Test Name")]
        public string TestName { get; set; }

        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }
        
        [Display(Name = "Test Status")]
        [StringLength(30)]
        public string TestStatus { get; set; }

        [Display(Name = "Quantitative Test Result")]
        public byte[] TestResultQuantitative { get; set; }
        
        [Display(Name = "Qualitative Test Result")]
        public byte[] TestResultQualitative { get; set; }
    }
}