using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("TestMaterial")]
    public class TestMaterial
    {
        [Key]
        [Column(Order = 1)]
        [Display(Name = "Test Code")]
        public int TestCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Material Code")]
        public int MaterialCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }

        [Display(Name = "Test Cost")]
        public decimal TestCost { get; set; }

        [Display(Name = "Material Used")]
        public int MaterialUsed { get; set; }
    }
}