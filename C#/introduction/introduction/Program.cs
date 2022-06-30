using System;

// System is a library
// Contains a lot of commonly used classes

namespace introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // JS we would create variables with let or const
            // in C#, variables must be prefaced with their 
            int MyNumber;
            int MyNumber1;
            int MyNumber2;
            int MyNumber3;


            //Console.WriteLine("Welcome, Alex, to C#");
            //Console.WriteLine("What is your name?");
            //MyName = Console.ReadLine();
            //Console.WriteLine("Welcome " + MyName);
            //Console.WriteLine("How old are you?");
            //MyAge = Console.ReadLine();
            //Console.WriteLine("You are " + MyAge + " years old");

            // Ask user for their username
            // if username is equal to 'admin'
            // say 'welcome to admin panel'
            // otherwise say 'welcome user'
            // there is no ===, just use ==

            //Console.WriteLine("Please Type Username");
            //string Username = Console.ReadLine();

            //if(Username == "Admin")
            //{
            //    Console.WriteLine("Welcome to Admin Panel");
            //} else
            //{
            //    Console.WriteLine("Welcome " + Username);
            //};

            //Console.WriteLine(Username == "Admin" ? "Welcome to Admin Panel" : "Welcome " + Username);

            //int total = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(total);
            //    total += i;
            //}
            //Console.WriteLine(total);

            Console.WriteLine("Input a Number");
            MyNumber = Int32.Parse(Console.ReadLine());
            if(MyNumber > 0)
            {
                Console.WriteLine("n is positive");
            } else {
                Console.WriteLine("n is negative");
            };

            Console.WriteLine("Input 3 Numbers");
            MyNumber1 = Int32.Parse(Console.ReadLine());
            MyNumber2 = Int32.Parse(Console.ReadLine());
            MyNumber3 = Int32.Parse(Console.ReadLine());

            if(MyNumber1 > MyNumber2 && MyNumber1 > MyNumber3)
            {
                Console.WriteLine("N1 is the Largest");
            }
            else if(MyNumber2 > MyNumber1 && MyNumber2 > MyNumber3)
            {
                Console.WriteLine("N2 is the Largest");
            }
            else
            {
                Console.WriteLine("N3 is the Largest");
            }
        }
    }
}