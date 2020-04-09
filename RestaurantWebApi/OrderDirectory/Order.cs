﻿
using RestaurantWebApi.DishDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.OrderDirectory
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}