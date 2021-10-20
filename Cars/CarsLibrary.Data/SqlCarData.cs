using System.Collections.Generic;
using System.Linq;
using CarsLibrary.Core;
using Microsoft.EntityFrameworkCore;

namespace CarsLibrary.Data
{
    public class SqlCarData : ICarData
    {
        private readonly CarDbContext _db;

        //instance of the dbContext
        public SqlCarData(CarDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Car> GetCarsByMake(string make)
        {
            var query = from car in _db.Cars
                where car.Make.StartsWith(make) || string.IsNullOrEmpty(make)
                orderby car.Make
                select car;

            return query;
        }

        public Car GetById(int id)
        {
            return _db.Cars.Find(id);
        }

        public Car update(Car updatedCar)
        {
            //Attach- will track the changes and not make a new instance
            var entity = _db.Cars.Attach(updatedCar);
            //entityState modified- will assume all data has changed 
            entity.State = EntityState.Modified;
            return updatedCar;
        }

        public Car Add(Car newCar)
        {
            _db.Add(newCar);
            return newCar;
        }

        public Car Delete(int id)
        {
            var car = GetById(id);
            if (car.Id != null)
            {
                _db.Cars.Remove(car);
            }

            return car;
        }

        public int GetCountOfCars()
        {
            return _db.Cars.Count();
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }
    }
}