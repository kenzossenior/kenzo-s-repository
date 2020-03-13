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
                DrawTriangle(turtleX, turtleY, 50);
            }
            else if (SelectedItem == "Draw Rectangle")
            {
                DrawRectangle(turtleX, turtleY, 50, 100);
            }
        }
        private static void DrawTriangle(float xOrigin, float yOrigin, float sideLength)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = xOrigin;
            Turtle.Y = yOrigin;
            Turtle.Rotate(30);

            for (int i = 0; i < 3; i++)
            {
                Turtle.Forward(sideLength);
                Turtle.Rotate(120);
            }
        }

        private static void DrawRectangle(float xOrigin, float yOrigin, float height, float width)
        {
            Turtle.ShowTurtle = false;
            Turtle.PenSize = 2;
            Turtle.Angle = 0;
            Turtle.X = xOrigin;
            Turtle.Y = yOrigin;
            Turtle.Rotate(0);

            for (int i = 0; i < 2; i++)
            {
                Turtle.Forward(width);
                Turtle.Rotate(90);
                Turtle.Forward(height);
                Turtle.Rotate(90);
            }
        }
    }
}

