﻿using BusinessEntities;
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

        public static void UpdateSalesPerson(SalesPerson salesPersonObj)
        {
            if (salesPersonObj == null) return;

            SalesPerson sp = Repository.SalesPerson.Find(
                    s => s.Id == salesPersonObj.Id
                );

            if (sp != null)
            {
                sp.Name= salesPersonObj.Name;
                sp.ContactNumber= salesPersonObj.ContactNumber;
            }
            else
            {
                Console.WriteLine("SalesPerson Not Available");
            }
        }

        public static void DeleteSalesPerson(int Id)
        {
            SalesPerson sp = Repository.SalesPerson.Find(
                    s => s.Id == Id
                );

            if (sp != null)
            {
                Repository.SalesPerson.Remove(sp);
            }
            else
            {
                Console.WriteLine("SalesPerson Not Available");
            }
        }

    }
}
