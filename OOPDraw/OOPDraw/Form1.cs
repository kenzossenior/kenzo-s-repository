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
using System.Collections;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Shape> shapes = new List<Shape>();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            float turtleX = e.X - Width / 2 + 8;
            float turtleY = Height / 2 - e.Y - 19;
            string SelectedItem = (string)comboBox1.SelectedItem;
            if (SelectedItem == "Draw Triangle")
            {
                var tri = new EqualateralTriangle(turtleX, turtleY, 50);
                shapes.Add(tri);
                activeShapeNumber = shapes.Count - 1;
            }
            else if (SelectedItem == "Draw Rectangle")
            {
                var rec = new Rectangle(turtleX, turtleY, 100, 50);
                shapes.Add(rec);
                activeShapeNumber = shapes.Count - 1;
            }
            else if (SelectedItem == "Move Shape")
            {
                ActiveShape().MoveTo(turtleX, turtleY);
            }
            DrawAll();
        }

        public void DrawAll()
        {
            Turtle.Dispose(); //first clea all turtle tracks to start afresh
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int activeShapeNumber = 0;

        private Shape ActiveShape()
        {
            return shapes[activeShapeNumber]; //List elements can be accessed like an array
        }

        private void Next_Click(object sender, EventArgs e)
        {
            activeShapeNumber = activeShapeNumber + 1;
            if (activeShapeNumber >= shapes.Count) activeShapeNumber = 0;
        }
        private void Prev_Click(object sender, EventArgs e)
        {
            activeShapeNumber = activeShapeNumber - 1;
            if (activeShapeNumber < 0) activeShapeNumber = shapes.Count - 1;
        }
    }
}

