using Domain.CustomerAggregate.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Data.Context.EFContext
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (Database.IsSqlServer())
            {
                //modelBuilder.ApplyConfiguration(new CustomerConfig());
                base.OnModelCreating(modelBuilder);
                modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
                modelBuilder.HasDefaultSchema("CMS");
            }
        }
    }
}
