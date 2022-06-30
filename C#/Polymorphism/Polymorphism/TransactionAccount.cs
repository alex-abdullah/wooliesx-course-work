using System;
namespace Polymorphism
{
    public class TransactionAccount : Account
    {
        public int OverDrawThreshold = 1000;
        public int OverDrawFee = 50;

        public TransactionAccount(double balance)
        {
            Balance = balance;            
        }

        public override double Deposit(double amount)
        {
            if (amount <= 0)
                return 0;
            return Balance += amount;
        }

        public override double GetInterestRate()
        {
            return 0;
        }

        public override double Withdraw(double amount)
        {
            if (amount > Balance + OverDrawThreshold)
                return 0;

            if (Balance - amount < 0)
            {
                return Balance -= amount - OverDrawFee;
            }

            return Balance -= amount;



        }

                      
    }
}
