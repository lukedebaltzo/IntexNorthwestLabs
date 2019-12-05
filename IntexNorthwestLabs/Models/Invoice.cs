using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        [Required]
        [Display(Name = "Invoice Number")]
        public int InvoiceCode { get; set; }

        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }

        [Required]
        [Display(Name = "Order Number")]
        public int OrderCode { get; set; }

        [Required]
        [Display(Name = "Invoice Date")]
        public DateTime InvoiceDate { get; set; }
        
        [Required]
        [Display(Name = "Due Date")]
        public DateTime InvoiceDueDate { get; set; }

        [Required]
        [Display(Name = "Early Pay Date")]
        public DateTime InvoiceEarlyPayDate { get; set; }

        [Required]
        [Display(Name = "Raw Total")]
        public decimal RawTotal { get; set; }

        [Required]
        [Display(Name = "Early Pay Discount")]
        public decimal InvoiceEarlyPayDiscount { get; set; }
        
        [Display(Name = "Other Discount Code")]
        public string DiscountCode { get; set; }

        [Required]
        [Display(Name = "Invoice Total")]
        public decimal InvoiceTotal { get; set; }

        [Required]
        [Display(Name = "Amount Paid")]
        public decimal InvoiceAmountPaid { get; set; }//starts as $0

        [Required]
        [Display(Name = "Amount Due")]
        public decimal InvoiceAmountDue { get; set; }
        
        [Required]
        [Display(Name = "Paid Status")]
        public bool PaidStatus { get; set; }//starts as false


    }


}