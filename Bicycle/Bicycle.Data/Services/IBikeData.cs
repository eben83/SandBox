using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public interface IBikeData
    {
        IEnumerable<Components> GetAll();

        Components Get(int id);

        void Add(Components components);
    }
}