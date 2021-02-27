using Microsoft.EntityFrameworkCore;
using PaymentProcessor.Models.Entity.Data;
using PaymentProcessor.Models.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Models.Entity.Repository
{
    public class PaymentStateRepository : GenericRepository<PaymentState>, IPaymentStateRepository
    {
        public PaymentStateRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public override async Task<PaymentState> GetById(long id)
        {
            return await _dbContext.Set<PaymentState>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.PaymentId == id);
        }
    }
}
