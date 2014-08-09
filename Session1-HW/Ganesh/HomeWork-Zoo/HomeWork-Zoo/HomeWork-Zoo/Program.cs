using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zookeeper myzookeeper = new Zookeeper("Zooky");

             List<Animal> myAnimalList = new List<Animal>();

            Zoo MyZoo = new Zoo("Vandalur", "Mysore", "NH45, Chennai", myzookeeper, myAnimalList);

            Animal myAnimal1 = new Zebra(5, 80);

            MyZoo.AddAnimal(myAnimal1);

            Animal myAnimal2 = new Elephant(4, 140);

            MyZoo.AddAnimal(myAnimal2);

            Animal myAnimal3 = new Cheetha(6, 70);

            MyZoo.AddAnimal(myAnimal3);

            MyZoo.induct();

        }

    }
}
