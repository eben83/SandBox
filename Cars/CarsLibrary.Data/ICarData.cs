using System.Collections.Generic;
using System.Linq;
using CarsLibrary.Core;

namespace CarsLibrary.Data
{
    public interface ICarData
    {
        IEnumerable<Car> GetCarsByMake(string make);
        
        //search cars by id
        Car GetById(int id);
        
        //update car
        Car update(Car updatedCar);
        int Commit();
    }

    public class InMemoryCarData : ICarData
    {
        readonly List<Car> cars;
        
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
        
        public Car GetById(int id)
        {
            //return match or null
            return cars.SingleOrDefault(c => c.Id == id);
        }
        
        public IEnumerable<Car> GetCarsByMake(string make = null)
        {
            //linq query
            return from c in cars
                where string.IsNullOrEmpty(make) || c.Make.StartsWith(make)
                orderby c.Make
                select c;
        }

        public Car update(Car updatedCar)
        {
            var car = cars.SingleOrDefault(c => c.Id == updatedCar.Id);
            if (car != null)
            {
                car.Make = updatedCar.Make;
                car.Model = updatedCar.Model;
                car.Colour = updatedCar.Colour;
                car.carType = updatedCar.carType;
            }

            return car;
        }

        public int Commit()
        {
            return 0;
        }
    }
}