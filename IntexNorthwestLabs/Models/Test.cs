using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        [Display(Name ="Test Code")]
        public int TestCode { get; set; }

        [Display(Name = "Test Name")]
        public string TestName { get; set; }

        [Display(Name = "Test Description")]
        public string TestDescription { get; set; }

        [Display(Name = "Test Type")]
        public string TestType { get; set; }

        [Display(Name = "Test Duration")]
        public int TestDuration { get; set; }
    }
}