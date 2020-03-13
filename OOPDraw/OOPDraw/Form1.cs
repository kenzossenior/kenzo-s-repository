using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            float turtleX = e.X - Width / 2 + 8;
            float turtleY = Height / 2 - e.Y - 19;
            string SelectedItem = (string)comboBox1.SelectedItem;
            if (SelectedItem == "Draw Triangle")
            {
                var tri = new EqualateralTriangle(turtleX, turtleY, 50);
                DrawTriangle(tri);
            }
            else if (SelectedItem == "Draw Rectangle")
            {
                var rec = new Rectangle(turtleX, turtleY, 100, 50);
                DrawRectangle(rec);
            }
        }
        private static void DrawTriangle(EqualateralTriangle tri)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = tri.XOrigin;
            Turtle.Y = tri.YOrigin;
            Turtle.Rotate(30);

            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(tri.SideLength);
                Turtle.Rotate(120);
            }
        }

        private static void DrawRectangle(Rectangle rec)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = rec.XOrigin;
            Turtle.Y = rec.YOrigin;
            Turtle.Rotate(0);

            for (int i = 0; i < 2; i++)
            {
                Turtle.Forward(rec.Width);
                Turtle.Rotate(90);
                Turtle.Forward(rec.Height);
                Turtle.Rotate(90);
            }
        }
    }
}

