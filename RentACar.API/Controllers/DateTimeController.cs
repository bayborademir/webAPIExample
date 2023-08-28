using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using RentACar.API.Contract;

namespace RentACar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateTimeController : Controller
    {

        private readonly IMemoryCache _memoryCache;

        public DateTimeController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet]
        [Log4NetActionFilter]
        public DateTime Get()
        {
            DateTime current;
            bool deneme = _memoryCache.TryGetValue("Time", out current);

            if (!deneme)
            {
                current = DateTime.Now;
                var opt = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(6));
                _memoryCache.Set("Time", current, opt);
                return current;
            }

            return current;
        }
    }
}

