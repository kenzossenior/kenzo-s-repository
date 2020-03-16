using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nakov.TurtleGraphics;

namespace OOPDraw
{
    class EqualateralTriangle : Shape
    {
        //Properties
        private float XOrigin { get;  set; }
        private float YOrigin { get;  set; }
        private float SideLength { get;  set; }


        //The 'Constructor'
        public EqualateralTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            SideLength = sideLength;
        }

        public void Draw()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
            Turtle.Rotate(30);

            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(SideLength);
                Turtle.Rotate(120);
            }
        }
        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }
    }
}
