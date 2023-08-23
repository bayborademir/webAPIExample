using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Bussines.Abstract;
using RentACar.DataAcces.Models;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("id")]
        public Employee GetEMployeeById(int id)
        {
            return _employeeService.GetEmployeeById(id);
        }
        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();  
        }

        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {
            return _employeeService.AddEmployee(employee);  
        }

        [HttpPut]
        public Employee UpdateEmployee(Employee employee)
        {
            return _employeeService.UpdateEmployee(employee);
        }
        [HttpDelete]
        public string DeleteEmployee(int id)
        {
             _employeeService.DeleteEmployee(id);
            return "Silme işlemi başarılı";
        }
        //[HttpPut()]
        //public string UpdatePosEmp(int id , string pos)
        //{
        //    _employeeService.UpdateEmployeePos(id, pos);
        //    return "Pozisyon ekleme başarılı";
        //}

    }
}
