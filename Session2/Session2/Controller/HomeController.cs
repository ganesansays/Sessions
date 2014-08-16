using Session2.Framework;
using Session2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.Controller
{
    class HomeController : IController
    {
        public IView handleIntent(Intent intent)
        {
            return new HomeView();
        }
    }
}
