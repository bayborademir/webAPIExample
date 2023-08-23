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
    public class CreateRolController : Controller
    {
        private readonly RoleManager<AspNetRole> _roleManager;

        public CreateRolController(RoleManager<AspNetRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleDTO dto)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new AspNetRole
                {
                   Name =dto.RoleName
                });

                if (result.Succeeded)
                {
                    return Ok("Rol Oluşturuldu");
                }
            }
            return Ok();
        }

    }
}

