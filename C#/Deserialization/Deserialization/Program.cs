using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

namespace Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieData = File.ReadAllText("../../../movies.json");

            

            Dictionary<string, Film> filmList = JsonSerializer.Deserialize<Dictionary<string, Film>>(movieData);
            Console.WriteLine(filmList["TheMatrix"].Year);
            Console.WriteLine(filmList["TheShawshankRedemeption"].Year);

            Film.GenerateTitles(filmList);

        }
    }
}
