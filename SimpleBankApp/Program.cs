using System;

namespace SimpleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Kendra",2000); //account for kendra

            BankAccount account1 = new BankAccount("Gilliane",1000);// account 2 for Gilliane

            account.MakeDeposite(1000, DateTime.Now, "saving");

            account.MakeWidrawl(500, DateTime.Now, "PS4");

            account1.MakeWidrawl(100, DateTime.Now, "Chocletw");


            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.GetBalance()}");

            
            Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.GetBalance()} ");
        }
    }
}
