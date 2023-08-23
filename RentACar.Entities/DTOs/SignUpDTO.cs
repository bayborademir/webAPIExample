using System;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Entities.DTOs
{
	public class SignUpDTO
	{
        public string  UserName { get; set; }
        public string  Email { get; set; }
        public string  PhoneNmber { get; set; }
        public string  Password { get; set; }

    }
}

