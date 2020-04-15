using RestaurantWebApi.UserDirectory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.UserDirectory
{
    public interface IUserService
    {
        Task Add(AddUserDto user);
        Task Delete(AddUserDto user);
        Task<string> Login(UserLoginDto userLogin);
    }
}
