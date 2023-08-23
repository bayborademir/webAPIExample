using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCreateController : ControllerBase
    {
        [HttpPost("[action]")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }
    }
}
