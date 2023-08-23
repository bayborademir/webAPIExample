using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Bussines.Abstract
{
    public interface ICustomerService
    {
        public Customer AddCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer);
        public void DeleteCustomer(int id);
        public Customer GetCustomerById(int id);
        public List<Customer> GetAll();

    }
}
