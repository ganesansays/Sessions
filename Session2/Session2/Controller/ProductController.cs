using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using Session2.Controller;
using Session2.Framework;
using Session2.View;

namespace Session2.Controller
{
    class ProductController: IController
    {
     public IView handleIntent(Intent intent)
        {
         if (intent.OperationToPerform == Intent.CREATE)
         {
             return new ProductView();
         }
         else if (intent.OperationToPerform == Intent.SAVE)
         {
             string message = ProductOperation.CreateProduct(intent.Param as Product);
             return new HomeView(message);
         }
         else if (intent.OperationToPerform == Intent.FETCH_AND_UPDATE)
         {
             Product prodtofetch = ProductOperation.FetchProduct(intent.IdToActOn);
             if (prodtofetch != null)
             {
                 Console.WriteLine("Product Fetched!!!");
                 Console.WriteLine("Product Name: " + prodtofetch.Name);
                 Console.WriteLine("Product Rate: " + prodtofetch.Rate);
                 Console.WriteLine("Press enter to update...");
                 Console.ReadLine();
                 return new ProductView(prodtofetch);
             }
             else
             {
                 Console.WriteLine("Product not available!!!");
                 Console.WriteLine("Press enter to continue...");
                 Console.ReadLine();
                 return new HomeView();
             }
             
         }
         else if (intent.OperationToPerform == Intent.INVALID_ACTION)
            {
                return new HomeView("Invalid Action ...");
            }
         else if (intent.OperationToPerform == Intent.DELETE)
         {
             Product prodtodel = ProductOperation.FetchProduct(intent.IdToActOn);
             if (prodtodel != null)
             {
                 ProductOperation.DeleteProduct(intent.IdToActOn);
                 Console.WriteLine("Product deleted!!!");
                 Console.WriteLine("Press enter to continue...");
                 Console.ReadLine();
                 return new HomeView();
             }
             else
             {
                 Console.WriteLine("Product not available!!!");
                 Console.WriteLine("Press enter to continue...");
                 Console.ReadLine();
                 return new HomeView();
             }
         }
             
                return new HomeView();
            
        }
    }

}
