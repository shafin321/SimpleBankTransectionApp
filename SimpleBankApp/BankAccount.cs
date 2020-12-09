using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBankApp
{
    public class BankAccount
    {
        //creating transection list 
        //In order to create Deposte and widraw we need history of transection
        //Create a journal of every transection of a account
        public List<Transection> allTransections = new List<Transection>();
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposite(initialBalance, DateTime.Now, "notes");
           
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

        public decimal GetBalance()
        {
            decimal Balance = 0;
            //returning /calculating balance from the history transection amount 
            foreach(var item in allTransections)
            {
                Balance = item.Amount + Balance;
            }

            return Balance;

            

        }
        public void MakeDeposite(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of desposte must be positve");
            }
            var desposite = new Transection(amount, date, note);

            //In order to create Deposte and widraw we need history of transection
            //Create a journal of every transection of a account
            allTransections.Add(desposite);
        }

        public void MakeWidrawl(decimal amount , DateTime date, string note)
        {
            Transection widrawl = new Transection( -amount,date,note);
            allTransections.Add(widrawl);
        }
    }
}
