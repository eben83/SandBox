using System;
using Microsoft.EntityFrameworkCore;

namespace BLcoffeeMachine.Contexts
 
{
     public class DemoDbContext : DbContext
     {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        
    }
}
