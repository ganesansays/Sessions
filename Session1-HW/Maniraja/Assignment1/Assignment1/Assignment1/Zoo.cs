using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class Zoo
    {
        String name;
        String area;
        String address;
        List <Animal> animalList;
        List <ZooKeeper> zooKeeperList;
        
        public Zoo(String name, String area, String address)
        {
            this.name = name;
            this.area = area;
            this.address = address;
            animalList = new List <Animal> ();
            zooKeeperList = new List <ZooKeeper> ();
        }
        public void induct(Animal zooObject)
        {
            animalList.Add(zooObject);
            
        }
        public void inductZooKeeper(ZooKeeper zooKeeperObject)
        {
            zooKeeperList.Add(zooKeeperObject);
        }
        public void showAllAnimals()
        {
            Console.WriteLine("Zoo: " + name + ".." + area + ".." + address);
            foreach(Animal tempAnimalObject in animalList)
            {
                tempAnimalObject.Feed();
            }
        }
        public void listZooKeepers()
        {
            foreach (ZooKeeper tempZooKeeper in zooKeeperList)
            {
                tempZooKeeper.showZooKeeper();
            }
        }
    }
}
