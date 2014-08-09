using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
             
        }

        
        //CRUD (Create/Read/Update/Delete) Customer
        //CRUD SalesPerson
        //CRUD Product

        public void CreateProduct(Product product)
        {
            Products.Add(product);
        }

        public Product FetchProduct(int Id)
        {
              return Products.Find(
                    prod => prod.Id == Id
                );
        }

        public void UpdateProduct(Product product)
        {
            if (product == null) return;

            Product prod = Products.Find(
                    c => c.Id == product.Id
                );

            if (prod != null)
            {
                prod.Name = product.Name;
                prod.Rate = product.Rate;
            }
        }

        public void DeleteProduct(int Id)
        {
            Product prod = Products.Find(
                    p => p.Id == Id
                );

            if (prod != null)
            {
                Products.Remove(prod);
            }
        }


        //Create Sale (Product/Customer/Salesperson)
        //Raise Invoice (Customer/Product)
        //Pay Bill (Customer/Invoice)
    }
}
