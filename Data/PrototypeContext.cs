using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Data
{
    public class PrototypeContext : DbContext
    {
        public PrototypeContext(DbContextOptions<PrototypeContext> opt) : base(opt)
        {

        }

        // Set up DB Contexts here, each one will be a table
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<BillingPeriod> Billingperiods { get; set; }
        public DbSet<MediaFilter> MediaFilters { get; set; }
        public DbSet<OtherWarranty> OtherWarranties { get; set; }
        public DbSet<ServiceVisit> ServiceVisit { get; set;}
    }
}