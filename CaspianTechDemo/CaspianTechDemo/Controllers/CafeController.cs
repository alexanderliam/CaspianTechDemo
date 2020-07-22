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

        private readonly ICalculator _calculator;

        private readonly IEnumerable<OrderItem> Menu = new List<OrderItem>() { MenuItem.Cola, MenuItem.Coffee, MenuItem.CheeseSandwich, MenuItem.SteakSandwich };

        public CafeController(ILogger<CafeController> logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet]
        public IEnumerable<OrderItem> Get()
        {
            _logger.LogInformation("Getting order Items");

            return Menu.ToArray();
        }

        [HttpPost("CalculatePrice")]
        public double CalculatePrice([FromBody] IEnumerable<OrderItem> orderItems)
        {
            _logger.LogInformation("Calculating Price");

            return _calculator.CalculatePrice(orderItems) + _calculator.CalculateServiceCharge(orderItems);
        }
    }
}
