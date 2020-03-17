using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public class Rectangle : Shape
    {
        //Properties
        private float XOrigin { get; set; }
        private float YOrigin { get; set; }
        private float Width { get; set; }
        private float Height { get; set; }

        //The 'Constructor'

        public Rectangle(float xOrigin, float yOrigin, float width, float height)
        {
            XOrigin = xOrigin;
            YOrigin = yOrigin;
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = XOrigin;
            Turtle.Y = YOrigin;

            for (int i = 0; i < 2; i++)
            {
                Turtle.Forward(Width);
                Turtle.Rotate(90);
                Turtle.Forward(Height);
                Turtle.Rotate(90);
            }
        }

        public void MoveTo(float x, float y)
        {
            XOrigin = x;
            YOrigin = y;
        }
    }

}
