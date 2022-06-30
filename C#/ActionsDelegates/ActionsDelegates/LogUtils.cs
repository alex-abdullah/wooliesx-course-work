using System;
using System.Collections.Generic;
using System.IO;
namespace ActionsDelegates
{
    public class LogUtils
    {
        public static void LogAll(IEnumerable<string> collection, Action<string> action)
        {
            // IEnumerable means
            // A class can be used in a foreach loop

            foreach(string item in collection)
            {
                action(item);
            }
        }

       
        public static void PrintMessage(string myString, int times, Action<string, int> action)
        {
            action(myString, times);
        }
        // What if instead of writing an entirely new method
        // Every time we want it to log slightly differently
        // We could write the method once, and pass in a behaviour
        // as a parameter
        // This is what an Action does

        // What should our action looks like?

        // Method signature of => Console.Writeline(item);

        // void ------- (string)

        // A method is defined by:
        // It's return type and parameters
    }
}
