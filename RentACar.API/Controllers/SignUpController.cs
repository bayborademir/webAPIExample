using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.DataAcces.Models;
using RentACar.Entities.DTOs;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : Controller
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly IMapper _mapper;

        public SignUpController(UserManager<AspNetUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(SignUpDTO dto)
        {
            if (ModelState.IsValid)
            {
                var user =_mapper.Map<AspNetUser>(dto);
                var result = await _userManager.AddPasswordAsync(user, dto.Password);

                if (result.Succeeded)
                {
                    return Ok("Başarılı");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return Ok();

        }
    }
}