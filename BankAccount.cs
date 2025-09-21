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

        public class Person
        { 
            public string Name { get; }
            public string PersonalId { get; }
            public Person(string name, string personalId)
            {
                Name = name;
                PersonalId = personalId;
            }
        }

        public class Customer
        { 
         public Person Person { get; }
         public BankAccount Account { get; }
         private string Pin { get; }
            
         public Customer(Person person, string pin)
         {
          Person = Person;
          Account = new BankAccount();
          Pin = pin;
         }

            private bool ValidatePin(string pin)
            { 
            return pin == Pin;
            }

        }
    }
}
