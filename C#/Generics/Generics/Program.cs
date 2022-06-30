using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Generics

            // Objectives

            // What is a Generic?
            // => Generics are also referred to as 'type parameter'

            // What is a parameter?
            // => A parameter is when we pass in a value to a method

            // What is a type parameter?
            // => A type parameter is when we pass in a type to a class or method

            // Where have we seen this before?
            List<string> list = new List<string>();

            // I am creating a list
            // And the list is receiving a type parameter
            // Of type string
            // A type parameter passes in the type itself, not the value of that type

            // A type parameter can be any type
            // This can be manually restricted

            // Why is this important?
            // This allows us to write a class once
            // And support many different types automatically
            // Without having to manually write out every different version

            // We can also create methods that have type parameters
        }

        //int biggestNumber = GetLargest(50, 100);


        public static T GetLargest<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) > 0)
                return a;
            return b;
        }

        TopThree<string> myFaveWords = new TopThree<string>("Deluge", "Armada", "Syncopation");

        
        


        

        
    }
}
