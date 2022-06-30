using System;
namespace Polymorphism
{
    public class Bicycle : IVehicle
    {
        public Bicycle()
        {
        }

        private int _speed;

        public int Speed { get => _speed; set => _speed = value; }

        public int MaxSpeed => 20;
        public int MaxPassengers => 1;

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
