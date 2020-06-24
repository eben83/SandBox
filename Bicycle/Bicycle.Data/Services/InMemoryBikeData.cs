using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public class InMemoryBikeData : IBikeData
    {
        public IEnumerable<Bike> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
    
}