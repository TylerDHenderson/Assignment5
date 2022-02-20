using Microsoft.EntityFrameworkCore;

namespace Assignment_3_New.Models
{
    public class GroceryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GroceryDatabase.db");
        }
        public GroceryContext (DbContextOptions<GroceryContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Driver> Drivers {get; set;}
        public DbSet<Order> Orders {get; set;}
    }
}