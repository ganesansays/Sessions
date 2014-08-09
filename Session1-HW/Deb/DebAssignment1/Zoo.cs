using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarveshApp
{
    class Zoo
    {
        private string v_name;
        private string v_area;
        private string v_address;
        private string v_zooKeeper;
        private List<Animal> o_AnimalList;

        public Zoo(string i_name, string i_area, string i_address, string i_zooKeeper)
        {
            v_name = i_name;
            v_area = i_area;
            v_address = i_address;
            v_zooKeeper = i_zooKeeper;
            o_AnimalList = new List<Animal>();
        }
        public void induct()
        {
            Cheetah o_Cheetah01 = new Cheetah(01, 70);
            Cheetah o_Cheetah02 = new Cheetah(02, 75);
            Cheetah o_Cheetah03 = new Cheetah(03, 80);
            o_AnimalList.Add(o_Cheetah01);
            o_AnimalList.Add(o_Cheetah02);
            o_AnimalList.Add(o_Cheetah03);

            /*Elephant o_Elephant01 = new Elephant(01, 100);
            Elephant o_Elephant02 = new Elephant(02, 110);
            Elephant o_Elephant03 = new Elephant(03, 115);
            o_AnimalList.Add(o_Elephant01);
            o_AnimalList.Add(o_Elephant02);
            o_AnimalList.Add(o_Elephant03);*/

            Zebra o_Zebra01 = new Zebra(01, 90);
            Zebra o_Zebra02 = new Zebra(02, 95);
            Zebra o_Zebra03 = new Zebra(03, 115);
            o_AnimalList.Add(o_Zebra01);
            o_AnimalList.Add(o_Zebra02);
            o_AnimalList.Add(o_Zebra03);
        }

        public void feedThemAll()
        {
            foreach (Animal animal in o_AnimalList)
            {
                animal.feed();
            }
        }
        public static void Main(string[] args) 
        {
            Zoo o_Zoo = new Zoo("Mahindra City", "Mahindra World City,Chengalpet", "Chengalpet", "Mahindra & Mahindra");
            o_Zoo.induct();
            o_Zoo.feedThemAll();
        }
    }
}
