namespace GroupProject
{
    internal class Program
    {
        private DateTime _TransactionDate;
        private int _TransactionTotal;
        private string _TransactionDescription;    

        public Transaction NewTransaction(DateTime date, int total, string description)
        {
            return new Transaction(date, total, description);
        }
    }
}