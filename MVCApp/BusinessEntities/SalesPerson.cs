using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public SalesPerson(int Id, string Name, string ContactNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.ContactNumber = ContactNumber;
        }
    }
}
