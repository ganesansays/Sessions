using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }

        public Product()
        {

        }
        
        public Product(int Id, string Name, decimal Rate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Rate = Rate;
        }
    }
}
