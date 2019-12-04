using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexNorthwestLabs.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Display(Name = "Customer Code")]
        public int CustomerCode { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        [StringLength(60)]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(50)]
        public string CustomerAddress { get; set; }

        [StringLength(50)]
        [Display(Name = "Address Line 2")]
        public string CustomerAddress2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(30)]
        public string CustomerCity { get; set; }

        [Display(Name = "State")]
        [StringLength(30, ErrorMessage = "The state field must be less than 30 characters. Please use abbreviations for longer names")]
        public string CustomerState { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(20)]
        public string CustomerPostalCode { get; set; }

        [Required]
        [Display(Name = "Country")]
        [StringLength(30)]
        public string CustomerCountry { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        [Display(Name = "Credit Card Number")]
        [CreditCard]
        public string CustomerCreditCardNumber { get; set; }

        [Display(Name = "Customer Discount")]
        public decimal CustomerDiscount { get; set; }//set to 0 to start

        [Display(Name = "Customer Comment")]
        public string CustomerComment { get; set; }

        [StringLength(5,MinimumLength =5, ErrorMessage = "Must be written as MM/YY")]
        [Display(Name = "Credit Card Expiration Date")]
        public string CustomerCreditCardExpiration { get; set; }

        [Display(Name = "Credit Card CVC")]
        public int? CustomerCreditCardCVC { get; set; }

        [Display(Name = "Would you like to automatically approve all tests (required and conditional) for all assays requested in the future?")]
        public bool AdditionalTestingApproval { get; set; }

        [Display(Name = "Total Amount Due")]
        public decimal TotalAmountDue { get; set; }//set to 0 to start
    }
}