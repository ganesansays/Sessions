using Session2.Framework;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.View
{
    class ProductView : IView 
    {
        Product product = null;
        string message = string.Empty;
        int id = 0;

        public ProductView()
        {

        }
        
        public ProductView(object param)
        {
            this.product = param as Product;
        }
        public Intent Display()
        {
            if (product != null)
            {
                Console.WriteLine("Fetched Product Name: " + product.Name);
                Console.WriteLine("Fetched Product Rate: " + product.Rate);
                id = product.Id;
            }
            else 
            {
                Console.Clear();
                Console.Write("Enter Product Id: ");
                string idInput = Console.ReadLine();
                Int32.TryParse(idInput, out id);
            }
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Rate: ");
            string rateinput = Console.ReadLine();

            decimal rate = 0.00M;
            decimal.TryParse(rateinput, out rate);

            Product Prod = new Product(id, name, rate);

            Intent intent = new Intent(Intent.PRODUCT_ENTITY, Intent.SAVE);
            intent.Param = Prod as object;

            return intent;
        }
            
    }
}
