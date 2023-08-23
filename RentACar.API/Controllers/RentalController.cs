using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Bussines.Abstract;
using RentACar.DataAcces.Models;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _service;

        public RentalController(IRentalService service)
        {
            _service = service;
        }
        [HttpGet("id")]
        public Rental GetRentalById(int id)
        {
            return _service.GetRentalById(id);
        }
        [HttpGet]
        public List<Rental> GetAllRentals()
        {
            return _service.GetAllRentals();
        }
        [HttpPost]
        public Rental CreateRental(Rental rental)
        {
            return _service.CreateRental(rental);
        }
        [HttpDelete("id")]
        public string DeleteRental(int id)
        {
            _service.DeleteRental(id);
            return "Silme işlemi başarılı";
        }
    }
}
