using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("AssayDetail")]
    public class AssayDetail
    {
        [Key]
        [Column(Order = 1)]
        [Display(Name = "Assay Code")]
        public int AssayCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Test Code")]
        public int TestCode { get; set; }

        [Display(Name = "Required Test")]
        public bool RequiredTest { get; set; }


    }
}