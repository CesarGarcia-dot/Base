using Citricosoft.Models;
using Microsoft.EntityFrameworkCore;

namespace Citricosoft.Data
{
    public class CitricosftContext : DbContext
    {
        public CitricosftContext(DbContextOptions<CitricosftContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DetailsSite> DetailsSites { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<IpDomain> IpDomains { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoCustomer> PhotoCustomers { get; set; }
        public DbSet<RegisterPass> RegisterPasses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<TypeService> TypeServices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);                     
        }
    }
}