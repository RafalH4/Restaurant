using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.UserDirectory
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Delete(User user);
        Task Update(User user);
        Task<User> GetByUserName(string email);
        Task<User> GetById(Guid id);

    }
}
