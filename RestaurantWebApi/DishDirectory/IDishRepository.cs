using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.DishDirectory
{
    public interface IDishRepository
    {
        Task Add(Dish dish);
        Task<Dish> GetById(Guid id);
        Task<IEnumerable<Dish>> GetByType(string type);
        Task Delete(Dish dish);
        Task Update(Dish dish);
    }
}
