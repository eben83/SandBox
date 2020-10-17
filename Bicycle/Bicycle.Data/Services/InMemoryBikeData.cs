﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public class InMemoryBikeData : IBikeData
    {
        List<Components> components;

        public InMemoryBikeData()
        {
            components = new List<Components>()
            {
                new Components{ComponentType = ComponentType.Pedals, Id = 1, Make = "Look", Model = "Carbon Blade", Weight = 321, BikeType = BikeType.Road},
                new Components{ComponentType = ComponentType.Frame, Id = 2, Make = "Trek", Model = "Madona SLR", Weight = 1200, BikeType = BikeType.Road},
                new Components{ComponentType = ComponentType.Cassette, Id = 3, Make = "Shimano", Model = "Ultegra", Weight = 110, BikeType = BikeType.Road},
                new Components{ComponentType = ComponentType.Cassette, Id = 4, Make = "Shimano", Model = "Di-2", Weight = 150, BikeType = BikeType.Road},
                new Components{ComponentType = ComponentType.Pedals, Id = 4, Make = "Look", Model = "Duo-Two", Weight = 500, BikeType = BikeType.Road},
            };
        }
        
        public IEnumerable<Components> GetAll()
        {
            return components;
        }

        public Components Get(int id)
        {
            return components.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Components components)
        {
            this.components.Add(components);
            components.Id = this.components.Max(b => b.Id) + 1;
        }
    }
    
}