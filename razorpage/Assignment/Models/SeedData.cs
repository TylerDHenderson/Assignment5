using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Assignment_3_New.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GroceryContext(
                serviceProvider.GetRequiredService<DbContextOptions<GroceryContext>>()))
            {
                if (context.Customers.Any())
                {
                    return;
                }

                context.Customers.AddRange(
                    new Customer
                    {
                        firstName = "Michael",
                        lastName = "Mashburn",
                        email = "mamashburn1@buffs.wtamu.edu",
                        phoneNum = 1231234,
                        password = "password"
                    },
                    new Customer
                    {
                        firstName = "Tyler",
                        lastName = "Henderson",
                        email = "tdhenderson1@buffs.wtamu.edu",
                        phoneNum = 4321321,
                        password = "password"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}