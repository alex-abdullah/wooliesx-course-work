using System;

namespace WordleGang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string SecretWord = "Spark";
            int guesses = 6;

            Console.WriteLine("Guess a 5-letter word:");
            string WordGuess = Console.ReadLine();



            for (int i = 0; i < guesses; i++)
            {

                if (WordGuess == SecretWord)
                {
                    Console.WriteLine("You guessed correct!");
                    break;
                }
                else if (WordGuess != SecretWord)
                {
                    Console.WriteLine("Try again!");
                    WordGuess = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("You lose and you should feel bad");
                };
            };

        }
    }
}
