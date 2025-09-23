using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Display
    {

        public void ScreenDisplay()
        {
            Console.Clear();

            StartUp();
            
            MenuDisplay();
        }

        public void StartUp()
        {
            Console.WriteLine("Welcome to basic finance App \n Press any Key to continue");
            Console.ReadKey(true);
        }
        public void MenuDisplay()
        {
            Console.Clear();

            Console.WriteLine("Please choose what you want to view!");
            Console.WriteLine("To choose what you want to view type t for transactions, c for categories, b for your main budget");


        }

        public void TransactionsDisplay()
        {
            Console.WriteLine();

            Console.WriteLine("Please input the amout spent.");
            string amount = Console.ReadLine();

            Console.WriteLine("Please input the date in MM/DD/YYYY format.");
            string date = Console.ReadLine();

            Console.WriteLine("Please input the Transaction type.");
            string type = Console.ReadLine();

        }

        public void BudgetDisplay()
        {
            Console.WriteLine("Nothing here! hit enter to return to menu");
            Console.ReadKey(true);
            MenuDisplay();
        }
        
        public void CategoriesDisplay()
        {
            Console.WriteLine("Nothing here! hit enter to return to menu");
            Console.ReadKey(true);
            MenuDisplay();
        }

        public void Menu(char letter)
        {

            switch (letter)
            {
                case 't':
                    TransactionsDisplay();
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
