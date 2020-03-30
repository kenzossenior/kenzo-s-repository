using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public abstract class Shape
    {
        //properties
        protected float XOrigin { get; set; }
        protected float YOrigin { get; set; }
        //Abstract mthods
        public Shape(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }

        public abstract void Draw();

        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }
    }
}
