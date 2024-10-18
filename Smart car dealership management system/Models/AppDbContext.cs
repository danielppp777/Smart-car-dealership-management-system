using Microsoft.EntityFrameworkCore;
using Smart_car_dealership_management_system.Models;
using Smart_car_dealership_management_system.Models.YourNamespace.Models;
using YourNamespace.Data;

namespace YourNamespace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
