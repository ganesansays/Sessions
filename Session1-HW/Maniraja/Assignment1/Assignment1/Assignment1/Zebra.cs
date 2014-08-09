using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Zebra : Animal
    {
        public Zebra(int age, int weight) 
            : base (age, weight)
        {
        
        }

        public override void Feed()
        {
            Console.WriteLine("Feed Zebra...");
            printAgeAndWeight();
        }

        public override void makeSound()
        {
            Console.WriteLine("Zebra sound ...");
        }
    }
}
