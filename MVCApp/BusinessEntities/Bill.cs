using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Bill
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public decimal AmountPaid { get; set; }

        public Bill()
        {

        }
        
        public Bill(int Id, int InvoiceId, int CustomerId, decimal AmountPaid)
        {
            this.Id = Id;
            this.InvoiceId = InvoiceId;
            this.CustomerId = CustomerId;
            this.AmountPaid = AmountPaid;
        }
    }
}
