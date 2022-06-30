using System;
namespace Polymorphism
{
    public class Motorbike : IVehicle
    {
        public Motorbike()
        {
        }

        private int _speed;

        public int Speed { get => _speed; set => _speed = value; }

        public int MaxSpeed => 140;

        public int MaxPassengers => 2;

        public void DecreaseSpeed(int decSpeedAmt)
        {
            if (_speed == 0)
            {
                Console.WriteLine($"She's not even moving, Champ.");
            }
            else
            {
                _speed -= decSpeedAmt;
                Console.WriteLine($"She's going {_speed}, watch out for coppers, Sport.");

            }
        }

        public void IncreaseSpeed(int incSpeedAmt)
        {
            if (_speed + incSpeedAmt >= MaxSpeed)
            {
                Console.WriteLine("She's going as fast as she can go, Bucko!");
            }
            else
            {
                _speed += incSpeedAmt;
                Console.WriteLine($"She's now going {_speed}");

            }
        }
    }
}
