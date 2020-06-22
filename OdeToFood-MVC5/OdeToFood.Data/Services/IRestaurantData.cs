using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int Id);
        void Add(Restaurant restaurant);

        void Update(Restaurant restaurant);
    }
}