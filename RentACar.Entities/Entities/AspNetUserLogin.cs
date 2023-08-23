using System;
using System.Collections.Generic;

namespace RentACar.DataAcces.Models;

public partial class AspNetUserLogin
{
    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public string? ProviderDisplayName { get; set; }

    public int UserId { get; set; } 

    public virtual AspNetUser User { get; set; } = null!;
}
