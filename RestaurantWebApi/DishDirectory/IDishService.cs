using RestaurantWebApi.DishDirectory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.DishDirectory
{
    public interface IDishService
    {
        Task Add(AddDishDto dishDto);
        Task Delete(Guid id);
        Task Update(EditDishDto dishDto);
        Task<DishDto> GetById(Guid id);
        Task<IEnumerable<DishDto>> GetByType(string type);
    }
}
