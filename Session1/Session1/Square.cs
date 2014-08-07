using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Square : Shape
    {
        public Square(int side, string color)
        {
            this.side = side;
            this.color = color;
        }

        private int side;
        private string color;

        public override void draw()
        {
            Console.WriteLine("This is a square " + side + " " + color);
        }
    }
}
