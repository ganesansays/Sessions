﻿using BusinessEntities;
using Session2.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.View
{
    class CustomerView : IView
    {
        Customer customer = null;
        string Message = string.Empty;

        public CustomerView()
        {

        }

        public CustomerView(string Message)
        {
            this.Message = Message;
        }

        public CustomerView(object param)
        {
            customer = param as Customer;
        }

        public Intent Display()
        {
            Console.Clear();
            int id = 0;

            if (!string.IsNullOrEmpty(Message))
            {
                Console.WriteLine(Message);
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

            if (customer != null)
            {
                Console.WriteLine("This is an existing customer. Name: " + customer.Name);
                id = customer.Id;
            }
            else 
            {
                Console.Write("Enter Customer Id: ");
                string idInput = Console.ReadLine();
                Int32.TryParse(idInput, out id);
            }

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string contactNumber = Console.ReadLine();

            Customer cust = new Customer(id, name, contactNumber);

            Intent intent = new Intent(Intent.CUSTOMER_ENTITY, Intent.SAVE);
            intent.Param = cust as object;

            return intent;
        }
    }
}
