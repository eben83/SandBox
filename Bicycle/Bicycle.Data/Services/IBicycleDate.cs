﻿using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public interface IBicycleDate
    {
        IEnumerable<BicycleType> GetAllBycycles();
        IEnumerable<Models.Bicycle> GetAllBicycles();
        IEnumerable<Models.WheelSet> GetAllWheelSets();
        IEnumerable<Models.GearSet> GetAllGearSets();
        
    }
}