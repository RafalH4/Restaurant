
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
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MyProperty { get; set; }
        public string PhoneNumber { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
