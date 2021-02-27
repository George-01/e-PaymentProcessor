using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PaymentProcessor.Models.Entity.Entity
{
    public class PaymentState
    {
        [Required]
        [Key]
        public int PaymentStateId { get; set; }

        [Required]
        public string State { get; set; }


        [Column(nameof(DateCreated), TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        public int PaymentId { get; set; }

        [ForeignKey(nameof(PaymentId))]
        public Payment Payment { get; set; }
    }
}
