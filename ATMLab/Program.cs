using System.Reflection.Metadata.Ecma335;

namespace ATMLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Minnie", "help", 569);

            Console.WriteLine("Name: " + a.Name);
            Console.WriteLine("Password: " + a.Password);
            Console.WriteLine("Balance: $" + a.Balance);

            ATM atm = new ATM();
            atm.CheckBalance();
            atm.Deposit(1000);
            atm.Withdraw(1000);
            atm.Register("Kelly", "apple");
            atm.PrintAccounts();

            atm.Login("Kelly", "apple");
            Console.WriteLine(atm.CurrentAccount.Name);

            atm.Login("no", "hehe");
            Console.WriteLine(atm.CurrentAccount.Name);

            atm.CheckBalance();
            atm.Deposit(1000);
            atm.Withdraw(10020);
            atm.Withdraw(50);
        }

    }
}