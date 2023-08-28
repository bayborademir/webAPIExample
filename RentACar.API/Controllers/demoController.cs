using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class demoController : Controller
    {
        private readonly ILogger<demoController> _logger;

        public demoController(ILogger<demoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index()
        {
            _logger.LogInformation("bilgi deneme");
            _logger.LogWarning("uyarı deneme");

            return Ok();
        }
    }
}

