using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController
    {
        private static readonly string[] Food = new[]
      {
            "Pizza", "Burger", "Shawarma", "Sandwich", "French Fries",
        };
        private static readonly int[] Price = new[]
     {
            1100, 400, 300, 500, 250,
        };
        private readonly ILogger<MenuController> _logger;
        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<MenuModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new MenuModel
            {
                
                Price =Price[rng.Next(Price.Length)],
                Menu = Food[rng.Next(Food.Length)]
            })
            .ToArray();
        }
    }
}

