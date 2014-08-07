using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Cheetha : Animal
    {
        int age;
        int weight;
        public Cheetha(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }
        //public new void Feed();
        public override void Feed()
        {
            Console.WriteLine("Feed Cheetha..." + age + ".." + weight);
        }
    }
}
