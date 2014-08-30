using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Session2.View
{
    class BillView
    {
        public static Bill CreateBill()
        {
            Console.Clear();

            Console.Write("Enter Bill Id: ");

            string idInput = Console.ReadLine();

            Console.Write("Enter Invoice Id: ");

            string invoiceidInput = Console.ReadLine();

            Console.Write("Enter Customer Id: ");

            string customeridInput = Console.ReadLine();

            Console.Write("Enter Amount Paid: ");

            string amountpaidinput = Console.ReadLine();

            int id = 0;

            Int32.TryParse(idInput, out id);

            int invoiceid = 0;

            Int32.TryParse(invoiceidInput, out invoiceid);

            int customerid = 0;

            Int32.TryParse(customeridInput, out customerid);

            decimal amountpaid = 0.00M;

            decimal.TryParse(amountpaidinput, out amountpaid);

            Bill transbill = new Bill(id, invoiceid, customerid, amountpaid);

            return transbill;
        }

        public static int GetBillId()
        {
            Console.Clear();

            Console.Write("Enter Bill Id: ");

            string idInput = Console.ReadLine();

            int id = 0;

           Int32.TryParse(idInput, out id);

            return id;
        }

        public static void DisplayBill(Bill BilltoFetch)

        {
            if (BilltoFetch != null)
            {
                Console.WriteLine("Customer Id: " + BilltoFetch.CustomerId);
                Console.WriteLine("Invoice Id: " + BilltoFetch.InvoiceId);
                Console.WriteLine("Amount Paid: " + BilltoFetch.AmountPaid);
            }
            else
            {
                Console.WriteLine("Bill Id doesnt exist");
            }
                Console.WriteLine("press anykey to continue ...");
                Console.ReadLine();
        }

        public static Bill UpdateBill()
        {
            Console.Clear();
            Console.Write("Enter Bill Id: ");
            string idInput = Console.ReadLine();
            Console.Write("Enter Invoice Id: ");
            string invoiceidInput =Console.ReadLine();
            Console.Write("Enter Customer Id: ");
            string customeridInput =Console.ReadLine();
            Console.Write("Enter Amount Paid: ");
            string amountpaidinput =Console.ReadLine();
            int id = 0;
            Int32.TryParse(idInput, out id);
            int invoiceid = 0;
            Int32.TryParse(invoiceidInput, out invoiceid);
            int customerid = 0;
            Int32.TryParse(customeridInput, out customerid);
            decimal amountpaid = 0.00M;
            decimal.TryParse(amountpaidinput, out amountpaid);
            Bill BilltoUpdate = new Bill(id, invoiceid, customerid, amountpaid);

            return BilltoUpdate;
        }
    }
}
