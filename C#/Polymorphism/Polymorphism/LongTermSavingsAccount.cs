using System;
namespace Polymorphism
{
    public class LongTermSavingsAccount : Account
    {

        public LongTermSavingsAccount(double balance)
        {
            Balance = balance;
        }

        private long _mostRecentWithdrawl;
        public override double GetInterestRate()
        {
            // If enough time has passed since the most recent withdrawl
            if (DateTime.Now.Ticks - _mostRecentWithdrawl > 360000)
            {
                return 0.15;
            }
            return 0.05;
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

