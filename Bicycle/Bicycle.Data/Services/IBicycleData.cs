using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public interface IBicycleData
    {
        IEnumerable<Models.Bicycle> GetAll();
    }
}