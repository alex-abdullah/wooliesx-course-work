using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Collections
            // System.Collections namespace

            // Why do we use Collections?
            // Unlike arrays, collections will resize dynamically to fit the data in

            // In other words
            // Collections are similiar to arrays/objects in JS

            // Equivalents:
            // List - JS array
            // Dictionary - js object

            // Previously when adding items to an array, we would need to resize the array
            // Add the new item, and then reassign the new array to the old

            // LISTS

            // How to create a list:
            // List<type> name = new List<type>

            List<int> myNumbers = new List<int>();
            int[] myNumberArray = new int[1];

            //List<Movie> myFavouriteMovies = new List<Movie>();
            //Movie[] myFavouriteMoviesArray = new Movie[1];

            // Using .Add is like using .Push from JS

            myNumbers.Add(0);
            myNumbers.Add(70);
            myNumbers.Add(16);


            // Action is a C# verios of callback functions
            // We won't go into actions just yet
            // myNumbers.ForEach(Console.WriteLine);

            // How do we access the length of the list?
            // Typically arrays have a length
            // Lists have a count

            Console.WriteLine("My list has " + myNumbers.Count + " items");

            myNumbers.Add(250);

            Console.WriteLine("My list has " + myNumbers.Count + " items");


            // Accessing items in list:
            // Same as arrays:

            Console.WriteLine(myNumbers[1]);


            // What are some other useful methods?

            Console.WriteLine(myNumbers.Contains(70)); // The .includes method
            Console.WriteLine();

            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0


            // CHALLENGE: Lists

            //Create a list named books with 2 books already in it
            //Add 2 more books using the Add method
            //Iterate over the list using a for loop to log the book title as well as the index
            //Check if the list contains a specific book name, and remove it accordingly Hint: you may want to look a the methods available to you on the MSDN docs

            // Using Variables Example
            string bookOne = "LOTR";
            string bookTwo = "Harry Potter";

            List<string> MyBooks = new List<string>() { bookOne, bookTwo };

            string bookThree = "1984";
            string bookFour = "The Silver Sword";

            MyBooks.Add(bookThree);
            MyBooks.Add(bookFour);

            MyBooks.ForEach(Console.WriteLine);

            for (int i = 0; i < MyBooks.Count; i++)
            {
                Console.WriteLine($"Book Title = {MyBooks[i]}, Book Index = {i}");
            }

            if (MyBooks.Contains("Harry Potter") == true)
            {
                MyBooks.Remove("Harry Potter");
            }

            MyBooks.ForEach(Console.WriteLine);


            // Using Book Class Example

            Books firstBook = new Books("The Obstacle is the Way");
            Books secondBook = new Books("Courage is Calling");

            List<Books> MoreBooks = new List<Books>() { firstBook, secondBook };


            MoreBooks.ForEach(Console.WriteLine);

            Books thirdBook = new Books("Stillness is Key");
            Books fourthBook = new Books("Ego is the enemy");

            MoreBooks.Add(thirdBook);
            MoreBooks.Add(fourthBook);

            MoreBooks.ForEach(Console.WriteLine);

            for (int i = 0; i < MoreBooks.Count; i++)
            {
                Console.WriteLine($"Book Title is {MoreBooks[i]}, index is {i}");
            }

            //if (MoreBooks.Contains(thirdBook) == true)
            //{
            //    MoreBooks.Remove(thirdBook);
            //}

            //MoreBooks.ForEach(Console.WriteLine);


            Books foundBook = MoreBooks.Find((Books book) => book.Title.Contains("Ego"));
            Console.WriteLine(foundBook.Title);

            // This method takes in another method that fits the following pattern:
            // The mehod receives a book as a parameter, and returns true or false


            foreach (Books book in MoreBooks)
            {
                Console.WriteLine(book.Title);
            }

            foreach (Books book in MoreBooks.ToArray())
            {
                Console.WriteLine(book.Title);
            }


            // Dictionaries
            // What is the benefit of using a Dictionary over a List?
            // => Be more specific by allocating data to a key
            // => Its a more robust way to store data that you want to retrieve easily
            // => Dictionaries are much faster


            // What are the disadvantages of using a Dictionary over a List?
            // => Dictionaries are much bigger in memory


            // What functionality does a dictionary share with a JS object?
            // => They both store key value pairs
            // => You do not look up via index, you use a key


            // What is a key?
            // => An identifier to find some data


            // What is a value?
            // => some data that relates to the associated key


            // What types can keys and values be?
            // => They can be anything at all


            // How can we check if a key is present in a dictionary?
            // => .ContainsKey method


            // How can we check if a value is present in a dictionary?
            // => .ContainsValue method


            // How can we iterate over values?
            // => foreach (string key in dict.values)



            // What is a KVP and how can we use them?
            // => Key Value Pair, keys can be used to look up their value


            // What happens if we try to add a key that already exists?
            // => Program will crash, this is not allowed
            // Similarly, if you access a key that does not exist



            Dictionary<string, string> LunchOrders = new Dictionary<string, string>();
            LunchOrders.Add("Calum", "Sandwich");
            LunchOrders.Add("Valerie", "Pasta");
            LunchOrders.Add("Remi", "Salad");

            // In our dictionary
            // The key is a string that represents somebody's name
            // And the value associated with that key, is their lunch order

            // Look up key in dictionary:

            Console.WriteLine(LunchOrders["Remi"]);
            Console.WriteLine(LunchOrders["Valerie"]);

            // If you try to access a key that is not in the dictionary, it will throw an exception
            // Console.WriteLine(LunchOrders["Aidan"]);

            // Sometimes you might need to check if a key is present before you access it
            if (!LunchOrders.ContainsKey("Aidan"))
                Console.WriteLine("Aidan brought lunch from home today");


            // Read all the values in a dictionary

            foreach (string LunchItem in LunchOrders.Values)
                Console.WriteLine("The Kitchen needs to prepare a {0}", LunchItem);


            // Who is having lunch today?

            foreach (string person in LunchOrders.Keys)
                Console.WriteLine("Order up for {0}", person);


            // How can we iterate over all the KVPs in the dictionary?
            foreach (KeyValuePair<string, string> kvp in LunchOrders)
                Console.WriteLine("{0} is having a {1}", kvp.Key, kvp.Value);



            Dictionary<string, Books> FavouriteBooks = new Dictionary<string, Books>() { { "Aidan", new Books("Catch 22") }, { "Alex", new Books("Courage is Calling") } };

            Books favebook = FavouriteBooks["Alex"];

            Console.WriteLine(favebook.Title);


            // You can't add keys in twice
            // keys MUST be unique!

            // Removing a key and adding a new one
            LunchOrders.Remove("Remi");
            LunchOrders.Add("Remi", "Pizza");

            Console.WriteLine($"Remi is eating {LunchOrders["Remi"]}");

            // Alternative:

            // Changing the value directly
            LunchOrders["Remi"] = "Subway";
            Console.WriteLine($"Remi is eating {LunchOrders["Remi"]}");



            // CHALLENGE: Dictionaries

            // Create a Dictionary called pets where the key is a string and the value is an Animal class that we have created previously
            //Each key represents an owner's name, and the it is linked to an animal
            //For this purpose, each person can only own 1 pet
            //Add 5 pets to the Dictionary
            //Iterate over the values and log each pet's name

            Dictionary<Person, Animals> PeopleWithPets = new Dictionary<Person, Animals>() {
                { new Person("Alex", 25), new Animals("Cat", "Nina", "Moew") },
                { new Person("Clint", 41), new Animals("Cat", "Max", "Meow") },
                { new Person("Shailo", 20), new Animals("Dog", "Bean", "Woof") },
                { new Person("Esther", 20), new Animals("Bird", "Crash", "Chirp") },
                { new Person("Aidan", 28), new Animals("Alien", "Theodore", "???") } };

            foreach (Animals pet in PeopleWithPets.Values)
                Console.WriteLine("Here is {0}", pet);

            foreach (Person person in PeopleWithPets.Keys)
                Console.WriteLine("Hey my name is {0}", person);


            // Take Home Challenge: Secret Santa
            // Your office is doing a secret santa, where each person is assigned another person
            // Create an appropriate data structure(either a List, Stack or Queue) and add every name in your cohort to it
            // Create a Dictionary named secretSanta where the keys and values are both a string that store who is buying for who
            // Add names from your data structure to your Dictionary, but each person may only appear as a key once and as a value once
            // Bonus:
            // Make the assignments random using the Random class

            List<string> Cohort = new List<string>()
            {
                "Alex",
                "Geoff",
                "Shailo",
                "Erin",
                "Clint",
                "Hira",
                "Mish",
                "Tanj",
                "Liz",
                "Esther",
                "Harley",
                "Aiysha"
            };

            // Creating empty dictionary
            Dictionary<string, string> secretSanta = new Dictionary<string, string>();

            // Instance of Random Class
            List<int> indexes = new List<int>();

            Random rnd = new Random();

            // Iterating over List
            for (int i = 0; i < Cohort.Count;)
            {
                // Adding each student from Cohort list as Key and
                // random index position as value
                //secretSanta.Add(Cohort[i++], Cohort[rnd.Next(0, 11)]);

                int randomNumber = rnd.Next(0, Cohort.Count);

                if (!indexes.Contains(randomNumber))
                {
                    indexes.Add(randomNumber);
                    secretSanta.Add(Cohort[i], Cohort[indexes[i]]);
                    i++;
                }

            };

            // Printing key value pairs
            foreach (KeyValuePair<string, string> kvp in secretSanta)
            {
                Console.WriteLine("{0} is Secret Santa for {1}", kvp.Key, kvp.Value);

            }


        }
    }
}
