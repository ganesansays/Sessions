using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using Session2.View;
using Session2.Controller;
using Session2.Framework;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intent intent = new Intent(0, 0);

            while (true) 
            {
                IView view = MyFramework.handleRequest(intent);
                intent = view.Display();

                if (intent.EntityToActOn == 7) return;
            }
        }
    }
}
        