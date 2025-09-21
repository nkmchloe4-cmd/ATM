using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance => balance;

        public void Deposit(decimal amount)
        {
            {
                if (amount > 0)
                    balance += amount;

            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;

        }
    }
        public class Person
        { 
            public string Name { get; }
            public string BankAccount { get; }
            public Person(string name, string bankAccount)
            {
                Name = name;
                BankAccount = bankAccount;
            }
        }

    public class Customer
    {
                private string Pin { get; }

        public Person Person { get; }
        public BankAccount Account { get; }

        public Customer(Person person, string pin)
        {
            Person = person;
            Account = new BankAccount();
            Pin = pin;
        }

        private bool ValidatePin(string pin)
        {
            return pin == Pin;
        }

        public bool Authenticate(string pin)
        {
            {
                return ValidatePin(pin);
            }


        }
    }
}
