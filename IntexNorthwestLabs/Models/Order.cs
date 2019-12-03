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
        [Required]
        [Display(Name ="Order Code")]
        public int OrderCode { get; set; }

        [Required]
        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }
        
        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        
        [Display(Name = "Additional comments about the order")]
        public string OrderComment { get; set; }

        [Required]
        [Display(Name = "Would you like to rush this order to receive it within 5 business days? A 30% premium is charged for rushed orders")]
        public bool OrderRushed { get; set; }

        [Required]
        [Display(Name = "When do you need this order by?")]
        public DateTime DueDate { get; set; }
        
        [Display(Name = "Arrival Date")]
        public DateTime ArrivalDate { get; set; }
        
        [Display(Name = "Recieved By")]
        public string RecievedBy { get; set; }

        [Required]
        [Display(Name = "Did you receive a quote for this order?")]
        public bool ReceivedQuote { get; set; }

        [Display(Name = "Quote Code associated with this order")]
        public int QuoteCode { get; set; }
        
        [Display(Name = "Order Status")]
        public int OrderStatus { get; set; }

    }
}