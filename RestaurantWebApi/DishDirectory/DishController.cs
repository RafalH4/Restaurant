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

        [HttpGet("id/{id}")]
        public async Task<IActionResult> Get(Guid id)
            => Ok(await _dishService.GetById(id));

        [HttpGet("type/{type}")]
        public async Task<IActionResult> Get(string type)
            => Ok(await _dishService.GetByType(type));

        [HttpPost]
        public async Task Add([FromForm] AddDishDto dish)
        {
            await _dishService.Add(dish);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EditDishDto dish)
        {
            await _dishService.Update(dish);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _dishService.Delete(id);
            return Ok();
        }





    }
}