

namespace GroupProject
{
    public class Transaction
    {
        internal DateTime _TransactionDate;
        internal int _TransactionTotal;
        internal string _TransactionDescription;

        public Transaction()
        { 

        }
        public Transaction(DateTime transactionDate, int transactionTotal, string transactionDescription)
        {
            _TransactionDate = transactionDate;
            _TransactionTotal = transactionTotal;
            _TransactionDescription = transactionDescription;
        }

        public static void  NewTransaction(DateTime date, int total, string description, List<Transaction> transactions)
        {

            transactions.Add(new Transaction(date, total, description));
           
        }
    }
}