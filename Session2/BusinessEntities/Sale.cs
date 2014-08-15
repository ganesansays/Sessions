using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Sale
    {
        public int Id { get; set; }
        public int SalesPersonId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public Sale(int Id, int SalesPersonId, int CustomerId, int ProductId, int Quantity, decimal Discount)
        {
            this.Id = Id;
            this.SalesPersonId = SalesPersonId;
            this.CustomerId = CustomerId;
            this.ProductId = ProductId;
            this.Quantity = Quantity;
            this.Discount = Discount;
        }


    }
}
