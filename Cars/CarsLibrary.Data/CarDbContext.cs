using CarsLibrary.Core;
using Microsoft.EntityFrameworkCore;

namespace CarsLibrary.Data
{
    public class CarDbContext : DbContext
    {

        public CarDbContext(DbContextOptions<CarDbContext> options)
        :base(options)
        {
            
        }
        
        public DbSet<Car> Cars { get; set; }
    }
}