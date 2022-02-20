#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using customerapp.Models;

namespace customerapp.Data
{
    public class razorpageContext : DbContext
    {
        public razorpageContext (DbContextOptions<razorpageContext> options)
            : base(options)
        {
        }

        public DbSet<customerapp.Models.Customer> Customer { get; set; }

        public async virtual Task AddCustomerAsync(customerapp.Models.Customer customer)
        {
            await Customer.AddAsync(customer);
            await SaveChangesAsync();
        }

        public async virtual Task DeleteCustomerAsync(int? id)
        {
            Customer customer = await Customer.FindAsync(id);            

            if (customer != null)
            {
                Customer.Remove(customer);
                await SaveChangesAsync();
            }
        }
    }
}
