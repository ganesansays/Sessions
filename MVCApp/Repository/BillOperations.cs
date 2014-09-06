using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    public class BillOperations
    {
        public static string CreateBill(Bill bill)
        {
            Repository.Bills.Add(bill);
            return ("Bill added!!!");
        }

        public static Bill FetchBill(int Id)
        {
            return Repository.Bills.Find(
                  bill => bill.Id == Id
              );
        }

        public static void UpdateBill(Bill bill)
        {
            if (bill == null) return;

            Bill identifiedBill = Repository.Bills.Find(
                    b => b.Id == bill.Id
                );

            if (identifiedBill != null)
            {
                identifiedBill.AmountPaid = bill.AmountPaid;
            }
        }

        public static void DeleteBill(int Id)
        {
            Bill bill = Repository.Bills.Find(
                    b => b.Id == Id
                );

            if (bill != null)
            {
                Repository.Bills.Remove(bill);
            }
        }
    }
}
