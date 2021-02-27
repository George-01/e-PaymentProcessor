using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Models.DTO
{
    class PaymentResponseDto
    {
        public bool IsProcessed { get; set; }
        public PaymentStateDto PaymentState { get; set; }
    }
}
