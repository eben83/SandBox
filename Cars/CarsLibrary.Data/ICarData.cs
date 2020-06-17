using System.Collections.Generic;
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
        
        //add new object
        Car Add(Car newCar);
        
        //delete
        Car Delete(int id);
        
        //count for the view componnet
        int GetCountOfCars();
        
        int Commit();
    }
}