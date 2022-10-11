using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLab
{
    public class ATM
    {
        public Account CurrentAccount { get; set; } = null;
        public List<Account> Accounts { get; set; } = new List<Account>();

        public ATM()
        {
            Accounts.Add(new Account("Milan", "hey", 5285));
            Accounts.Add(new Account("George", "jingle", 489283));
            Accounts.Add(new Account("Noah", "eatfood", 45194));
        }

        public void Register(string Name, string Password)
        {
            Account a = new Account(Name, Password, 0);

            Accounts.Add(a);
        }

        public void Login(string Name, string Password)
        {
            if (CurrentAccount == null)
            {
                Account match = Accounts.Where(a => a.Name == Name && a.Password == Password).FirstOrDefault();
                CurrentAccount = match;
            }
            else
            {
                Console.WriteLine("Another user is currently logged in.");
            }
        }

        public void Logout()
        {
            bool logged = IsLoggedIn();
            if (logged)
            {
                CurrentAccount = null;
            }
        }

        public void CheckBalance()
        {
            bool logged = IsLoggedIn();
            if (logged == true)
            {
                Console.WriteLine($"{CurrentAccount.Name}'s balance is {CurrentAccount.Balance}");
            }
            else
            {
                Console.WriteLine("No balance to show. No one is logged in.");
            }
        }

        public void Deposit(int amount)
        {
            bool logged = IsLoggedIn();
                if (logged == true)
            {
                CurrentAccount.Balance += amount;
                Console.WriteLine($"{amount} added to {CurrentAccount.Name}'s account.");
            }
            else
            {
                Console.WriteLine("Money not added. No one is logged in.");
            }
        }

        public void Withdraw(int amount)
        {
            bool logged = IsLoggedIn();
            if (logged == true)
            {
                if (CurrentAccount.Balance >= amount)
                {
                    CurrentAccount.Balance -= amount;
                    Console.WriteLine($"{CurrentAccount.Name} now has {CurrentAccount.Balance}.");
                }
                else
                {
                    Console.WriteLine($"{CurrentAccount.Name}'s balance is too low at {CurrentAccount.Balance}.");
                }
            }
        }
        public bool IsLoggedIn()
        {
            if (CurrentAccount == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void PrintAccounts()
        {
            foreach(Account a in Accounts)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
