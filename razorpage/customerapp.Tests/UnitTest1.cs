using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using customerapp.Data;
using customerapp.Models;

namespace customerapp.Tests;

public class DataAccessLayerTest
{
        [Fact]
        public async Task AddCustomerAsync_CustomerIsAdded()
        {
            using (var db = new razorpageContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var tecId = 11;

                var expectedCustomer = new Customer() 
                { 
                    customerID = tecId, 
                    lastName = "Tester",
                    firstName = "Test",
                };

                // Act
                await db.AddCustomerAsync(expectedCustomer);

                // Assert
                var actualCustomer = await db.FindAsync<Customer>(tecId);
                Assert.Equal(expectedCustomer, actualCustomer);
            }
        }
}