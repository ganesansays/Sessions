using Session2.Controller;
using Session2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.Framework
{
    public interface IView
    {
        Intent Display();
    }

    public interface IController
    {
        IView handleIntent(Intent intent);
    }

    public static class MyFramework
    {
        public static IView handleRequest(Intent intent)
        {
            IController controller = null;
            switch (intent.EntityToActOn)
            {
                case 1:
                    controller = new CustomerController();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    controller = new HomeController();
                    break;
            }

            return controller.handleIntent(intent);
        }
    }
}
