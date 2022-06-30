using System;

namespace get_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car MyCar = new Car("Not very good engine", 1000);

            MyCar.Upgrade("Super Zoom Engine");

            Console.WriteLine(MyCar.BasicEngine);
            Console.WriteLine(MyCar.Cost);

             
        }
    }
}
