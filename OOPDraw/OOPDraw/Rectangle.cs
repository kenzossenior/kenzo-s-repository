using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Rectangle
    {
        //Properties
        public float Xorigin { get; private set; }
        public float Yorigin { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }

        //The 'Constructor'
        public Rectangle(float xorigin, float yorigin, float width, float height)
        {
            Xorigin = xorigin;
            Yorigin = yorigin;
            Width = width;
            Height = height;
        }
    }
}
