using System;
namespace Polymorphism
{
    public class GolfCart : IVehicle
    {
        public GolfCart()
        {
        }

        private int _speed;

        public int Speed { get => _speed; set => _speed = value; }

        public int MaxSpeed => 15;

        public int MaxPassengers => 4;

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
