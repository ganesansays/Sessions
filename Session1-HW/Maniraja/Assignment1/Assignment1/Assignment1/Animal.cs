using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    abstract class Animal
    {
        public int age { get; set; }
        public int weight { get; set; }

        public Animal(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }

        public abstract void Feed();

        public abstract void makeSound();

        protected void printAgeAndWeight()
        {
            Console.WriteLine("Age: " + age + " Weight: " + weight);
        }
    }
}
