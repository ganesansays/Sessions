using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Session2
{
    public class RaiseInvoice
    {
       public void AddInvoice(Invoice invoice)
      {
        Repository.InvoiceList.Add(invoice);
      }
        //raise invoice
       public Invoice ReadInvoice(int Id)
        {
          return Repository.InvoiceList.Find(
                inv => inv.Id == Id
            );
        }

        public void UpdateInvoice(Invoice invoice)
        {
            if (invoice == null) return;

            Invoice inv = Repository.InvoiceList.Find(
                  i => i.Id == invoice.Id
                );

            inv.CustomerId = invoice.CustomerId;
            inv.SaleId = invoice.SaleId;
            inv.TotalAmount = invoice.TotalAmount;
        }

        public void DeleteInvoice(int id)
        {
            Invoice inv = Repository.InvoiceList.Find(
                i => i.Id == i.Id
                );

            if (inv != null)
            {
                Repository.InvoiceList.Remove(inv);
            }
        }
    }

}
