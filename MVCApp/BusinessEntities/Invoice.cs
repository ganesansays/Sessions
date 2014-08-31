using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SaleId { get; set; }
        public decimal TotalAmount { get; set; }

        public Invoice(int Id, int CustomerId, int SaleId, decimal TotalAmount)
        {
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.SaleId = SaleId;
            this.TotalAmount = TotalAmount;
        }
    }
}
