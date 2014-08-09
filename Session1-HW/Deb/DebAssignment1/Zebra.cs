using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarveshApp
{
    class Zebra : Animal
    {
        private int v_age;
        private int v_weight;

        public Zebra(int i_age, int i_weight)
        {
            v_age = i_age;
            v_weight = i_weight;
        }

        public override void feed()
        {
            Console.WriteLine("Feeding Zebra : Age-{0},Weight-{1}", v_age, v_weight);
        }


    }
}
