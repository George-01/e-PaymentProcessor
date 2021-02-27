using Microsoft.EntityFrameworkCore;
using PaymentProcessor.Models.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessor.Models.Entity.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<PaymentState> PaymentStates { get; set; }
    }
}
