using System;
using System.Collections.Generic;
using System.Text;

namespace lunch_buddies.RestaurantChoice
{
    class Restaurant
    {
        private List<string> _restaurantNames = new() { "CiCi's Pizza", "El Mexico", "Chili's", "Chick-fil-a", "Camino Real", "O' Charley's", "Nacho's" };
        public string Name { get; set; }

        public static void RestaurantChoice()
        {
            var random = new Random();
            int num = random.Next(_restaurantNames.Count);
            Name = _restaurantNames[num];
        }
    }
}