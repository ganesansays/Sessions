using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using Session2.View;
using Session2.Framework;

namespace Session2.View
{
    class SalesPersonView : IView
     {
        SalesPerson spObj = null;
        string spMessage = string.Empty;

        public SalesPersonView()
        {

        }
        public SalesPersonView(String message)
        {
            spMessage = message;
        }
        public SalesPersonView(Object spObj)
        {
            this.spObj = spObj as SalesPerson;
        }
        public Intent Display()
        {
            Console.Clear();
            int id = 0;

            if (!string.IsNullOrEmpty(spMessage))
            {
                Console.WriteLine(spMessage);
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

            if (spObj != null)
            {
                Console.WriteLine("This is an existing Sales Person, Name: " + spObj.Name);
                id = spObj.Id;
            }
            else
            {
                Console.Write("Enter Sales Person Id: ");
                string idInput = Console.ReadLine();
                Int32.TryParse(idInput, out id);
            }

            Console.Write("Enter Sales Person Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Sales Person Contact Number: ");
            string contactNumber = Console.ReadLine();

            SalesPerson sp = new SalesPerson(id, name, contactNumber);

            Intent intent = new Intent(Intent.SALES_PERSON_ENTITY, Intent.SAVE);
            intent.Param = sp as object;

            return intent;

        }
    }
}


