#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using driverapp.Models;

namespace driverapp.Data
{
    public class razorpageContext : DbContext
    {
        public razorpageContext (DbContextOptions<razorpageContext> options)
            : base(options)
        {
        }

        public DbSet<driverapp.Models.Driver> Driver { get; set; }

        public async virtual Task AddDriverAsync(driverapp.Models.Driver driver)
        {
            await Driver.AddAsync(driver);
            await SaveChangesAsync();
        }

        public async virtual Task DeleteDriverAsync(int? id)
        {
            Driver driver = await Driver.FindAsync(id);            

            if (driver != null)
            {
                Driver.Remove(driver);
                await SaveChangesAsync();
            }
        }
    }
}
