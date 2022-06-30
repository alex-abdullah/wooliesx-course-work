using System;
using System.Collections.Generic;
namespace collections
{
    public class Books
    {

        public static List<Books> Library = new List<Books>();
        public string Title;
        public Books(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
