using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Objectives
            // What is a method?
            // Why do we write them? Why do we use them?
            // How can we create a method in C#
            // What is return type?
            // What is void?
            // What are paramaters?
            // How do we write parameters?
            // What is a method overload?
            // WHat is the difference between a method and a function?
            // What is a static method?
            // What is an instance method?

            // What does method syntax look like?
            // Syntax:
            // [return type] [method name] ([parameters...]) {
            //          [method body]
            //          [return]

            // You can't write methods inside other methods
            // Methods belong to classes

            // To call a method
            // Write its name and use the ()
            // When writing methods in the program class, use 'Static'

            // Created Methods
            // Methods with return type
            // Methods with parameters
            // Methods with parameters and a return type

            // Find areas of:
            // circle
            // square
            // rectangle


            LogCurrentTime();
            LogCurrentTime();
            LogCurrentTime();

            Console.WriteLine(Sum(6,3));
            int myNumber = Sum(1000, 2000);

            Console.WriteLine("{0}: {1}", "The sum of 1000 and 2000", myNumber);

            //Methods challenge 1:
            // Find Area Method
            // Create a method named FindAreaOfCircle
            // It should take a single parameter, the radius
            // Should return the area of the circle
            // Find Area Method
            // Create a method named FindAreaOfSquare
            // It should take a single parameter, the side length
            // Should return the area of the square
            // Find Area Method
            // Create a method named FindAreaOfRectangle
            // It should take a two parameters, width and height
            // Should return the area of the rectangle
            // Hint: use floating point numbers

            Console.WriteLine("{0}: {1}", "The area of the circle is", CircleOfArea(10));
            Console.WriteLine("{0}: {1}", "The area of the square is", SquareArea(20));
            Console.WriteLine("{0}: {1}", "The area of the rectange is", RectangleArea(20, 50));



            // Method Overloads
            // What is an overloaded method?
            Console.WriteLine();
            // An overload is two methods that have the same name
            // But have different input parameters
            Sum(10.8492735, 9.85947593);

            Console.WriteLine(DateConverter(40));



            //Challenge: Date Formatter
            //Create a method that takes a long of "seconds" and returns
            //a string in the format "11h02m23s"
            //For example, 4000 seconds would be "01h06m40s"
            //Test the method by running it from Main


            //New
            //11:52
            //Bonus: handle days and years
            //Bonus bonus: omit sections that are 0(don't show years if the number is too small, for example)


        }
        static void LogCurrentTime()
        {
            
            Console.WriteLine(GetCurrentTime());
        }

        static string GetCurrentTime()
        {
            return DateTime.Now.ToString();
        }

        // Sum Method
        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        // Overload for sum method that takes in doubles
        static double Sum(double n1, double n2)
        {
            return n1 + n2;
        }



        //Circle

        static double CircleOfArea (double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        // Square

        static double SquareArea (double length)
        {
            return Math.Pow(length, 2);
        }

        // Rectangle

        static double RectangleArea (double h, double l)
        {
            return h * l;
        }

        static void PrintShoppingList (string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, strings[i]);
            }
        }

        static string DateConverter (long timeStamp)
        {
            // 3600 seconds per hour

            // HOURS
            long hours = timeStamp / 3600;
            long minutes = timeStamp % 3600 / 60;
            long seconds = timeStamp % 60;

            //Console.WriteLine($"h{hours}m{minutes}s{seconds}");

            return ($"h{hours}m{minutes}s{seconds}");


            // Create a method
            // Has a parameter "seconds" which is type long
            // returns a string in the format "11h23m02s"
            // Sample data

            // Identifying input and output
            // input => 4000 (this number represents seconds)
            // output => "01h06m40s"



        }
    }
}
