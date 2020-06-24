﻿using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public interface IBikeData
    {
        IEnumerable<Bike> GetAll();
    }
}