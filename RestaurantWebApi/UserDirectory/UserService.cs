using RestaurantWebApi.UserDirectory.Dtos;
using RestaurantWebApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWebApi.UserDirectory
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtHandler _jwtHandler;
        public UserService(
            IUserRepository userRepository,
            IJwtHandler jwtHandler)
        {
            _userRepository = userRepository;
            _jwtHandler = jwtHandler;
        }

        public async Task Add(AddUserDto user)
        {
            var userFromDb = await _userRepository.GetByUserName(user.Email);
            if (userFromDb != null)
                throw new Exception("Bad user");

            var hmac = new HMACSHA512();

            var newUser = new User();
            newUser.Id = Guid.NewGuid();
            newUser.Email = user.Email;
            newUser.PasswordSalt = hmac.Key;
            newUser.PasswordHash = hmac.ComputeHash(Encoding.ASCII.GetBytes(user.Password));

            await _userRepository.Add(newUser);
        }

        public Task Delete(AddUserDto user)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Login(UserLoginDto userLogin)
        {
            var userFromDb = await _userRepository.GetByUserName(userLogin.Email);
            if (userFromDb == null)
                throw new Exception("No user");
            if (!userFromDb.CheckPassword(userLogin.Password))
                throw new Exception("Bad password");

            return _jwtHandler.CreateToken(userFromDb);
        }
    }
}
