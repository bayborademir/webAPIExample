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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepo _customeRepo;

        public CustomerManager(ICustomerRepo customeRepo)
        {
            _customeRepo = customeRepo;
        }

        public Customer AddCustomer(Customer customer)
        {
            return _customeRepo.AddCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customeRepo.DeleteCustomer(id);
        }

        public List<Customer> GetAll()
        {
           return _customeRepo.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _customeRepo.GetCustomerById(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
             return _customeRepo.UpdateCustomer(customer);
        }
    }
}
