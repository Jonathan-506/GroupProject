`using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Display
    {

        public static void ScreenDisplay()
        {
            Console.Clear();

            StartUp();
            
            MenuDisplay();
        }

        public static void StartUp()
        {
            Console.WriteLine("Welcome to basic finance App \n Press any Key to continue");
            Console.ReadKey(true);
        }
        public static void MenuDisplay()
        {
            Console.Clear();

            Console.WriteLine("Please choose what you want to view!");
            Console.WriteLine("To choose what you want to view type t for transactions, c for categories, b for your main budget");


        }

        public static void TransactionsDisplay(List<Transaction> transactions)
        { 
            Console.Clear();

            Console.WriteLine("Would you like to view your transaction history? Y/N");
            string response = Console.ReadLine();

            if (response == "Y")
            {
                ViewTransacitonHistory(transactions);
            }

            Console.WriteLine("Would you like to add a new Transaction?? Y/N");
            response = Console.ReadLine();


            if (response == "Y")
            {
                MakeTransacitonDisplay(transactions);
            }


        }

        public static void MakeTransacitonDisplay(List<Transaction> transactions)
        {

            Console.WriteLine("Please input the date in MM/DD/YYYY format.");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please input the amout spent.");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the description of the transaction.");
            string description = Console.ReadLine();

            Transaction.NewTransaction(date, amount, description, transactions);

        }
        public static void ViewTransacitonHistory(List<Transaction> transactions)
        {

            Console.WriteLine("Here are your Transactions: ");

            foreach (var transaction in transactions)
            {
                Console.Clear();

                Console.Write("Date: ");
                Console.Write(transaction._TransactionDate);
                Console.Write("Total: ");
                Console.Write(transaction._TransactionTotal);
                Console.Write("Description: ");
                Console.Write(transaction._TransactionDescription);

                Console.WriteLine("Press any key to see the next transaction.");
                Console.ReadKey(true);

            }
        }

        public static void BudgetDisplay()
        {
            Console.WriteLine("Nothing here! hit enter to return to menu");
            Console.ReadKey(true);
            MenuDisplay();
        }
        
        public static void CategoriesDisplay()
        {
            Console.WriteLine("Nothing here! hit enter to return to menu");
            Console.ReadKey(true);
            MenuDisplay();
        }

        public static void Menu(char letter, List<Transaction> transactions)
        {

            switch (letter)
            {
                case 't':
                    TransactionsDisplay(transactions);
                    break;
                case 'b':
                    BudgetDisplay();
                    break;
                case 'c':
                    CategoriesDisplay();
                    break;
                default:
                    Console.WriteLine("you shouldn't see this");
                    break;


            }
        }

        //public enum MenuCases
        //{
        //    Transactions = 't',
        //    Budget = 'b',
        //    Categories = 'c'
        //}
    }
}
