using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            Picture objPic = new Picture(10, 10, "white");

            //2 circle
            Shape objShape1 = new Circle(1, "black");
            objPic.add(objShape1);

            Shape objShape2 = new Circle(2, "brown");
            objPic.add(objShape2);

            //2 rectangle
            Shape objShape3 = new Rectangle(1, 2, "black");
            objPic.add(objShape3);

            Shape objShape4 = new Rectangle(3, 5, "brown");
            objPic.add(objShape4);

            //2 Triangle
            Shape objShape5 = new Triangle(10, 5, "black");
            objPic.add(objShape5);

            Shape objShape6 = new Triangle(5, 2, "white");
            objPic.add(objShape6);

            //2 square
            Shape objShape7 = new Square(10, "red");
            objPic.add(objShape7);

            Shape objShape8 = new Square(20, "blue");
            objPic.add(objShape8);

            //draw
            objPic.draw();
        }
    }
}
