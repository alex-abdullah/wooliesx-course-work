using System;
namespace GenericsChallenge
{
    public class Shoes : Product
    {
        private double _shoeSize;
        public double ShoeSize => _shoeSize;

        public Shoes(string itemName, double price, int stockAvailable, int maxStock, double shoeSize) : base(itemName, price, stockAvailable, maxStock)
        {
            _shoeSize = shoeSize;
        }


        public void ShoeSizeChecker(double size)
        {
            if (size == 0)
                Console.WriteLine("Stop screwing around, bud.");
            if (size != _shoeSize)
                Console.WriteLine($"Sorry, sport. We only have size {_shoeSize} available.");
            Console.WriteLine($"You're in luck, Bucko! We happen to have {StockAvailable} in your size!");
        }
    }
}
