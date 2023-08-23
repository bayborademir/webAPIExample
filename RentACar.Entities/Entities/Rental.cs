using System;
using System.Collections.Generic;

namespace RentACar.DataAcces.Models;

public partial class Rental
{
    public int RentalId { get; set; }

    public int CarId { get; set; }

    public int CustomeId { get; set; }

    public DateTime StartRent { get; set; }

    public DateTime EndRate { get; set; }
}
