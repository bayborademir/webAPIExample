using RentACar.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Bussines.Abstract
{
    public interface IRentalService
    {
        public Rental CreateRental(Rental rental);
        public void DeleteRental(int id);
        public Rental GetRentalById(int id);
        public List<Rental> GetAllRentals();
    }
}
