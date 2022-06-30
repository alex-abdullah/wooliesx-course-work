using System;
namespace GenericsChallenge
{
    public class OldStock : IStore
    {
        //public OldStock(string itemName, double price, int stockAvailable, int maxStock) : base(itemName, price, stockAvailable, maxStock)
        //{
        //}

        //public bool Availability()
        //{
        //    if (Price > 50)
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
            return "This is something else";
        }
    }
}
