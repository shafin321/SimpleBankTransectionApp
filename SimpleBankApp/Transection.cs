using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBankApp
{
  public class Transection
    {
        //In order to create Deposte and widraw we need history of transection
        //Create a journal of every transection of a account 
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Transection(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }
    }
}
