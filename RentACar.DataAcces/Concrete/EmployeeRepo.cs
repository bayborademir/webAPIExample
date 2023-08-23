using RentACar.DataAcces.Abstract;
using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAcces.Concrete
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public Employee AddEmployee(Employee employee)
        {
            using (var _db = new RentAcarDbContext())
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return employee;
            }
        }
        public void DeleteEmployee(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
                var deleted = _db.Employees.Find(id);
                _db.Employees.Remove(deleted);
                _db.SaveChanges();
            }
        }
        public List<Employee> GetAllEmployees()
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Employees.ToList();
            }
        }
        public Employee GetEmployeeById(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Employees.Find(id);
            }
        }
        public Employee UpdateEmployee(Employee employee)
        {
            using (var _db = new RentAcarDbContext())
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return employee;
            }
        }
        public void UpdateEmployeePos(int id, string pos)
        {
            using (var _db = new RentAcarDbContext())
            {
                var change = _db.Employees.Find(id);
                change.Position = pos;
                _db.SaveChanges();
            }
        }
    }
}
