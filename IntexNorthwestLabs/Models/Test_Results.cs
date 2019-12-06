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
        [Key]
        [Column(Order = 1)]
        [Display(Name = "Assay Code")]
        public int AssayCode { get; set; }

        [Display(Name = "Assay Name")]
        [StringLength(50)]
        public string AssayName { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Test Code")]
        public int TestCode { get; set; }
        
        [Display(Name = "Test Name")]
        public string TestName { get; set; }

        [Key]
        [Column(Order = 3)]
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }//assigned when coumpound is recieved

        [Key]
        [Column(Order = 4)]
        [Display(Name = "Sequence Number")]
        public int SequenceNumber { get; set; }

        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }
        
        [Display(Name = "Test Status")]
        [StringLength(30)]
        public string TestStatus { get; set; }

        [Display(Name = "Quantitative Test Result")]
        public byte[] TestResultQuantitative { get; set; }
        
        [Display(Name = "Qualitative Test Result")]
        public byte[] TestResultQualitative { get; set; }

        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }
    }
}