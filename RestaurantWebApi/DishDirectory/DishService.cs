using AutoMapper;
using RestaurantWebApi.DishDirectory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.DishDirectory
{
    public class DishService : IDishService
    {
        private readonly IMapper _mapper;
        private readonly IDishRepository _repository;
        public DishService(IMapper mapper, IDishRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Add(AddDishDto dishDto)
        {
            var dish = _mapper.Map<Dish>(dishDto);
            await _repository.Add(dish);

        }

        public async Task Delete(Guid id)
        {
            var dish = await _repository.GetById(id);
            await _repository.Delete(dish);
        }

        public async Task<DishDto> GetById(Guid id)
        {
            var dish = await _repository.GetById(id);
            return _mapper.Map<DishDto>(dish);
        }
              
        public async Task<IEnumerable<DishDto>> GetByType(string type)
        {
            var dishes = await _repository.GetByType(type);
            var dishesDto = _mapper.Map<IEnumerable<Dish>, List<DishDto>>(dishes);
            return dishesDto;
        }

        public async Task Update(EditDishDto dishDto)
        {
            var dish = await _repository.GetById(dishDto.Id);
            dish.Name = dishDto.Name;
            dish.Price = dishDto.Price;
            dish.TypeOfFood = dishDto.TypeOfFood;
        }
    }
}
