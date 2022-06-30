using System;
using System.Collections.Generic;
namespace GenericsChallenge
{
    public class Product : IStore
    {
        private double _price;
        private double _tax = 0.1;
        private string _itemName;
        private int _stockAvailable;
        private int _maxStock;
        

        public double Price => _price;
        public double Tax => _tax;
        public string ItemName => _itemName;
        public int StockAvailable { get => _stockAvailable; }
        public int MaxStock { get => _maxStock; }

        

        public Product(string itemName, double price, int stockAvailable, int maxStock)
        {
            _itemName = itemName;
            _price = price;
            _stockAvailable = stockAvailable;
            _maxStock = maxStock;
        }

       

        public virtual double CalculateTax()
        {
            return _price * (1 + _tax);
        }

        public override string ToString()
        {
            return _itemName;
        }

        
        public bool Buy(int amt)
        {
            if (_stockAvailable < 1 || amt > _stockAvailable)
            {
                return false;
            }
            else
            {
                _stockAvailable -= amt;
                return true;
            }
        }

        public bool Refund(int amt)
        {
            if (_stockAvailable == _maxStock || amt + _stockAvailable > _maxStock)
            {
                return false;
            }
            else
            {
                _stockAvailable += amt;
                return true;
            }
        }
    }
}
