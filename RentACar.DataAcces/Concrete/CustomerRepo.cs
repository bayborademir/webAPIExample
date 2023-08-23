using RentACar.DataAcces.Abstract;
using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAcces.Concrete
{
    public class CustomerRepo : ICustomerRepo
    {
        public Customer AddCustomer(Customer customer)
        {
            using (var _db = new RentAcarDbContext())
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                return customer;
            }
        }
        public void DeleteCustomer(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
               var deleted = _db.Customers.Find(id);
                _db.Customers.Remove(deleted);
                _db.SaveChanges();
            }
        }
        public List<Customer> GetAll()
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Customers.ToList();
            }
        }
        public Customer GetCustomerById(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Customers.Find(id);
            }
        }
        public Customer UpdateCustomer(Customer customer)
        {
            using (var _db = new RentAcarDbContext())
            {
                 _db.Customers.Update(customer);
                _db.SaveChanges();
                return customer;
            }
        }
    }
}
