using System.Collections.Generic;

namespace Bicycle.Data.Services
{
    class InMemoryBicycleData : IBicycleDate
    {
        public IEnumerable<Models.Bicycle> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}