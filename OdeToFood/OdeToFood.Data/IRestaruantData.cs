using System;
using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaruantData
    {
        IEnumerable<Restarant> GetALL();

    }


    public class InMemoryRestarantData : IRestaruantData
    {

        List<Restarant> restarant;

        public InMemoryRestarantData()
        {
            restarant = new List<Restarant>()
            {
                new Restarant {ID = 1, Name = "Eben's Burger", Location = "JoBurg", Cuisine = CuisineType.Mexican},
                new Restarant {ID = 2, Name = "Wimpie", Location = "All Over", Cuisine = CuisineType.None},
                new Restarant {ID = 3, Name = "Star Place", Location = "Pretoria", Cuisine = CuisineType.Italian},
                new Restarant{ID = 4, Name = "Pots", Location = "Cape Town", Cuisine = CuisineType.Indian},

            };
        }

        public IEnumerable<Restarant> GetALL()
        {
        }
    }
}
