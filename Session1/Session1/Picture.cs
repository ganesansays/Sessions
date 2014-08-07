using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Picture
    {
        public Picture(int iLenght, int iWidth, string iColor)
        {
            length = iLenght;
            width = iWidth;
            color = iColor;

            objShapeList = new List<Shape>();
        }

        private int length;
        private int width;
        private string color;

        private List<Shape> objShapeList;

        public void add(Shape objShape)
        {
            objShapeList.Add(objShape);
        }

        public void draw()
        {
            Console.WriteLine("This is a picture " + length + " " + width + " " + color);

            foreach (Shape objShape in objShapeList)
            {
                objShape.draw();
            }
        }
    }
}
