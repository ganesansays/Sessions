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
        public static void CreateProduct(Product product)
        {
            Repository.Products.Add(product);
        }

        public static Product FetchProduct(int Id)
        {
            return Repository.Products.Find(
                  prod => prod.Id == Id
              );
        }

        public static void UpdateProduct(Product product)
        {
            if (product == null) return;

            Product prod = Repository.Products.Find(
                    c => c.Id == product.Id
                );

            if (prod != null)
            {
                prod.Name = product.Name;
                prod.Rate = product.Rate;
            }
        }

        public static void DeleteProduct(int Id)
        {
            Product prod = Repository.Products.Find(
                    p => p.Id == Id
                );

            if (prod != null)
            {
                Repository.Products.Remove(prod);
            }
        }
    }
}
