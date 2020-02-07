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
        /* get the in id for the restarant*/

        Restarant Update(Restarant updatedRestarant);
        /*this is the update property*/

        int Commit();
        /*this will be used to commit the the server*/
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

        public Restarant Update(Restarant updatedRestarant)
        {
            var restarant = restarants.SingleOrDefault(r => r.ID == updatedRestarant.ID);
                if(restarant != null)
            {
                restarant.Name = updatedRestarant.Name;
                restarant.Location = updatedRestarant.Location;
                restarant.Cuisine = updatedRestarant.Cuisine;
            }
            return restarant;
        }

        public int Commit()
        {
            return 0;
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
