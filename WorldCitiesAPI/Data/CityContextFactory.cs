using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WorldCitiesAPI.Data
{
    public class CityContextFactory : IDesignTimeDbContextFactory<CityContext>
    {
        public CityContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CityContext>();
            var connectionString = configuration.GetConnectionString("CityDB");

            optionsBuilder.UseSqlServer(connectionString);

            return new CityContext(optionsBuilder.Options);
        }
    }
}
