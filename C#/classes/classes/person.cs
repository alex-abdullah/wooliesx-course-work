using System;
namespace classes
{
    public class Person // internal means can only be accessed within the same name space 
   
        {
        public string Name; // can be accessed anywhere
        private long Age; // private means can only be accessed within a class
        public Animal Pet;

        static public string Species = "Homo Sapiens"; // static members belong to the class NOT the objects

            public Person (string name, long age)
        {
            Name = name;
            Age = age;
        }

            public void SayYourName()
        {
            Console.WriteLine("Hi my name is {0} and I am {1} years old.", Name, Age);
        }


        // Every object in C# has the ToString() method which gets called
        // by other methods such as Console.Writeline()
        public override string ToString()
        {

            if (Pet == null)
                return $"{Name}, {Age}";

            return $"{Name}, {Species} owns a {Pet.Species}";
        }

    }
    
}
