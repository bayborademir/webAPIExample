using Microsoft.Extensions.Logging;
using RentACar.DataAcces.Abstract;
using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAcces.Concrete
{
    public class CarRepo : ICarRepo
    {

        public Car AddCar(Car car)
        {
            using (var _db = new RentAcarDbContext())
            {
                _db.Cars.Add(car);
                _db.SaveChanges();
                return car;
            }

        }
        public void DeleteCar(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
                var deleted = _db.Cars.Find(id);
                _db.Cars.Remove(deleted);
                _db.SaveChanges();
            }
        }
        public List<Car> GetAllCars()
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Cars.ToList();

            }
        }
        public Car GetCarById(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Cars.Find(id);

            }
        }
        public Car UpdateCar(Car car)
        {
            using (var _db = new RentAcarDbContext())
            {
                _db.Cars.Update(car);
                _db.SaveChanges();
                return car;
            }

        }
    }
}
