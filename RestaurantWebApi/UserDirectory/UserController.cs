using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.UserDirectory.Dtos;

namespace RestaurantWebApi.UserDirectory
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm]AddUserDto user)
        {
            await _userService.Add(user);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm]UserLoginDto user)
        {
            var token = await _userService.Login(user);
            return Ok(new
            {
                token = token
            });
        }
    }
}