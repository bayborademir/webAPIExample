using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.API.Contract;
using RentACar.Bussines.Abstract;
using RentACar.DataAcces.Models;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet("id")]
        public Customer GetCustomerById(int id)
        {
            return _service.GetCustomerById(id);
        }

        [HttpGet]
        public List<Customer> GetAllCustomers()
        {
            return _service.GetAll();
        }
        [HttpPost]
        public Customer AddCustomer(Customer customer)
        {
            return _service.AddCustomer(customer);
        }
        [HttpPut]
        public Customer UpdateCustomer(Customer customer)
        {
            return _service.UpdateCustomer(customer);
        }
        [HttpDelete("id")]
        public string DeleteCustomer(int id)
        {

            _service.DeleteCustomer(id);
            return "Sİlme İşlemi Başarıı";
        }
    }
}
