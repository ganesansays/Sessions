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
                 Console.WriteLine("Fetched Product Name: " + prodtofetch.Name);
                 Console.WriteLine("Fetched Product Rate: " + prodtofetch.Rate);
                 return new ProductView(prodtofetch);
             }
             else
             {
                 return new HomeView("Product not available!!!");
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
                 string message = ProductOperation.DeleteProduct(intent.IdToActOn);
                 return new HomeView(message);
             }
             else
             {
                 return new HomeView("Product not found!!!");
             }
         }
             
                return new HomeView();
            
        }
    }

}
