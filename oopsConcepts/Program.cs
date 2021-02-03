using System;

namespace oopsConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new Account("Sanchit");
            acc.MakeDeposite(1000, "Cash", DateTime.Now);
            Console.WriteLine($"A new account has been created for {acc.Owner} with number {acc.Number} and balance of ${acc.Balance}/-");
            acc.MakeWithdrawal(17, "Zomato", DateTime.Now);
            Console.WriteLine("Remaining balance  $" + acc.Balance);
        }
    }
}
