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
        BoardDrawer board = new BoardDrawer();

        private void Form1_Load(object sender, EventArgs e)
        {
            pbx_board.Image = board.DrawBoard();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            myShaker.RollDice();
            if(myShaker.isADouble())
            {
                pbx_board.Image = board.DrawBoard(myShaker.Die1.Face, myShaker.Die2.Face, myShaker.Die3.Face);
            }
            else
            {
                pbx_board.Image = board.DrawBoard(myShaker.Die1.Face, myShaker.Die2.Face);
            }
        }
    }
}
