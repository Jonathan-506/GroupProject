// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using Transaction;
namespace GroupProject
{
    internal class Program
    {   
            List<Transaction> transactions = new List<Transaction>();

            public void SummaryDisplay()
            {
                foreach (var transaction in transactions)
                {
                    Console.WriteLine($"Total: {transaction.Total}, Description: {transaction.Description}");
                }
            }
            public Transaction LogNewTransaction(DateTime date, int total, string description)
            {
                transactions.Add((Transaction.NewTransaction(date, total, description)));
            }
    }

}