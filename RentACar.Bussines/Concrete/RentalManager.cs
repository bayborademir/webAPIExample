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
    public class RentalManager : IRentalService
    {
        private readonly IRentalRepo _repo;

        public RentalManager(IRentalRepo repo)
        {
            _repo = repo;
        }

        public Rental CreateRental(Rental rental)
        {
           return _repo.CreateRental(rental);
        }

        public void DeleteRental(int id)
        {
            _repo.DeleteRental(id); 
        }

        public List<Rental> GetAllRentals()
        {
            return _repo.GetAllRentals();
        }

        public Rental GetRentalById(int id)
        {
            return _repo.GetRentalById(id);
        }
    }
}
