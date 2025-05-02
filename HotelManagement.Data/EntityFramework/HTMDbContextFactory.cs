using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.EntityFramework
{
    public class HTMDbContextFactory : IDesignTimeDbContextFactory<HTMDbContext>
    {
        public HTMDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("HotelManagementDb");

            var optionBuilder = new DbContextOptionsBuilder<HTMDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new HTMDbContext(optionBuilder.Options); 
        }

    }
}
