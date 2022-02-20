using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using driverapp.Data;
using driverapp.Models;

namespace driverapp.Tests;

public class DataAccessLayerTest
{
        [Fact]
        public async Task AddDriverAsync_DriverIsAdded()
        {
            using (var db = new razorpageContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;

                var expectedDriver = new Driver() 
                { 
                    driverID = recId, 
                    LastName = "Tester",
                    FirstName = "Test",
                };

                // Act
                await db.AddDriverAsync(expectedDriver);

                // Assert
                var actualDriver = await db.FindAsync<Driver>(recId);
                Assert.Equal(expectedDriver, actualDriver);
            }
        }
}