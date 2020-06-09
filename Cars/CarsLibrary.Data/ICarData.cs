using System.Collections.Generic;
using CarsLibrary.Core;

namespace CarsLibrary.Data
{
    public interface ICarData
    {
        IEnumerable<Car> GetAll();
    }

    public class InMemoryCarData : ICarData
    {
        List<Car> cars;
        
        //constructor
        public InMemoryCarData()
        {
            
            //this allows to use test data
            cars = new List<Car>()
            {
                new Car{ Id = 1, Model = "Fiesta", Make = "Ford", Colour = "White", carType = CarType.Small},
                new Car{ Id = 2, Model = "CX5", Make = "Mazda", Colour = "Red", carType = CarType.Family},
                new Car{ Id = 3, Model = "M5", Make = "BMW", Colour = "White", carType = CarType.Sports}
            };
        }
        public IEnumerable<Car> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}