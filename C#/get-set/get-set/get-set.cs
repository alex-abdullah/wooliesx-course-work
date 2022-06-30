using System;
namespace get_set
{
    public class Car
    {
        private string _basicEngine;
        private int _cost;

        public string BasicEngine { get { return _basicEngine; } }
        public int Cost { get { return _cost; } }

        public Car(string basicEngine, int cost)
        {
            _basicEngine = basicEngine;
            _cost = cost;
        }

        public void Upgrade(string engineUpgrade)
        {
            _basicEngine = engineUpgrade;
            _cost = _cost * 2;
        }
    } }