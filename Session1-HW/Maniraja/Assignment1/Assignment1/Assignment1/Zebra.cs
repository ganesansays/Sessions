using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Zebra : Animal
    {
        int age;
        int weight;
        public Zebra(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }
        public override void Feed()
        {
            Console.WriteLine("Feed Zebra..." + age + ".." + weight);
        }
    }
}
