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
    public class RentalRepo : IRentalRepo
    {
        public Rental CreateRental(Rental rental)
        {
            using (var _db = new RentAcarDbContext())
            {
                 _db.Rentals.Add(rental);
                _db.SaveChanges();
                return rental;
            }
        }

        public void DeleteRental(int id)
        {
             using (var _db = new RentAcarDbContext())
            {
                var delete = _db.Rentals.Find(id);
                _db.Rentals.Remove(delete);
                _db.SaveChanges();
            }
            
        }

        public List<Rental> GetAllRentals()
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Rentals.ToList();
            }
        }

        public Rental GetRentalById(int id)
        {
            using (var _db = new RentAcarDbContext())
            {
                return _db.Rentals.Find(id);
            }
        }
    }
}
