using Microsoft.EntityFrameworkCore;
using WorldCitiesAPI.Models;


namespace WorldCitiesAPI.Data
{
    public class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
        }
    
        public DbSet<City> Cities { get; set; }

    }
    
}
