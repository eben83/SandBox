using System.Collections.Generic;
using System.Linq;
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
            return from r in _db.Restaurants
                orderby r.Name
                select r;
        }

        public Restaurant Get(int Id)
        {
            return _db.Restaurants.FirstOrDefault(r => r.Id == Id);
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