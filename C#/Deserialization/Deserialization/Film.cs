using System;
using System.Collections.Generic;
namespace Deserialization
{
    public class Film
    {
        public int Year { get; set; }
        public string Title { get; set; }

        public void InsertTitle(string title)
        {
            Title = title;
        }

        public static void GenerateTitles(Dictionary<string, Film> dict)
        {
            foreach(KeyValuePair<string, Film> kvp in dict)
            {
                kvp.Value.InsertTitle(kvp.Key);
            }
        }
    }     
       
   
}
