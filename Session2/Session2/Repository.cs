using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    //Dont worry about this ... this is does a database

    static class Repository
    {
        public static List<SalesPerson> SalesPerson;
        public static List<Customer> Customers;
        public static List<Product> Products;
        public static List<Sale> SaleList;
        public static List<Invoice> InvoiceList;
        public static List<Bill> Bills;
    }
}
