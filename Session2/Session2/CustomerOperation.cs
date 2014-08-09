using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    static class CustomerOperation
    {
        public static void CreateCustomer(Customer customer)
        {
            Repository.Customers.Add(customer);
        }

        public static Customer FetchCustomer(int Id)
        {
            /*for (int i = 0; i < Customers.Count; i++)
            {
                Customer cust = Customers[i];

                if (cust.Id == Id) return cust;
            }*/

            return Repository.Customers.Find(
                    cust => cust.Id == Id
                );
        }

        public static void UpdateCustomer(Customer customer)
        {
            if (customer == null) return;

            Customer cust = Repository.Customers.Find(
                    c => c.Id == customer.Id
                );

            if (cust != null)
            {
                cust.Name = customer.Name;
                cust.ContactNumber = customer.ContactNumber;
            }
        }

        public static void DeleteCustomer(int Id)
        {
            Customer cust = Repository.Customers.Find(
                    c => c.Id == Id
                );

            if (cust != null)
            {
                Repository.Customers.Remove(cust);
            }
        }
    }
}
