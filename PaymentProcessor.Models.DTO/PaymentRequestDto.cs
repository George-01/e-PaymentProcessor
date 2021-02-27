using PaymentProcessor.Models.DTO.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PaymentProcessor.Models.DTO
{
    public class PaymentRequestDto
    {
        [Required]
        [CreditCard]
        public string CreditCardNumber { get; set; }
        [Required]
        public string CardHolder { get; set; }
        [Required]
        [DateCheckValidation]
        public DateTime ExpirationDate { get; set; }

        [StringLength(maximumLength: 3, MinimumLength = 3)]
        public string SecurityCode { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }
    }
}
