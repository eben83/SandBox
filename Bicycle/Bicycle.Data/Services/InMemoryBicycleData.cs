using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    class InMemoryBicycleData : IBicycleDate
    {
        public IEnumerable<BicycleType> GetAllBicyclesType()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Models.Bicycle> GetAllBicycles()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WheelSet> GetAllWheelSets()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GearSet> GetAllGearSets()
        {
            throw new System.NotImplementedException();
        }
    }
}