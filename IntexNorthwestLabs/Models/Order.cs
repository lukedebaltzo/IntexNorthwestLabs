using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Display(Name ="Order Code")]
        public int OrderCode { get; set; }
        
        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }
        
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        
        [Required(ErrorMessage = "Please describe your order")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Please note what assays you would like and the corresponding compounds. Please make a note if you would like all tests (required and conditional) for each assay requested.")]
        [StringLength(300, ErrorMessage = "Your response must be less than 300 characters")]
        public string OrderComment { get; set; }

        [Required]
        [Display(Name = "Would you like to rush this order to receive it within 5 business days? A 30% premium is charged for rushed orders")]
        public bool OrderRushed { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "When do you need this order by?")]
        public DateTime DueDate { get; set; }
        
        [Display(Name = "Arrival Date")]
        public DateTime? ArrivalDate { get; set; }
        
        [Display(Name = "Received By")]
        public string ReceivedBy { get; set; }

        [Required]
        [Display(Name = "Did you receive a quote for this order?")]
        public bool ReceivedQuote { get; set; }

        [Display(Name = "Quote Code associated with this order")]
        public int? QuoteCode { get; set; }
        
        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }

        [Display(Name = "Summary Report")]
        public byte[] OrderReport { get; set; }
        
    }
}