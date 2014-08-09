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
        //Trying it for the second time
        static void Main(string[] args)
        {
            Zoo zooObj = new Zoo("Natural Wonders", "Vandalur", "GST, vandalur, Chennai");

            Animal objElephant = new Elephant(10, 100);

            zooObj.induct(objElephant);
            zooObj.induct(new Zebra(50, 400));
            zooObj.induct(new Cheetha(5, 100));

            zooObj.inductZooKeeper(new ZooKeeper("Mani"));
            zooObj.inductZooKeeper(new ZooKeeper("Raja"));
            zooObj.showAllAnimals();
            zooObj.listZooKeepers();
            zooObj.climbOrNot();
        }
    }
}
