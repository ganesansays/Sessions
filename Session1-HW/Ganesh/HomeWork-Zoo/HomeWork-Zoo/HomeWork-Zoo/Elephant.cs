using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Zoo
{
    class Elephant: Animal
    {
        public Elephant(int age, int weight)
        {
           this.age = age;
           this.weight = weight;
        }
        private int age;
        private int weight;

        public override void feed()
        {
           Console.WriteLine("We are feeding Elephant of age " + age + " and weight " + weight);
        }
    }
}
