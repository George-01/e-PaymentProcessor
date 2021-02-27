using AutoMapper;
using PaymentProcessor.Models.DTO;
using PaymentProcessor.Models.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcessor.Services.PaymentProcessorMapper
{
    public class PaymentProcessorMappings : Profile
    {
        public PaymentProcessorMappings()
        {
            CreateMap<Payment, PaymentRequestDto>().ReverseMap();

            CreateMap<PaymentState, PaymentStateDto>().ReverseMap();
        }
    }
}
