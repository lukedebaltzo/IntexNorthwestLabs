using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("QuoteDetail")]
    public class QuoteDetail
    {
        [Key]
        public int QuoteCode { get; set; }

        public int AssayCode { get; set; }
    }
}