using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("AssayTest")]
    public class AssayTest
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        [Display(Name = "Assay Code")]
        public int AssayCode { get; set; }


        [Key]
        [Column(Order = 2)]
        [Required]
        [Display(Name = "Test Code")]
        public int TestCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [Required]
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }//assigned when coumpound is recieved

        [Key]
        [Column(Order = 4)]
        [Required]
        [Display(Name = "Sequence Number")]
        public int SequenceNumber { get; set; }

        [Required]
        [Display(Name = "Test Status")]
        [StringLength(30)]
        public string TestStatus { get; set; }

        [Required]
        [Display(Name = "Quantitative Test Result")]
        public byte[] TestResultQuantitative { get; set; }
        
        [Required]
        [Display(Name = "Qualitative Test Result")]
        public byte[] TestResultQualitative { get; set; }
    }
}