using System;
using System.Collections.Generic;

namespace RentACar.DataAcces.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public string LicensePlate { get; set; } = null!;
}
