using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class ProductOperation
    {
        public static string CreateProduct(Product product)
        {
            if (product == null) return ("Error: No product available!!!");

            Product prod = Repository.Products.Find(
                    c => c.Id == product.Id
                );

            if (prod != null)
            {
                prod.Name = product.Name;
                prod.Rate = product.Rate;
                return ("Product is updated!!!");
            }
            else
            { 
                Repository.Products.Add(product);
                return ("Product is added!!!");
            }
        }

        public static Product FetchProduct(int Id)
        {
            return Repository.Products.Find(
                  prod => prod.Id == Id
              );
        }

        /*public static void UpdateProduct(Product product)
        {
           
        }*/

        public static string DeleteProduct(int Id)
        {
            Product prod = Repository.Products.Find(
                    p => p.Id == Id
                );

            if (prod != null)
            {
                Repository.Products.Remove(prod);
                return ("Product deleted successfully!!!");
            }
            else
            {
                return ("Product not found!!!");
            }
        }
    }
}
