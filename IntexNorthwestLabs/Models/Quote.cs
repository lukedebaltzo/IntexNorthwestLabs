using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Quote")]
    public class Quote
    {
        [Display(Name = "Quote Code")]
        public int QuoteCode { get; set; }

        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }

        [Display(Name = "Employee Code")]
        public int EmployeeCode { get; set; }

        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }

        [Display(Name = "Expected Low Price")]
        public decimal QuotePriceLow { get; set; }

        [Display(Name = "Expected High Price")]
        public decimal QuotePriceHigh { get; set; }

        [Display(Name = "Quote Description")]
        public string QuoteDescription { get; set; }
    }
}