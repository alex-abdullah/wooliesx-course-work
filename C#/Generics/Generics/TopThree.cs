using System;
using System.Collections.Generic;
namespace Generics
{
    public class TopThree<T>
    {
        private T[] _collection = new T[3];
        public T First => _collection[0];
        public T Second => _collection[1];
        public T Third => _collection[2];

        public TopThree(T first, T second, T third)
        {
            _collection[0] = first;
            _collection[1] = second;
            _collection[2] = third;
        }

        public override string ToString()
        {
            return $"1. {_collection[0]}, 2. {_collection[1]}, 3. {_collection[2]}";
        }
    }
}
