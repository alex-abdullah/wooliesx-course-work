using System;
namespace pangpang
{
    //Blueprint to describe how a dog works and what data it holds
    //Plan to create a dog
    public class DogClass
    {

        /*
         * Every class can have 3 types of things:
         *     1. Variables (member variables)
         *     2. Methods
         *     3. Static Methods (we'll get to this shit)
        */

        //Variables hold data about a class

        //public variables means you can touch them outside of the class
        public int ageVar; //defaulted to 0 if you dont touch it in a constructor
        public double weightVar; //defaulted to 0.0 if you dont touch it in a constructor
        public string breedVar; //defaulted to "" if you dont touch it in a constructor

        //next time
        public static int staticIntVar;

        /*
         * If a class doesn't define its own default constructor,
         * C# langauge will magically create one like this for you:
         * public DogClass() {} 
         * AKA do nothing at all when this class is created
         */

        public DogClass()
        {
            //Do jack all
            Console.WriteLine("2: A default dog class is currently being created as an object");
            Console.WriteLine("By default, this dog has age of {0}, weight of {1} and breed of {2}", ageVar, weightVar, breedVar);
        }

        //A more useful constructor
        public DogClass(int ageParamater, double weightParameter, string breedParameter)
        {
            Console.WriteLine("a parameterised dog class is being created");
            ageVar = ageParamater;
            weightVar = weightParameter;
            breedVar = breedParameter;
        }

        /*
         * Both a method and a function have 3 important things:
         * 1. Return type
         * 2. Name (constructors have no name)
         * 3. Parameters
         * and some other stuff ...
         */

        //Example method
        public int howOldAmIRightNow() {
            return ageVar;
        }

        public int howOldAmINextYear()
        {
            //You could do anything more complex
            return ageVar + 1;
        }

        public void printOutBreed()
        {
            Console.WriteLine(breedVar);
        }

        public void incrementAge(int increment)
        {
            ageVar += increment;
        }

        // A normal method is called on an object
        // A static method is called on a class
        // This means that a static method cannot access member variables, because there is no object
        //someStaticMethod is a method of the TYPE/CLASS, NOT the object
        public static void someStaticMethod()
        {
            //This will NEVER work because ageVar only exists if you have an object
            //Console.WriteLine(ageVar);
            Console.WriteLine("Hello from the dog class");
        }

        public void callStaticMethodFromObject()
        {
            DogClass.someStaticMethod();
            //CatClass.someOtherStaticMethod()
        }
    }
}
