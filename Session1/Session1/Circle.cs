using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Circle : Shape
    {
        private int radius;
        private string color;

        public Circle(int iRadius, string iColor)
        {
            radius = iRadius;
            color = iColor;
        }

        public override void draw()
        {
            Console.WriteLine("This is a circle " + radius + " " + color);
        }

    }
}
