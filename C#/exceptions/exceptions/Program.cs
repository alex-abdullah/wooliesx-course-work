using System;
using System.Collections.Generic;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {


            // Objectives
            // What is an error?
            // What is a runtime error?
            // What are exceptions?
            // What are there different types of exceptions?
            // How can we throw exceptions?
            // How can we catch exceptions?
            // What is exception handling?
            // How do we catch specific exceptions?
            // What does 'travelling up the stack' mean?

            // Syntax error
            // int 1 = float;
            // The compiler can't understand what we're trying to do
            // And won't run the code at all until we resolve the error

            // Runtime errors occur while the program is running
            // When runtime error occurs, it throws an exception

            // Exception is a type/class

            Exception myException = new Exception();

            // Creating exceptions doesn't cause issues
            // Throwing exceptions doesn't necessarily cause issues
            // Exceptions that aren't caught cause issues

            // Try and Catch
            // Try is immediately folled by a Catch
            //string[] MyArray = new string[3];
            //string username = "";


            //try
            //{

            //Console.WriteLine(MyArray[4]);

            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    // Will only happen if an exception is thrown inside of the try block
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Username was not found");
            //    username = "unknown";

            //}

            //// As a general rule
            //// Try to write the smallest try/catches

            //Console.WriteLine(username);

            //try
            //{
            //    GenerateRandomNumbers();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            // Try Catch challenge
            // Create a Dictionary<string, string>
            // This Dictionary represents peoples lunch orders
            // Using a while loop, ask the user for their name and then their lunch order
            // Keep gathering orders and adding them to the dictionary until they enter an empty string
            // Add each name and lunch order into the Dictionary
            // However, make sure you catch any exceptions that occur when adding to the Dictionary and handle that exception appropriately so it doesn't crash your app!
            // At the end, log all of the lunch orders to the console.
            // If there are no lunch orders, throw an exception!
            // Note: Gathering input from the user in a while loop might also be something useful for your minesweeper app :)


            // PIRATE BAY CANTEEN
            Dictionary<string, string> LunchOrders = new Dictionary<string, string>();

            string name = "";
            string order = "";
            bool orders = true;

            while(orders == true)
            {
                Console.WriteLine("What's your name, Sport?");

                try
                {
                name = Console.ReadLine();
                if (name.Length == 0)
                    throw new Exception("Oi, what's your name, Champ?");

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Are you sure you're done with orders, Pal?");
                    string k = Console.ReadLine();
                    if (k == "no" || k == "nah" || k == "nope")
                    {
                        Console.WriteLine("What's ya name?");
                        continue;
                    

                    } else
                    {
                    break;

                    }
                }

                

                Console.WriteLine("What you want, Bucko?");
                order = Console.ReadLine();

                if (name.Length == 0)
                    orders = false;
                try
                {
                    LunchOrders.Add(name, order);

                }
                catch
                {
                    Console.WriteLine("You've already ordered broski");
                }
            }
            
        }

        //public static int[] GenerateRandomNumbers()
        //{
        //    Random random = new Random();
        //    int[] numbers = new int[2];
        //    numbers[0] = random.Next(0, 5);
        //    numbers[1] = random.Next(0, 5);

        //    if (numbers[0] == numbers[1])
        //        throw new Exception("Generated two of the same random numbers");
        //    return numbers;
        }


    }

