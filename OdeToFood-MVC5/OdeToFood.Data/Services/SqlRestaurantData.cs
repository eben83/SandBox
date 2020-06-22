using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData :IRestaurantData
    {
        private readonly OdeToFoodDbContext _db;

        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            _db = db;
        }
        
        public IEnumerable<Restaurant> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Restaurant Get(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        public void Update(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }
    }
}