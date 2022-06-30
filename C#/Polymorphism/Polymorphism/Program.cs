using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Objectives
            // What is polymorphism?
            // How is it related to polymorphism?
            // How can multiple classes be treated as one?
            // What is an abstract class?
            // You cannot create an instance of an abstract
            // This prevents other developers (or yourself) from creating instances of classes not designed to be instantiated

            // What is an interface?
            // What is the difference between virtual and abstract?
            // VIRTUAL = has implementation AND can be overriden
            // ABSTRACT = no implemention BUT can be overriden

            // What is the difference between new and override?

            // What are abstract methods?
            // Abstract methods are methods that have no body / implementation
            // When you inherit from a class that has abstract methods
            // you HAVE to implement those methods

            // Allows us to create templates that define a bunch of features

            SavingsAccount mySavingsAccount = new SavingsAccount(10);

            
            // Interfaces
            // Much more common than abstract classes
            // Arguably more useful

            // What is an interface?
            // => very similar to an abstract class
            // => except all methods are abstract by default 
            // Why do you use interfaces?
            // What do interfaces allow us to do, that inheritance does not?
            // What is the relationship between an interface and an implementation class?

            // Can interfaces have fields/variables?
            // What is the interface naming scheme?
            // What are some common library interfaces?

            Cat Nina = new Cat();
            Nina.Name = "Nina";

            Nina.MakeSound();

            Car Rhonda = new Car();
            Rhonda.MakeSound();
            Rhonda.Accelerate(60);
            Rhonda.MakeSound();
            Rhonda.Accelerate(60);
            Rhonda.MakeSound();
            Rhonda.Stop();

            Console.WriteLine(Nina.Species);

            // Inheritance (regular and abstract)
            // has an "is" relationship

            // Interfaces can have gettable properties
            // But not fields

            // Challenge: Interfacing
            // Create an interface named IVehicle
            // IVehicle has the following members: Speed, MaxSpeed, IncreaseSpeed(), DecreaseSpeed(), MaxPassengers
            // Implement the IVehicle interface in the following classes:
            // Bicycle which has 1 max passenger and a max speed of 20
            // Motorbike which has 2 max passenger and a max speed of 140
            // Car which has 4 max passenger and a max speed of 120
            // GolfCart which has 4 max passenger and a max speed of 15

            BetterCar MySickCar = new BetterCar();
            MySickCar.Speed = 100;

            MySickCar.IncreaseSpeed(100);
        }
    }
}
