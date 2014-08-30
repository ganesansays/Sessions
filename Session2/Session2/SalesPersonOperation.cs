using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    static class SalesPersonOperation
    {
        public static void CreateSalesPerson(SalesPerson salesPerson)
        {
            Repository.SalesPerson.Add(salesPerson);
        }


        public static SalesPerson FetchSalesPerson(int Id)
        {
            return Repository.SalesPerson.Find(
                  sp => sp.Id == Id
              );
        }

        public static string UpdateSalesPerson(SalesPerson salesPerson)
        {
            if (salesPerson == null)
            {
                return "Sales Person Not Found";
            }

            SalesPerson sp = Repository.SalesPerson.Find(
                    s => s.Id == salesPerson.Id
                );

            if (sp != null)
            {
                sp.Name = salesPerson.Name;
                sp.ContactNumber = salesPerson.ContactNumber;
                return "SalesPerson updated successfuly";
            }
            else
            {
                Repository.SalesPerson.Add(salesPerson);
                return "Sales Person added ...";
            }
        }

        public static string DeleteSalesPerson(int Id)
        {
            SalesPerson sp = Repository.SalesPerson.Find(
                    s => s.Id == Id
                );

            if (sp != null)
            {
                Repository.SalesPerson.Remove(sp);
                return "SalesPerson Deleted Successfuly";
            }
            else
            {
                return "SalesPerson Not Available";
            }
        }

    }
}
