using RentACar.Bussines.Abstract;
using RentACar.DataAcces.Abstract;
using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Bussines.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarRepo _carRepo;

        public CarManager(ICarRepo carRepo)
        {
            _carRepo = carRepo;
        }

        public Car AddCar(Car car)
        {
            return _carRepo.AddCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepo.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            
            return _carRepo.GetAllCars();

        }

        public Car GetCarById(int id)
        {
            return _carRepo.GetCarById(id);
        }

        public Car UpdateCar(Car car)
        {
            return _carRepo.UpdateCar(car);
        }

        public List<int> GetAllCars2(string brand, string Model, int year)
       {

            var list1 = _carRepo.GetAllCars();
            var list2 = list1.Where(x => x.Brand == brand && x.Model == Model && x.Year < year).Select(c => c.CarId).ToList();
            return list2;

        }

    }
}
