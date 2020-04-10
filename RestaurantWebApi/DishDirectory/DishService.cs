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
            var dish2 = _mapper.Map<Dish>(dishDto);
            var dish3 = _mapper.Map<Dish>(dishDto);

        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<DishDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DishDto>> GetByType(string type)
        {
            throw new NotImplementedException();
        }

        public Task Update(AddDishDto dishDto)
        {
            throw new NotImplementedException();
        }
    }
}
