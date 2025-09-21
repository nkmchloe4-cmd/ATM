namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(100);
            Console.WriteLine("Balance after deposit: " + account.Balance);
            account.Withdraw(50);
            Console.WriteLine("Balance after withdrawal: " + account.Balance);
        }
    }
}
