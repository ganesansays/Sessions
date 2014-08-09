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
             
        }

        public List<SalesPerson> SalesPerson;
        public List<Customer> Customers;
        public List<Product> Products;
        public List<Sale> SaleList;
        public List<Invoice> InvoiceList;
        public List<Bill> Bills;

        public void CreateCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer ReadCustomer(int Id)
        {
            /*for (int i = 0; i < Customers.Count; i++)
            {
                Customer cust = Customers[i];

                if (cust.Id == Id) return cust;
            }*/

            return Customers.Find(
                    cust => cust.Id == Id
                );
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer == null) return;
            
            Customer cust = Customers.Find(
                    c => c.Id == customer.Id
                );

            if (cust != null)
            {
                cust.Name = customer.Name;
                cust.ContactNumber = customer.ContactNumber;
            }
        }

        public void DeleteCustomer(int Id)
        {
            Customer cust = Customers.Find(
                    c => c.Id == Id
                );

            if (cust != null)
            {
                Customers.Remove(cust);
            }
        }

        //CRUD (Create/Read/Update/Delete) Customer
        //CRUD SalesPerson
        //CRUD Product

        //Create Sale (Product/Customer/Salesperson)
        //Raise Invoice (Customer/Product)
        //Pay Bill (Customer/Invoice)
    }
}
