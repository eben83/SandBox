using CarsLibrary.Core;
using Microsoft.EntityFrameworkCore;

namespace CarsLibrary.Data
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}