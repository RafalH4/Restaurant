using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.DishDirectory.Dtos;

namespace RestaurantWebApi.DishDirectory
{
    [Route("[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;
        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] AddDishDto dish)
        {
            await _dishService.Add(dish);
            return Ok(dish);
           
        }
    }
}