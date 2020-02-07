using System;
using System.Collections.Generic;
using System.Linq;


namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restarant> GetRestaurantsByName(string name);
        /*
            this will get all the Restarant data
         */

        Restarant GetById(int id);
    }
    public class InMemoryRestarantData : IRestaurantData
    {
        List<Restarant> restarants; /*this make a list to hold data*/

        public InMemoryRestarantData()
        {
            restarants = new List<Restarant>
            {
                new Restarant {ID = 1, Name = "Scott's Pizza", Location = "Pretoria", Cuisine = CuisineType.Indian},
                new Restarant {ID = 2, Name = "Whimpy", Location = "National", Cuisine = CuisineType.Italian},
                new Restarant {ID = 3, Name = "Pots", Location = "JoBurg", Cuisine = CuisineType.Mexican},
                new Restarant {ID = 4, Name = "burger Shack", Location = "Cape Town", Cuisine = CuisineType.None},
            };

            
        }

        public Restarant GetById(int id)
        {
            return restarants.SingleOrDefault(r => r.ID == id);
            // this will return the match or null

        }

        public IEnumerable<Restarant> GetRestaurantsByName(string name = null)
        {
            return from r in restarants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
            /*
                must add the System.Linq to access the data. similar to sql
             */
        }
    }
}
