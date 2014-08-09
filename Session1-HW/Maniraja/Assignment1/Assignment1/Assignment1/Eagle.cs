using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Eagle : Animal, IFlyable
    {
        public Eagle(int age, int weight) 
            : base (age, weight)
        {
        
        }

        public override void Feed()
        {
            Console.WriteLine("Feed Eagle...");
            printAgeAndWeight();
        }

        public override void makeSound()
        {
            Console.WriteLine("Eagle sound ...");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying ...");
        }
    }
}
