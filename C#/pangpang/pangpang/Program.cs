using System;

namespace pangpang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the first line that ever runs in c# program");

            Console.WriteLine("1: Creating a Dog object from the Dog class");

            //DogClass is like the species of dog
            //alfred is like the actual animal breathing
            // = new DogClass() called the "default constructor" which means create it in the easiest way possible
            DogClass alfred = new DogClass();

            Console.WriteLine("3: Created alfred");

            int x = 5;

            /*TYPES
             * 
             * In the same way that alfred has a type of DogClass, 
             * x has a type of int 
            */

            //alfred sucks cause he has no data, bad boy
            //because alfred has public variables, we can set them know
            alfred.ageVar = 1;
            alfred.weightVar = 2.5;
            alfred.breedVar = "dirty staffy";

            Console.WriteLine("4: Alfred has data now: {0}, {1}, {2}", alfred.ageVar, alfred.weightVar, alfred.breedVar);

            DogClass viet = new DogClass(7, 4.20, "also a dirty staffy");
            Console.WriteLine("5: Viet has data now: {0}, {1}, {2}", viet.ageVar, viet.weightVar, viet.breedVar);

            //At the end of this we have:
            //1 class, DogClass
            //2 objects, alfred and viet, BOTH are DogClass type
            //alfred was created with the default constructor and we assigned member variables manually
            //viet was created with the parmaeterised constructor and we assigned member variables at the time of creation

            //alfred's member variable ageVar is completely different in the computer's RAM to viet's ageVar


            //I'm running the method "howOldAmIRightNow" on the alfred object, and assigning its value to a new
            //variable called alfredAge
            int alfredAge = alfred.howOldAmIRightNow();

            //This does aboslultey notyhing because I'm wasting the return type
            alfred.howOldAmIRightNow();

            Console.WriteLine("6: Alfred is {0} years old", alfredAge);
            Console.WriteLine("7: Alfred is {0} years old next year", alfred.howOldAmINextYear());

            Console.WriteLine("8: Calling the same method on a different object (viet) {0}", viet.howOldAmIRightNow());

            //This does something because the function prints something out
            alfred.printOutBreed();

            //make viet of age ;)
            viet.incrementAge(9);

            //2 ways I can get viet's age, either by member variable access OR by method call:
            //viet.ageVar OR viet.howOldAmIRightNow()
            Console.WriteLine("9: How old is viet now ;) {0}", viet.howOldAmIRightNow());

            //someStaticMethod is a method of the class, not an object (object == instance of a class)
            //alfred.someStaticMethod();
            DogClass.someStaticMethod();

            //Program.Main()

            Console.WriteLine("10: Calling a new static method {0}", CrapClass.someStaticUselessThing(9));

            Console.WriteLine("11: Calling the same static method on 2 different objects is the same");
            //An object method called callStaticMethodFromObject which then calls the class' static method someStaticMethod
            viet.callStaticMethodFromObject();
            alfred.callStaticMethodFromObject();
            /*
             * 
             * alfred
             * |
             *  - - callStaticMethodFromObject()
             *      | 
             *       - - > DogClass.someStaticMethod()
             *      | 
             *   - -
             * |
             *  viet
             */
        }
    }
}
