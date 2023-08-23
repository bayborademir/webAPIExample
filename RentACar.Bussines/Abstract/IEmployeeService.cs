using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Bussines.Abstract
{
    public interface IEmployeeService
    {
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public void DeleteEmployee(int id);
        public Employee GetEmployeeById(int id);
        public List<Employee> GetAllEmployees();
        public void UpdateEmployeePos(int id, string pos);
    }
}
