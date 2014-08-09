using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentClasses;

namespace Assignment1
{
    class mainProgram
    {
        //This is in Version Control
        static void Main(string[] args)
        {
            Zoo zooObj = new Zoo("Natural Wonders", "Vandalur", "GST, vandalur, Chennai");
            zooObj.induct(new Cheetha(10, 100));
            zooObj.induct(new Elephant(50, 400));
            zooObj.induct(new Zebra(5, 100));
            zooObj.inductZooKeeper(new ZooKeeper("Mani"));
            zooObj.inductZooKeeper(new ZooKeeper("Raja"));

            zooObj.showAllAnimals();
            zooObj.listZooKeepers();

            /*
             * Cheetha cheethaObj = new Cheetha(7, 800);
            Elephant elephantObj = new Elephant(7, 800);
            elephantObj.Feed();
             */
        }
    }
}
