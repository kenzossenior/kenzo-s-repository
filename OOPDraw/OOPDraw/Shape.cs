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
        private float LineWidth { get; set; }
        //the constructor
        public Shape(float xOrigin, float yOrigin)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
        }
        //Abstract mthods
        public abstract void Draw();

        //concrete methods
        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }

        public void Select()
        {
            LineWidth = 4;
        }

        public void Unselect()
        {
            LineWidth = 2;
        }

        protected void ResetTurtle()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = LineWidth;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;
        }
    }
}
