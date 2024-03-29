﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.API.Contract;
using RentACar.Bussines.Abstract;
using RentACar.DataAcces.Models;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController: Controller
    {
        private readonly ICarService _carService;
        private readonly ICustomerService _cu;

        public CarController(ICarService carService, ICustomerService cu)
        {
            _carService = carService;
            _cu = cu;
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
