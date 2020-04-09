using RestaurantWebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.DishDirectory
{
    public class DishRepository : IDishRepository
    {
        private readonly RestaurantContext _dataContext; 
        public DishRepository(RestaurantContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Add(Dish dish)
        {
            await _dataContext.Dishes.AddAsync(dish);
            await _dataContext.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task Delete(Dish dish)
        {
            _dataContext.Dishes.Remove(dish);
            await _dataContext.SaveChangesAsync();
            await Task.CompletedTask;
        }

        public async Task<Dish> GetById(Guid id)
            => await Task.FromResult(_dataContext.Dishes.SingleOrDefault(dish => dish.Id == id));

        public async Task<IEnumerable<Dish>> GetByType(string type)
            => await Task.FromResult(_dataContext.Dishes.Where(dish => dish.TypeOfFood == type));

        public async Task Update(Dish dish)
        {
            _dataContext.Dishes.Update(dish);
            await _dataContext.SaveChangesAsync();
            await Task.CompletedTask;
        }
    }
}
