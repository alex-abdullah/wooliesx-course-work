using System;

namespace PolymorphismStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MainCast Lee = new MainCast("Lee", "JKD", 180);
            GuestCharacters Geese = new GuestCharacters("Geese", "Offensive", 200);

            TekkenCharacter[] MyCharacters = new TekkenCharacter[2];

            MyCharacters[0] = Lee;
            MyCharacters[1] = Geese;


        }
    }
}
