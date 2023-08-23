using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAcces.Abstract
{
    public interface ICarRepo
    {
        public Car AddCar(Car car);
        public Car UpdateCar(Car car);
        public void DeleteCar(int id);
        public Car GetCarById(int id);
        public List<Car> GetAllCars();
        
    }
}
