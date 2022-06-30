using System;
namespace InterfaceDemo
{
    public class Player
    {
        private double _health;
        private double _maxHealth;
        private bool _isDead;

        public double Health { get => _health; set => _health = value; }
        public double MaxHealth { get => _maxHealth; }
        public bool IsDead => _isDead;
        public Player()
        {
            _maxHealth = 100;
            _health = _maxHealth;
        }

        public void Heal(double value)
        {
            if(value <= 0)
        }
    }
}
