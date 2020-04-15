using RestaurantWebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.UserDirectory
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantContext _dataContext;
        public UserRepository(RestaurantContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Add(User user)
        {
            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task Delete(User user)
        {
            _dataContext.Users.Remove(user);
            await _dataContext.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task<User> GetById(Guid id)
            => await Task.FromResult(_dataContext.Users.FirstOrDefault(user => user.Id == id));

        public async Task<User> GetByUserName(string email)
            => await Task.FromResult(_dataContext.Users.FirstOrDefault(user => user.Email == email));

        public async Task Update(User user)
        {
            _dataContext.Users.Update(user);
            await _dataContext.SaveChangesAsync();
            await Task.CompletedTask;

        }
    }
}
