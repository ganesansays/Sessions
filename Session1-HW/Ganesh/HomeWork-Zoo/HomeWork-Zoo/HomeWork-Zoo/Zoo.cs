using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Zoo
{
    class Zoo
    {
        public Zoo(string name, string area, string address, Zookeeper zookeeper, List<Animal> zooanimallist)
        {
            this.name = name;
            this.area = area;
            this.address = address;

            objzookeeper = zookeeper;

            ObjAnimalList = zooanimallist;
        }
        private string name;
        private string area;
        private string address;

        private Zookeeper objzookeeper;

        private List<Animal> ObjAnimalList;

        public void AddAnimal(Animal ObjAnimal)
        {
            ObjAnimalList.Add(ObjAnimal);
        }

        public void induct()
        {
            Console.WriteLine("This is Zoo!!!");
            Console.WriteLine("This is Zookeeper's name: " + objzookeeper.name);
            foreach (Animal ObjAnimal in ObjAnimalList)
            {
                ObjAnimal.feed();
            }
        }
    }
}
