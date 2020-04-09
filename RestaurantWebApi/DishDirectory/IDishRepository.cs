using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.DishDirectory
{
    public interface IDishRepository
    {
        public Task Add(Dish dish);
        public Task GetById(Guid id);
        public Task GetByType(string type);
        public Task Delete(Guid id);
        public Task Update(Task task);
    }
}
