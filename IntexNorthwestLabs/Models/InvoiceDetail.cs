using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("InvoiceItemCode")]
    public class InvoiceDetail
    {
        [Key]
        public int InvoiceItemCode { get; set; }
        public int TestCode { get; set; }
        public int InvoiceCode { get; set; }
    }
}