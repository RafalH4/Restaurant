using AutoMapper;
using RestaurantWebApi.DishDirectory;
using RestaurantWebApi.DishDirectory.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.Utilities
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Dish, DishDto>();
            CreateMap<AddDishDto, Dish>()
                .ForMember(target => target.Id, config => config.MapFrom(src => Guid.NewGuid()))
                .ForMember(target => target.ImageUrl, config => config.MapFrom(src => SavingFilesUtility.GetPath(src.file)));
        }
    }
}
