using System;
namespace Polymorphism
{
    public class Car : IMakeSound
    {
        public double speed = 0;
        public void Accelerate(double amount)
        {
            speed += amount;
        }

        public string Sound()
        {
            if (speed > 80)
                return "VROOOOOOOOOOM";
            if (speed > 0)
                return "vroom";
            return "nieeeegh";
        }

        public void MakeSound()
        {
            Console.WriteLine(Sound());
        }

        public void Stop()
        {
            speed = 0;
        }

        public Car()
        {
        }
    }
}
