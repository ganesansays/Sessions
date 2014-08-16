using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.View
{
    class CustomerView
    {
        public static int Display()
        {
            while(true) 
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

        public static Customer Create()
        {
            Console.Clear();
            Console.Write("Enter Customer Id: ");
            string idInput = Console.ReadLine();
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string contactNumber = Console.ReadLine();

            int id = 0;
            Int32.TryParse(idInput, out id);

            Customer cust = new Customer(id, name, contactNumber);

            return cust;
        }

        public static void Display(Customer cust)
        {
            if (cust != null)
            {
                Console.WriteLine(cust.Name);
            }
            else
            {
                Console.WriteLine("Customer doesnt exist");
            }

            Console.WriteLine("press anykey to continue ...");
            Console.ReadLine();
        }

        public static int GetCustomerId()
        {
            Console.Clear();
            Console.Write("Enter Customer Id: ");
            string idInput = Console.ReadLine();
            int id = 0;
            Int32.TryParse(idInput, out id);

            return id;
        }

        public static Customer Update()
        {
            Console.Clear();
            Console.Write("Enter Customer Id: ");
            string idInput = Console.ReadLine();
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string contactNumber = Console.ReadLine();

            int id = 0;
            Int32.TryParse(idInput, out id);

            Customer cust = new Customer(id, name, contactNumber);
            return cust;
        }
    }
}
