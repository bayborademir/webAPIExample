using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAcces.Abstract
{
    public interface ICustomerRepo
    {
        public Customer AddCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer);
        public void DeleteCustomer( int id);  
        public Customer GetCustomerById(int id);
        public List<Customer> GetAll();


    }
}
