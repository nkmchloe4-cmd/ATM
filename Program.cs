namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
           {
               new Customer(new Person("John Doe", "1234567890"), "1234"),
               new Customer(new Person("Jane Smith", "9876543210"), "5678"),
               new Customer(new Person("Alice Johnson", "3456789123"), "9101")

           };

            Console.WriteLine("==========================================");
            Console.WriteLine("Välkommen till Nordens ATM!");
            Console.WriteLine("==========================================");

            Console.Write("Slå in ditt bankkonto : ");
            string bankAccount = Console.ReadLine();

            Console.Write("Ange din fyrsiffriga PIN-kod: ");
            string pin = Console.ReadLine();

                Customer customer = null;

            foreach (var c in customers)
            {
                if (c.Person.BankAccount == bankAccount && c.ValidateAccount(pin))
                {
                    customer = c;
                    break;
                }
            }
            if (pin.Length != 4 || !int.TryParse(pin, out _ ))
            {
                Console.WriteLine("Ogiltig bankkonto eller PIN-kod.");
                return;
            }
            Console.WriteLine($"Välkommen, {customer.Person.Name}!");
          
            while (true)
            {
                Console.WriteLine("\nMeny:");
                Console.WriteLine("1. Kolla saldo");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Ta ut pengar");
                Console.WriteLine("4. Avsluta");
                Console.Write("Välj din alternativ: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Din saldo är: {customer.Account.Balance:C}");
                        break;
                    case "2":
                        Console.Write("Slå in summan pengar du vill sätta in: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                        {
                            customer.Account.Deposit(depositAmount);
                            Console.WriteLine("Du lyckades!!");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig summa.");
                        }
                        break;
                    case "3":
                        Console.Write("Ange summan pengar du vill ta ut: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                           if (customer.Account.Withdraw(withdrawAmount))
                            Console.WriteLine("Uttag lyckades.");
                           else
                                Console.WriteLine("Uttag överstiger saldo");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig summa.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Tack för du använde Nordens ATM. Hejdå!");
                        return;
                    default:
                        Console.WriteLine("Ogiltig val. Vargod och försök igen.");
                        break;
                }

            }
        }
    }
}
