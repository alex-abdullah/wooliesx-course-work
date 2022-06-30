using System;
namespace Polymorphism
{
    public class SavingsAccount : Account
    {

        public SavingsAccount(double balance)
        {
            Balance = balance;
        }

        public override double GetInterestRate()
        {
            return 0.08;
        }


        public override double Withdraw(double amount)
        {
            if (amount < 0 || amount > Balance)
                return 0;
            return Balance -= amount;
        }

        public override double Deposit(double amount)
        {
            if (amount <= 0)
                return 0;
            return Balance += amount;
        }
    }
}
