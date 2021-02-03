using System;
using System.Collections.Generic;

namespace oopsConcepts
{
    public class Account
    {

        public String Number { get; }

        public String Owner { get; set; }

        public Decimal Balance { get {
                Decimal bal = 0;
                foreach (var transaction in allTransaction) {
                    bal += transaction.Amount;
                }
                return bal;
            } }

        private int seedAccountNumber = 123456789;

        private List<Transaction> allTransaction = new List<Transaction>();

        public Account(String name) {
            Number = seedAccountNumber.ToString();
            Owner = name;
            seedAccountNumber++;
        }

        public void MakeDeposite(decimal amount, String note, DateTime date) {
            if (amount > 0) {
                var deposite = new Transaction(amount, note, date);
                allTransaction.Add(deposite);
            }
        }

        public void MakeWithdrawal(decimal amount, String note, DateTime date) {
            if (Balance - amount > 0)
            {
                var withdrawal = new Transaction(-amount, note, date);
                allTransaction.Add(withdrawal);
            }
        }


    }
    
}
