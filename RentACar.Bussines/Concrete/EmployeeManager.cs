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
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeManager(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public Employee AddEmployee(Employee employee)
        {
            return _employeeRepo.AddEmployee(employee); 
        }

        public void DeleteEmployee(int id)
        {
             _employeeRepo.DeleteEmployee(id);    
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepo.GetEmployeeById(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            return _employeeRepo.UpdateEmployee(employee);   
        }

        public void UpdateEmployeePos(int id, string pos)
        {
           _employeeRepo.UpdateEmployeePos(id, pos);
        }
    }
}
