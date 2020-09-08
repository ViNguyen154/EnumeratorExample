using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerable
{
    public class OpenRestaurantsEnumerator : IEnumerator
    {
        private readonly List<Restaurant> _restaurants;
        private int _position = -1;
        public  object Current
        {
            get
            {
                if (_position == -1 || _position >= _restaurants.Count)
                    throw new InvalidOperationException();

                return _restaurants[_position];
            }
        }
         public OpenRestaurantsEnumerator(List<Restaurant> restaurants)
        {
            _restaurants = restaurants;
        }
        public bool MoveNext()
        {
           while(_position < _restaurants.Count)
            {
                _position++;

                if (_position < _restaurants.Count && _restaurants[_position].IsOpen)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
           _position = -1;
        }
    }
}