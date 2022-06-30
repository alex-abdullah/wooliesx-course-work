using System;
namespace GenericsChallenge
{
    public class NewStock : IStore
    {


        //public NewStock(string itemName, double price, int stockAvailable, int maxStock) : base(itemName, price, stockAvailable, maxStock)
        //{
        //}

        //public bool Availability()
        //{
        //    if (Price > 100)
        //        return false;
        //    return true;
        //}
        public bool Buy(int amt)
        {
            throw new NotImplementedException();
        }

        public bool Refund(int amt)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "This is something";
        }
    }
}
