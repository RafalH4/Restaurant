using RestaurantWebApi.UserDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.Utilities
{
    public interface IJwtHandler
    {
        public string CreateToken(User user);
    }
}
