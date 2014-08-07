using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Triangle : Shape
    {
        public Triangle(int height, int baseDim, string color)
        {
            this.height = height;
            this.baseDim = baseDim;
            this.color = color;
        }

        private int height;
        private int baseDim;
        private string color;

        public override void draw()
        {
            Console.WriteLine("This is a trianble " + height + " " + baseDim + " " + color);
        }

    }
}
