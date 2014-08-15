using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Session2.View
{
    class ProductView
    {
        public static Product Create()
        {
            Console.Clear();
            Console.Write("Enter Product Id: ");
            string idInput = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Rate: ");
            string rateinput = Console.ReadLine();

            int id = 0;
            Int32.TryParse(idInput, out id);

            decimal rate = 0.00M;
            decimal.TryParse(rateinput, out rate);

            Product Prod = new Product(id, name, rate);

            return Prod;
        }

        public static int GetProductId()
        {
            Console.Clear();
            Console.Write("Enter Product Id: ");
            String idInput = Console.ReadLine();
            int id = 0;
            Int32.TryParse(idInput, out id);
            return id;

        }

        public static void DisplayProduct(Product ProdtoFetch)
        {
            if (ProdtoFetch != null)
               {
                 Console.WriteLine(ProdtoFetch.Name);
               }
            else
              {
                 Console.WriteLine("Product doesnt exist");
               }
                Console.WriteLine("press anykey to continue ...");
                Console.ReadLine();
        }

        public static Product UpdateProduct()
        {
            Console.Clear();
            Console.Write("Enter Product Id: ");
            string idInput = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Rate: ");
            string rateinput = Console.ReadLine();

            int id = 0;
            Int32.TryParse(idInput, out id);

            decimal rate = 0.00M;
            decimal.TryParse(rateinput, out rate);

            Product ProdtoUpdate = new Product(id, name, rate);

            return ProdtoUpdate;
        }
    }
}
