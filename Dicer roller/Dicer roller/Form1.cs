using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicer_roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shaker myShaker = new Shaker();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myShaker.RollDice();
            Die1.Text = myShaker.Die1.Face.ToString();
            Die2.Text = myShaker.Die2.Face.ToString();
            if (myShaker.isADouble())
            {
                Die3.Text = myShaker.Die3.Face.ToString();
            }
            diceCount.Text = myShaker.Total.ToString();
        }
    }
}
