using System;
using System.Collections.Generic;
using System.Text;

namespace lunch_buddies
{
    class Restaurant
    {
        public string RestaurantName;
        readonly List<string> _restaurants = new List<string> { "Awash", "Fleet Street Pub", "Clawson's", "Soy Cubano" };

        public Restaurant()
        {
            Random randomRestaurant = new();
            int index = randomRestaurant.Next(_restaurants.Count);
            RestaurantName = _restaurants[index];
        }


    }
}