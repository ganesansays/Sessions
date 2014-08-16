using Session2.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.View
{
    class HomeView : IView
    {
        public string Message { get; set; }

        public HomeView()
        {

        }

        public HomeView(string message)
        {
            this.Message = message;
        }

        public Intent Display()
        {
            int entityToActOn = 0;
            int operationToPerform = 0;
            int idToActOn = 0;

            while (true)
            {
                Console.Clear();

                if (!string.IsNullOrEmpty(Message)) 
                { 
                    Console.WriteLine(Message);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("Which information you want to act on?");
                Console.WriteLine("[1]: Customer");
                Console.WriteLine("[2]: Product");
                Console.WriteLine("[3]: Sales Person");
                Console.WriteLine("[4]: Sale");
                Console.WriteLine("[5]: Invoice");
                Console.WriteLine("[6]: Bill");
                Console.WriteLine("[7]: Exit");

                string choiceString = Console.ReadLine();

                if (!Int32.TryParse(choiceString, out entityToActOn))
                {
                    Console.WriteLine("Please enter a valid choice ...");
                    continue;
                }

                break;
            }

            if (entityToActOn != Intent.EXIT)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("What operation you want to perform?");
                    Console.WriteLine("[1]: Create");
                    Console.WriteLine("[2]: Fetch and update");
                    Console.WriteLine("[3]: Invalid Action ...");
                    Console.WriteLine("[4]: Delete");
                    Console.WriteLine("[5]: Go to main menu");

                    string choiceString = Console.ReadLine();
                    if (!Int32.TryParse(choiceString, out operationToPerform))
                    {
                        Console.WriteLine("Please enter a valid choice ...");
                        continue;
                    }

                    break;
                }

                if (operationToPerform == Intent.FETCH_AND_UPDATE || operationToPerform == Intent.DELETE)
                {
                    Console.Write("Enter Id to act on: ");
                    string idToActOnString = Console.ReadLine();
                    Int32.TryParse(idToActOnString, out idToActOn);
                }
            }

            Intent intent = new Intent(entityToActOn, operationToPerform);
            intent.IdToActOn = idToActOn;

            return intent;
        }
    }
}
