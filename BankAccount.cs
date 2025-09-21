using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            {
                if (amount <= 0) balance += amount;
            }


        }
   public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            
                balance -= amount;            
        }

    }
}
