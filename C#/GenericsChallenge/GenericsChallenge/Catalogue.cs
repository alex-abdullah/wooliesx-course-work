using System;
using System.Collections.Generic;

namespace GenericsChallenge
{
    public class Catalogue<T> 
    {
        public double total;

        public List<T> _myCatalogue;  

        public Catalogue()
        {
            _myCatalogue = new List<T>();
        }

        public void Add(T product)
        {
            _myCatalogue.Add(product);
        }

        //public double CalculateTotal()
        //{
        //    total = 0;
        //    foreach (T x in _myCatalogue)
        //    {
        //        total += x.CalculateTax();
        //    }

        //    return total;
        //}

        //public void ShowAllItems()
        //{
        //    foreach (T item in _myCatalogue)
        //    {
        //        Console.WriteLine(item.ItemName);
        //    }
        //}
    }
}
