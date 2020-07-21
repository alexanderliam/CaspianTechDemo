using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaspianTechDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CaspianTechDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CafeController : ControllerBase
    {
        private readonly ILogger<CafeController> _logger;

        private readonly IEnumerable<OrderItem> Menu = new List<OrderItem>() { MenuItems.Cola, MenuItems.Coffee, MenuItems.CheeseSandwich, MenuItems.SteakSandwich };

        public CafeController(ILogger<CafeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<OrderItem> Get()
        {
            _logger.LogInformation("Getting order Items");

            return Menu.ToArray();
        }
    }
}
