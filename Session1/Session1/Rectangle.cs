using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Rectangle : Shape
    {
        public Rectangle(int iLenght, int iWidth, string iColor)
        {
            length = iLenght;
            width = iWidth;
            color = iColor;
        }

        private int length;
        private int width;
        private string color;

        public override void draw()
        {
            Console.WriteLine("This is a rectangle " + length + " " + width + " " + color);
        }
    }
}
