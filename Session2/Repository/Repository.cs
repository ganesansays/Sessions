using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    //Dont worry about this ... this is does a database

    public static class Repository
    {
        public static List<SalesPerson> SalesPerson = new List<SalesPerson>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Product> Products = new List<Product>();
        public static List<Sale> SaleList = new List<Sale>();
        public static List<Invoice> InvoiceList = new List<Invoice>();
        public static List<Bill> Bills = new List<Bill>();
    }
}
