using BusinessEntities;
using Session2.Framework;
using Session2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.Controller
{
    class CustomerController : IController
    {
        public IView handleIntent(Intent intent)
        {
            if (intent.OperationToPerform == Intent.CREATE)
            {
                return new CustomerView();
            }
            else if (intent.OperationToPerform == Intent.FETCH_AND_UPDATE)
            {
                Customer custToDisplayFetch = CustomerOperation.FetchCustomer(intent.IdToActOn);

                if (custToDisplayFetch == null)
                {
                    return new CustomerView("Customer not found ... You can create a new customer ...");
                }

                return new CustomerView(custToDisplayFetch as object);
            }
            else if (intent.OperationToPerform == Intent.INVALID_ACTION)
            {
                return new HomeView("Invalid Action ...");
            }
            else if (intent.OperationToPerform == Intent.DELETE)
            {
                string messageDelete = CustomerOperation.DeleteCustomer(intent.IdToActOn);
                return new HomeView(messageDelete);
            }
            else if (intent.OperationToPerform == Intent.GO_TO_MAIN)
            {
                return new HomeView();
            }
            else if (intent.OperationToPerform == Intent.SAVE)
            {
                if (intent.Param != null)
                {
                    string messageSave = CustomerOperation.UpdateCustomer(intent.Param as Customer);
                    return new HomeView(messageSave);
                }
                return new HomeView("Customer not fount ...");
            }

            return new HomeView();
        }
    }
}
