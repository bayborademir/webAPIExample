using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.DataAcces.Models;
using RentACar.Entities.DTOs;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignInController : Controller
    {
        private readonly SignInManager<AspNetUser> _signManager;

        public SignInController(SignInManager<AspNetUser> signManager)
        {
            _signManager = signManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInDTO dto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signManager.PasswordSignInAsync(dto.UserName1, dto.Password, false, true);
                if (result.Succeeded)
                {
                    return Ok("Grişi Başaerılı");
                }
                else
                {
                    return Ok("Giriş Başarısız");
                }
            }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await _signManager.SignOutAsync();
            return Ok("Çıkış yapıldı");
        }


    }
}

