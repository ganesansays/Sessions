using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Elephant : Animal
    {
        int age;
        int weight;
        public Elephant(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }
        public override void Feed()
        {
            Console.WriteLine("Elephant Feed..." + age + ".." + weight);
        }
     }
}
