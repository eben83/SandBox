using System.Collections.Generic;

namespace Bicycle.Data.Services
{
    public interface IBicycleDate
    {
        IEnumerable<Models.Bicycle> GetAll();
    }
}