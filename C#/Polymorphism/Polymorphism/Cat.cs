using System;
namespace Polymorphism
{
    public class Cat : Animal, IMakeSound
    {
        public string Name;
        public string Colour;


        public Cat()
        {
            Species = "Cat";
        }

        public void MakeSound()
        {
            Console.WriteLine(Sound());
        }

        public string Sound()
        {
            return "meow";
        }
    }
}
