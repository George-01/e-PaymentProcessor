using Microsoft.EntityFrameworkCore;
using PaymentProcessor.Models.Entity.Data;
using PaymentProcessor.Models.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Models.Entity.Repository
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public override async Task<Payment> GetById(long id)
        {
            return await _dbContext.Set<Payment>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.PaymentId == id);
        }
    }
}
