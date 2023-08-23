using System;
using AutoMapper;
using RentACar.DataAcces.Models;
using RentACar.Entities.DTOs;

namespace RentACar.API
{
	public class MapperProfile :Profile
	{
		public MapperProfile()
		{
			CreateMap<SignUpDTO, AspNetUser>().ReverseMap();
			CreateMap<SignInDTO, AspNetUser>().ReverseMap();
			CreateMap<RoleDTO, AspNetRole>().ReverseMap();
		}
	}
}

