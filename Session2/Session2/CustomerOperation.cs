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
            return Repository.Customers.Find(
                    cust => cust.Id == Id
                );
        }

        public static string UpdateCustomer(Customer customer)
        {
            if (customer == null) return "Customer does not exist";

            Customer cust = Repository.Customers.Find(
                    c => c.Id == customer.Id
                );

            if (cust != null)
            {
                cust.Name = customer.Name;
                cust.ContactNumber = customer.ContactNumber;
                return "Customer updated ...";
            }
            else
            {
                Repository.Customers.Add(customer);
                return "Customer added ...";
            }
        }

        public static string DeleteCustomer(int Id)
        {
            Customer cust = Repository.Customers.Find(
                    c => c.Id == Id
                );

            if (cust != null)
            {
                Repository.Customers.Remove(cust);
                return ("Customer delete successfully ...");
            }
            else
            {
                return("Customer doesnt exist ...");
            }
        }
    }
}
