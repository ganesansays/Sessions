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
            switch (intent.OperationToPerform)
            {
                case 1: //Create 
                    return new CustomerView();
                case 2: //Fetch
                    Customer custToDisplayFetch = CustomerOperation.FetchCustomer(intent.IdToActOn); 

                    if(custToDisplayFetch == null)
                    {
                        return new HomeView("Customer does not exist ...");
                    }

                    return new CustomerView(custToDisplayFetch as object);
                case 3: 
                    return new HomeView("Invalid Action ...");
                case 4: 
                    string messageDelete = CustomerOperation.DeleteCustomer(intent.IdToActOn);
                    return new HomeView(messageDelete);
                case 5:
                    return new HomeView();
                case 6:
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
