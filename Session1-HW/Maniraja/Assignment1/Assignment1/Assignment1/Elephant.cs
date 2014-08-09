using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Elephant : Animal, IClimbable, IFlyable
    {
        public Elephant(int age, int weight)
            : base(age, weight)
        {
        
        }
        public override void Feed()
        {
            Console.WriteLine("Elephant Feed...");
            printAgeAndWeight();
        }
        
        public override void makeSound()
        {
            Console.WriteLine("Elephant sound ...");
        }

        public void Climb()
        {
            Console.WriteLine("Climbing ...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying ...");
        }
    }
}
