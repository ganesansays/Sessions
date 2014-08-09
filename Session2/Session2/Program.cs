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
                Console.WriteLine("Which information you want to act on?");
                Console.WriteLine("[1]: Customer");
                Console.WriteLine("[2]: Product");
                Console.WriteLine("[3]: Sales Person");
                Console.WriteLine("[4]: Sale");
                Console.WriteLine("[5]: Invoice");
                Console.WriteLine("[6]: Bill");

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
                        Customer cust = GatherCustomerInformation();
                        CustomerOperation.CreateCustomer(cust);
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
                    default:
                        Console.WriteLine("Please enter a valid choice ...");
                        continue;
                }
            }
        }

        private static Customer GatherCustomerInformation()
        {
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


//Changes by Maniraja

namespace Session2
{

    class SalesOperations
    {
        public void CreateSale(Sale saleObj)
        {
            Repository.SaleList.Add(saleObj);
        }
        public Sale FetchSale (int Id)
        {
            return Repository.SaleList.Find(tempSaleObj => tempSaleObj.Id == Id);
        }
        public void UpdateSale(Sale saleObj)
        {
            if (saleObj == null) return;

            Sale saleResultObj = Repository.SaleList.Find( tempSaleObj => tempSaleObj.Id == saleObj.Id);

            if (saleResultObj != null)
            {

                saleResultObj.Id = saleObj.Id;
                saleResultObj.SalesPersonId = saleObj.SalesPersonId;
                saleResultObj.CustomerId = saleObj.CustomerId;
                saleResultObj.ProductId = saleObj.ProductId;
                saleResultObj.Quantity = saleObj.Quantity ;
                saleResultObj.Discount = saleObj.Discount;
            }
        }

        public void DeleteSale(int Id)
        {
            Sale saleObj = Repository.SaleList.Find(tempSaleObj => tempSaleObj.Id == Id);

            if (saleObj != null)
            {
                Repository.SaleList.Remove(saleObj);
            }
        }
    }

}





