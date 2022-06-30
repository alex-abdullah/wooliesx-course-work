using System;
namespace Polymorphism
{

    // Account is a template
    // This class exists to be inherited from
    // This not designed to be instantiated

    public abstract class Account
    {
            
        public double Balance;

        public abstract double GetInterestRate(); // Has no implementation
        

        public virtual double GetReturn(int years)
        {
            return Balance * Math.Pow((1 + GetInterestRate()), years);
        }

        public abstract double Withdraw(double amount);

        public abstract double Deposit(double amount);
    }
}
