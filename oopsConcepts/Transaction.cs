using System;
namespace oopsConcepts
{
    public class Transaction
    {
        public Transaction(decimal amount, String note, DateTime date)
        {
            Amount = amount;
            Note = note;
            Date = date;
        }

        public decimal Amount;
        public String Note;
        public DateTime Date;
    }
}
