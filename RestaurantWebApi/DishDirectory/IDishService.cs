﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.DishDirectory
{
    public class IDishService
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string TypeOfFood { get; set; }
    }
}
