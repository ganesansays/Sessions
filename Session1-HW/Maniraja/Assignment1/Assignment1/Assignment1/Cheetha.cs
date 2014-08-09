using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Cheetha : Animal, IClimbable
    {
        public Cheetha(int age, int weight) 
            : base (age, weight)
        {

        }
        
        //public new void Feed();
        public override void Feed()
        {
            Console.WriteLine("Feed Cheetha...");
            printAgeAndWeight();
        }

        public override void makeSound()
        {
            Console.WriteLine("Chetha sound ...");
        }

        public void Climb()
        {
            Console.WriteLine("Can Climb 100 feets");
        }
    }
}
