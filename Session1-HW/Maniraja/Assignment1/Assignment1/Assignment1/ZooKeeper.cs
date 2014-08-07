using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClasses
{
    class ZooKeeper
    {
        String name;
        public ZooKeeper(String name)
        {
            this.name = name;
        }
        public void showZooKeeper()
        {
            Console.WriteLine("Zookeeper Name..." + name);
        }
    }
}
