using System.Collections.Generic;
using System.Linq;
using Bicycle.Data.Models;

namespace Bicycle.Data.Services
{
    public class InMemoryBikeData : IBikeData
    {
        private List<Bike> _bikes;

        public InMemoryBikeData()
        {
            _bikes = new List<Bike>()
            {
                new Bike{Id = 1, BikeType = BikeType.Road, BikeMake = "Merida", BikeModel = "Reacto 5000", GearSetMake = GearSetMake.Shimano, GearSet = {Model = "Ultegra", ModelNumber = "6800"}, WheelSetType = WheelSetType.Aluminium, WheelSetMake = {Name = "Alex", Model = "Speed", Weight = 1200}, Weight = 8900},
                new Bike{Id = 2, BikeType = BikeType.Road, BikeMake = "Merida", BikeModel = "Scultura 5000", GearSetMake = GearSetMake.Shimano, GearSet = {Model = "Ultegra", ModelNumber = "6400"}, WheelSetType = WheelSetType.Aluminium, WheelSetMake = {Name = "Alex", Model = "Climber", Weight = 1200}, Weight = 7900},
                new Bike{Id = 2, BikeType = BikeType.Road, BikeMake = "Trek", BikeModel = "Madone SLR6", GearSetMake = GearSetMake.Shimano, GearSet = {Model = "Dura-Ace", ModelNumber = "8700"}, WheelSetType = WheelSetType.Carbon, WheelSetMake = {Name = "Bontrager", Model = "Aeolus Pro 5", Weight = 1200}, Weight = 6900},
                new Bike{Id = 2, BikeType = BikeType.Road, BikeMake = "Trek", BikeModel = "Domane SL6", GearSetMake = GearSetMake.Shimano, GearSet = {Model = "Ultegra", ModelNumber = "9700"}, WheelSetType = WheelSetType.Carbon, WheelSetMake = {Name = "Bontrager", Model = "Paradigm Comp 25", Weight = 1200}, Weight = 9200},
            };
        }
        
        public IEnumerable<Bike> GetAll()
        {
            return _bikes.OrderBy(b => b.BikeMake);
        }
    }
    
}