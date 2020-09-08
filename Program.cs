using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerable {

    class Restaurants : IEnumerable {
        readonly public List<Restaurant> restaurants = new List<Restaurant> {
            new Restaurant ("R1", true),
            new Restaurant ("R2", false),
            new Restaurant ("R3", true)
        };
        public IEnumerator GetEnumerator () => new OpenRestaurantsEnumerator(restaurants);
    }
    class Program {
        static void Main (string[] args) {
            Restaurants restaurants = new Restaurants ();

            foreach (Restaurant restaurant in restaurants) {
                Console.WriteLine (restaurant.Name);
            }
        }
    }
}