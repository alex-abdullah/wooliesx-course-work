using System;
namespace Polymorphism
{
    //Vehicle has the following members: Speed, MaxSpeed, IncreaseSpeed(), DecreaseSpeed(), MaxPassengers
    public interface IVehicle
    {
        public int Speed { get; set; }
    
        public int MaxSpeed { get; }
        public int MaxPassengers { get; }

        public void IncreaseSpeed(int amt);
        public void DecreaseSpeed(int amt);

        
           
        
    }
}
