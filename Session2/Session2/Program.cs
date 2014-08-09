using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Which information you want to act on?");
                Console.WriteLine("[1]: Customer");
                Console.WriteLine("[2]: Product");
                Console.WriteLine("[3]: Sales Person");
                Console.WriteLine("[4]: Sale");
                Console.WriteLine("[5]: Invoice");
                Console.WriteLine("[6]: Bill");
                Console.WriteLine("[7]: Exit");

                string choiceString = Console.ReadLine();
                int choice = 0;
                if (!Int32.TryParse(choiceString, out choice))
                {
                    Console.WriteLine("Please enter a valid choice ...");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        HandleCustomerInformation();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Please enter a valid choice ...");
                        continue;
                }
            }
        }

        private static void HandleCustomerInformation()
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
                }

                switch (choice)
                {
                    case 1:
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
                        CustomerOperation.CreateCustomer(cust);
                        Console.WriteLine("Sucessfully created ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter Customer Id: ");
                        idInput = Console.ReadLine();
                        id = 0;
                        Int32.TryParse(idInput, out id);
                        cust = CustomerOperation.FetchCustomer(id);

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
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter Customer Id: ");
                        idInput = Console.ReadLine();
                        Console.Write("Enter Customer Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Contact Number: ");
                        contactNumber = Console.ReadLine();

                        id = 0;
                        Int32.TryParse(idInput, out id);

                        cust = new Customer(id, name, contactNumber);

                        if (cust != null) 
                        { 
                            CustomerOperation.UpdateCustomer(cust);
                            Console.WriteLine("Sucessfully updated ... press anykey to continue ...");
                        }
                        else
                        {
                            Console.WriteLine("Customer doesnt exist");
                        }

                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter Customer Id: ");
                        idInput = Console.ReadLine();
                        id = 0;
                        Int32.TryParse(idInput, out id);
                        CustomerOperation.DeleteCustomer(id);
                        Console.WriteLine("Sucessfully deleted ... press anykey to continue ...");
                        Console.ReadLine();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
