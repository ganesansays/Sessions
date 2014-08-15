using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Session2.View
{
    static class SalePersonView
    {
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

        public static SalesPerson Create()
        {
            Console.Clear();
            Console.Write("Enter SalesPerson Id: ");
            string spIdInput = Console.ReadLine();
            Console.Write("Enter SalesPerson Name: ");
            string spNameInput = Console.ReadLine();
            Console.Write("Enter SalesPerson Number: ");
            string spContactNumberInput = Console.ReadLine();

            int id = 0;
            Int32.TryParse(spIdInput, out id);

            SalesPerson salePersonObject = new SalesPerson(id, spNameInput, spContactNumberInput);

            return salePersonObject;
        }

        public static void DisplaySalePerson(SalesPerson salePersonObj)
        {
            if (salePersonObj != null)
            {
                Console.WriteLine(salePersonObj.Name);
            }
            else
            {
                Console.WriteLine("Customer doesnt exist");
            }

            Console.WriteLine("press anykey to continue ...");
            Console.ReadLine();
        }

        public static int GetSalesPersonId()
        {
            Console.Clear();
            Console.Write("Enter SalesPerson Id: ");
            string idInput = Console.ReadLine();
            int id = 0;
            Int32.TryParse(idInput, out id);

            return id;
        }

        public static SalesPerson Update()
        {
            Console.Clear();
            Console.Write("Enter SalesPerson Id: ");
            string idInput = Console.ReadLine();
            Console.Write("Enter Sales Person Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Sales Person Contact Number: ");
            string contactNumber = Console.ReadLine();

            int id = 0;
            Int32.TryParse(idInput, out id);

            SalesPerson salesPersonObj = new SalesPerson(id, name, contactNumber);
            return salesPersonObj;
        }
    }


}
