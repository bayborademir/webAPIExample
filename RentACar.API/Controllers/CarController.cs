using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.API.Contract;
using RentACar.Bussines.Abstract;
using RentACar.DataAcces.Models;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController: ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        
        [HttpGet("id")]
        [Log4NetActionFilter]
        public Car GetCarById(int id)
        {
            return _carService.GetCarById(id);
        }
        [HttpGet]
        [Log4NetActionFilter]
        public List<Car> GetAllCars()
        {
            return _carService.GetAllCars();
        }
        [HttpPost]
        [Log4NetActionFilter]

        public Car AddCar(Car car)
        {
            return _carService.AddCar(car);
        }

        [HttpPut]
        [Log4NetActionFilter]
        public Car UpdateCar(Car car)
        {
            return _carService.UpdateCar(car);
        }
        [HttpDelete("id")]
        [Log4NetActionFilter]
        public string DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return "Başarı ile silindi";
        }
    }
}
