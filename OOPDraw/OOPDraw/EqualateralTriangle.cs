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
        private float SideLength { get; set; }


        //The 'Constructor'
        public EqualateralTriangle(float xOrigin, float yOrigin, float sideLength)
            : base(xOrigin, yOrigin)
        {
            SideLength = sideLength;
        }

        public override void Draw()
        {
            ResetTurtle();
            Turtle.Rotate(30);
            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(SideLength);
                Turtle.Rotate(120);
            }
        }
    }
}
