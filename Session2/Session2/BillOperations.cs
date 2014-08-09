using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class BillOperations
    {
        public void CreateBill(Bill bill)
        {
            Repository.Bills.Add(bill);
        }

        public Bill FetchBill(int Id)
        {
            return Repository.Bills.Find(
                  bill => bill.Id == Id
              );
        }

        public void UpdateBill(Bill bill)
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

        public void DeleteBill(int Id)
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
