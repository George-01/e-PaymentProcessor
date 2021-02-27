using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PaymentProcessor.Models.DTO.CustomValidation
{
    class DateCheckValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object dateValue)
        {
            DateTime d = Convert.ToDateTime(dateValue);
            return d >= DateTime.Now;

        }
    }
}
