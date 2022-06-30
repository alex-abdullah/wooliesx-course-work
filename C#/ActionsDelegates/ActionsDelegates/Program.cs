using System;
using System.Collections.Generic;
using System.IO;

namespace ActionsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Actions, Delegates and Predicates
            // Objectives
            // What is an arrow function JS?
            // => Function that is defined at runtime

            // What is the equivalent in C#?
            // => same syntax

            // What is an action?
            // => Is a function that has a return type of void and has T parameters

            // How do we give our functions parameters?
            // => When you declare your action, the type parameters
            // correspond to the type of each parameter, in the same order
            // Action<string, int, string>
            // Your function has the parameters of (string, int, string)

            // What is the method/function signature?
            // => It is the declaration of the function's return type and parameters

            // Why do we want to create actions?
            // => Less repetition
            // => We are decoupling our behaviour from our implementation
            // => Code becomes more reusable
            // => And simpler to read
            // How can actions and delegates help to create decoupled code?

            Dictionary<string, string> stringDict = new Dictionary<string, string>();
            stringDict.Add("Hello", "World");

            List<string> coaches = new List<string>();
            coaches.Add("Aidan");
            coaches.Add("Calum");
            coaches.Add("Mitch");

            Action<string> writeLine = Console.WriteLine;

            // We want to write the item to a file
            // BUT our function looks like this
            // void action (string, string)
            // and our method looks like this
            // how can we turn (string, string) into (string)

            Action<string> writeToFile = (string text) =>
            {
                File.AppendAllText("Logs.txt", text + "\n");
            };


            LogUtils.LogAll(coaches, writeLine);
            string[] coachArray = coaches.ToArray();
            LogUtils.LogAll(coachArray, writeToFile);

            // CHALLENGE: ACTIONS

            //            Create three Actions in your main class that have the same method signature
            //void Action(string, int)
            //Excite(string, int) logs a string that has int !'s added to the end
            //Excite("Cool", 3) => "Cool!!!";
            //            Repeat(string, int) logs a string that has been copied int times
            //            Repeat("Cool", 3) => "CoolCoolCool";
            //        Spread(string, int) logs a string that has had all the characters multiplied by int
            //        Spread("Cool", 3) => "CCCoooooolll";
            //        BONUS: Shift(string, int) logs a string that has been shifted int times
            //            Shift("Cool", 3) => "oolC";
            //              BONUS:
            //Ask the user if they want to their text to Excite, Repeat or Spread
            //Take a written input from the user and log it with the modifier they chose earlier applied


            Action<string, int> Excite = (string text, int excitementLevel) =>
            {
                for(int i = 0; i < excitementLevel; i++)
                {
                    text += "!";
                }

                Console.WriteLine(text);
            };

            LogUtils.PrintMessage("Cool", 5, Excite);










            Action<string, int> Repeat = (string text, int repeatTimes) =>
            {
                for (int i = 0; i < repeatTimes; i++)
                    Console.Write(text);
            };

            LogUtils.PrintMessage("Cool", 3, Repeat);

            Console.WriteLine("");











            Action<string, int> Spread = (string text, int spreadTimes) =>
            {
                foreach (char c in text)
                {
                    for (int i = 0; i < spreadTimes; i++)
                    {
                        Console.Write(c);
                    }
                }
            };

            LogUtils.PrintMessage("Cool", 3, Spread);
            Console.WriteLine("");












            Action<string, int> Shift = (string text, int shiftTimes) =>
            {
                var myStringArray = text.ToCharArray();

                int j = 0;
                int k = 0;
                for (int i = -1; k < myStringArray.Length; j++, k++)
                {
                    
                    if(i-1 < 0)
                    {
                        Console.Write(myStringArray[myStringArray.Length - 1]);
                    }
                    Console.Write(myStringArray[j - i]);
                }
            };

            LogUtils.PrintMessage("Spicy", 1, Shift);


            // Func

            // If an action has a T parameter
            // and a void return type

            // Func is almost the same as an Action
            // Except it also has a non-void return type

            // Func definition
            // Func<Tparam1, Treturn1 ...>

            // => Re-writing Excite
            // except it returns the string, insted of logging it
            // Funcs have a return type

            Func<string, int, string> funcExcite = (string text, int n) =>
            {
                string result = text;
                for (int i = 0; i < n; i++)
                    result += "!";
                return result;

            };

            // Actions return type is void
            Action<string, int> actionExcite = (string text, int excitementLevel) =>
            {
                for (int i = 0; i < excitementLevel; i++)
                {
                    text += "!";
                }

                Console.WriteLine(text);
            };


            // What is a delegate?
            // A delegate is the language equivalent of a method signature
            // A delegate is also the type you declare
            // if action<string> is the signature void ------- (string)
            // it is also the delegate
            // public delegate void myAction(string paramName)


            ButtonClickCallBack myHandler = (string text) =>
            {
                Console.WriteLine(text);
            };

        }
        delegate void ButtonClickCallBack(string text);

        public static void CreateMenuButton(string buttonText, ButtonClickCallBack callBack)
        {

        }
    }
}
