using System;

namespace get_set_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Movie ToyStory = new Movie("Toy Story", 81, Movie.RatingTypes.PG, 1995);
            Movie TheMatrix = new Movie("The Matrix", 136, Movie.RatingTypes.M, 1999);


            Console.WriteLine(TheMatrix.Info);
            Console.WriteLine(ToyStory.Info);

            TheMatrix.MostRecentWatchDate = DateTime.Now.Ticks;
            Console.WriteLine(TheMatrix.WatchCount);
        }
    }
}
