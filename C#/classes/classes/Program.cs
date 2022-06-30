using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Objective
            // What is a class?
            // How do we create a class?
            // What is an object?
            // How do we create an object?
            // What is a constructor?
            // What are members?
            // What does static vs instantiated mean
            // What is scope
            // What is a namespace?

            // A class is a collection of properties, values, methods etc.
            // That all relate to one concept
            // Program is a class

            // Classes are also templates for objects
            // They determine what the object can do
            // And what properties it has

            // Class syntax
            // [scope] class [className] { ..members}

            // My class 'Person' is a template for an object

            // Person.SayYourName();

            // We need to create an instance of person
            // And get them to say their name

            // type is a class

            Person Alex = new Person("Alex", 25);
            Alex.SayYourName();

            Person Mish = new Person("Viet", 25);
            Mish.SayYourName();

            // Rather than changing from an arbitrary default value
            // We should give the values in when create the object

            // An object is an instance of a class
            // The constructor is a method that returns the object of that class

            // Classes don't just represent real world objects

            // What is public/private? What is internal?


            // CHALLENGE
            Animal Dog = new Animal("Dog", "Woof");
            //Console.WriteLine(Dog.Species);
            Dog.AnimalSounds();

            Animal Bear = new Animal("Bear", "Rawr XD");
            Bear.AnimalSounds();

            Animal Cow = new Animal("Cow", "Mooooooo");
            Cow.AnimalSounds();

            Animal Goat = new Animal("Goat", "BaaaaaaAaaaAaaa");
            Goat.AnimalSounds();


            // ==================================================

            Person.Species = "Homo Sapien";

            //Console.WriteLine(Person.Species); // static members belong to the class, do not require object reference
            //Console.WriteLine(Alex.Name); // non-static members belong to the object and require object reference
            //Console.WriteLine(Alex);


            // ==================================================


            // PET / PERSON CHALLENGE

            //Animal.Adopt(Alex, Dog);
            //Console.WriteLine(Alex);


            //Cow.Adopt(Mish);
            //Console.WriteLine(Mish);

            //===================================================

            // Experimenting with types
            // A way to categorise data
            // When we create a variable, it has a strict type

            /* Any time we use a type at all
             * any other type could be used the same way 
             * 
             * Variables
             * Parameters
             * Properties
             */

            //AdoptionCenter.Adopt(Alex, Cow);
            //Console.WriteLine(Alex);

            //AdoptionCenter.UnAdopt(Alex, Cow);
            //Console.WriteLine(Alex);

            AdoptionCenter.Adopt(Alex, Bear);
            Console.WriteLine(Alex);
                        
            Console.WriteLine(Bear.Owner);

        }
    }
}
