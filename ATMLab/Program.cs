using System.Reflection.Metadata.Ecma335;

namespace ATMLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Minnie Bank.");

        }

        public static void Options(Account accounts)
        {
            Console.WriteLine("Would you like to register or login?");
        }
    }
}
/*Task: Using objects, write an ATM system that manages money in different accounts, while keeping users’ information private. 

What will the application do?
Create an ATM that logs a user into their account with the right password, and allows them to withdraw or deposit cash. 	
Allow the ATM to register a new account object by setting up a new name and password both of which should be private. 
Hint: The ATM will manage the accounts by delegating method calls to them

Build Specifications: Create 2 different classes: 
ATM - The ATM will act as a manager for the different accounts. The manager will need to track a list of accounts and which account is currently logged in. 
For methods the ATM will need the following: 
Register - Take in a name and password. Build a new account with that name and password and add it to the list of accounts. 
Login - this method will take in a username and password. First the method will check if there is a currently logged in user. If there is no logged in account, search the account list for an account that matches the name AND password. Once found, set that account to the current account. 
The following methods should only work if there’s a logged in account
Logout - Set the current account to null 
CheckBalance - Print the balance of the account 
Deposit - takes in an int and adds to the balance 
Withdraw - takes in an int and tries to subtract it from the balance. If the int is larger than the balance, do nothing and print an error message for the user 
Account - The account object will need to track the following: 
String Name 
String Password
Int Balance 

 */