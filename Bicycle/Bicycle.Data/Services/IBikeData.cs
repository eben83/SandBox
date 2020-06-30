using System.Collections.Generic;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public interface IBikeData
    {
        IEnumerable<Bike> GetAll();

        Bike Get(int id);

        void Add(Bike bike);
    }
}