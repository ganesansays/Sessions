using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session2.View;
using Session2.Framework;
using BusinessEntities;

namespace Session2.Controller
{
    class SalesPersonController : IController
    {
       public IView handleIntent(Intent intentObj)
        {
            SalesPersonView spViewObj = null;
            if (intentObj.OperationToPerform == Intent.CREATE)
            {
                return new SalesPersonView();
            }
            else if (intentObj.OperationToPerform == Intent.FETCH_AND_UPDATE)
            {
                SalesPerson spDisplayFetch = SalesPersonOperation.FetchSalesPerson(intentObj.IdToActOn);
                if(spDisplayFetch == null)
                {
                    return new SalesPersonView("Sales Person not found...");
                }
                spViewObj = new SalesPersonView(spDisplayFetch as Object);
                return spViewObj;
            }
            else if(intentObj.OperationToPerform == Intent.GO_TO_MAIN)
            {
                return new HomeView("Going to Main Menu...");
            }
            else if (intentObj.OperationToPerform == Intent.DELETE)
            {
                string messageDelete = SalesPersonOperation.DeleteSalesPerson(intentObj.IdToActOn);
                return new HomeView(messageDelete);
            }
            else if(intentObj.OperationToPerform == Intent.GO_TO_MAIN)
            {
                return new HomeView();
            }
            else if(intentObj.OperationToPerform == Intent.SAVE)
            {
                if(intentObj.Param != null)
                {
                    string messageSave = SalesPersonOperation.UpdateSalesPerson(intentObj.Param as SalesPerson);
                    return new HomeView(messageSave);
                }
                return new HomeView("Sales Person Not Found ...");
            }
            return new HomeView();
        }
    }
}


