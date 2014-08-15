using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.View
{
    class SaleView
    {
        string v_userMenuChoice;
        int v_userChoice = 0;

        private static int i_SalesID;
        private static int i_SalesPersonID;
        private static int i_CustomerID;
        private static int i_SalesProductID;
        private static int i_SalesQuantity;
        private static decimal i_SalesDiscount;


        public static int Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What operation you want to perform?");
                Console.WriteLine("[1]: Create");
                Console.WriteLine("[2]: Fetch");
                Console.WriteLine("[3]: Update");
                Console.WriteLine("[4]: Delete");
                Console.WriteLine("[5]: Go to main menu");

                string choiceString = Console.ReadLine();
                int choice = 0;
                if (!Int32.TryParse(choiceString, out choice))
                {
                    Console.WriteLine("Please enter a valid choice ...");
                    continue;
                }
                return choice;
            }
        }

        public static Sale Create()
        {

            Console.Clear();
            Console.Write("Enter Sales ID:");
            i_SalesID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Person ID:");
            i_SalesPersonID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Customer ID:");
            i_CustomerID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Product ID:");
            i_SalesProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Quantity:");
            i_SalesQuantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Discount:");
            i_SalesDiscount = Convert.ToDecimal(Console.ReadLine());

            Sale o_sales = new Sale(i_SalesID, i_SalesPersonID, i_CustomerID, i_SalesProductID, i_SalesQuantity, i_SalesDiscount);
            return o_sales;
        }

        public static void Display(Sale o_sales)
        {
            if (o_sales != null)
            {
                Console.WriteLine("Sales ID : {0}", o_sales.Id);
                Console.WriteLine("Sales Person ID : {0}", o_sales.SalesPersonId);
                Console.WriteLine("Sales Customer ID : {0}", o_sales.CustomerId);
                Console.WriteLine("Sales Product ID : {0}", o_sales.ProductId);
                Console.WriteLine("Sales Quantity : {0}", o_sales.Quantity);
                Console.WriteLine("Sales Discount : {0}", o_sales.Discount);
            }
            else
            {
                Console.WriteLine("Sale doesnt exist");
            }

            Console.WriteLine("press anykey to continue ...");
            Console.ReadLine();
        }

        public static int GetSaleId()
        {
            Console.Clear();
            Console.Write("Enter Sales ID:");
            string idInput = Console.ReadLine();
            int id = 0;
            Int32.TryParse(idInput, out id);
            return id;
        }

        public static Sale Update()
        {
            Console.Clear();

            Console.Write("Enter Sales ID:");
            i_SalesID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Person ID:");
            i_SalesPersonID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Customer ID:");
            i_CustomerID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Product ID:");
            i_SalesProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Quantity:");
            i_SalesQuantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sales Discount:");
            i_SalesDiscount = Convert.ToDecimal(Console.ReadLine());

            Sale o_sales = new Sale(i_SalesID, i_SalesPersonID, i_CustomerID, i_SalesProductID, i_SalesQuantity, i_SalesDiscount);

            return o_sales;
        }

    }
}
