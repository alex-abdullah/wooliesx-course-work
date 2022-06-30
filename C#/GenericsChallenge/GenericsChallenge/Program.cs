using System;
using System.Collections.Generic;

namespace GenericsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // // Generics challenge
            // Create a new class called Product, which has a price property
            // Product has a method called CalculateTax which returns the price at a 10% markup
            // Create two different classes that inherit from Productn (they can be anything you like)
            // But must set their price in the constructor
            // Create a Catalogue class that has a generic type parameter bound to Product
            // The catalogue has an Add method which takes a Product and adds it to the collection
            // Your Catalogue should have a method called CalculateTotal which adds up the CalculateTax
            // of all of the products it contains



            //NewStock myNewItem = new NewStock("Beaded Jump Rope", 39.99, 80, 100);
            //OldStock myOldItem = new OldStock("PVC Rope", 5.99, 95, 100);

            NewStock something = new NewStock();
            OldStock somethingElse = new OldStock();


            Product productOne = new Product("Hat", 10, 20, 50); 

            Catalogue<IStore> myWholeCatalogue = new Catalogue<IStore>();
            List<IStore> storeList = new List<IStore>();

            storeList.Add(something);
            storeList.Add(somethingElse);

            myWholeCatalogue.Add(something);
            myWholeCatalogue.Add(somethingElse);

            foreach(var item in myWholeCatalogue)
            {

            }


            storeList.ForEach(Console.WriteLine);

            myWholeCatalogue._myCatalogue.ForEach(Console.WriteLine);

            //Catalogue<OldStock> anotherCatalogue = new Catalogue<OldStock>();









            //myWholeCatalogue.Add(productOne);
            //myWholeCatalogue.Add(myOldItem);
            //myWholeCatalogue.Add(myNewItem);
            //var NikeSb = new Shoes("Nike SB", 89.99, 10, 15, 8.5);
            //NikeSb.ShoeSizeChecker(8.5);


            //Console.WriteLine(myWholeCatalogue.CalculateTotal());
            //myWholeCatalogue.ShowAllItems();           



            //Console.WriteLine(myNewItem.Refund(9));
            //Console.WriteLine(myNewItem.StockAvailable);

            //Console.WriteLine(productOne.Tax);
            //Console.WriteLine(myNewItem.Tax);





        }
    }
}
