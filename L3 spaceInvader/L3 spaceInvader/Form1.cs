using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L3_spaceInvader
{
    public partial class Form1 : Form
    {

       private bool showAlien = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            pbx_Spacee.Image = new MyImageDrawer().DrawPic(false);
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            if (showAlien)
            {
                showAlien = false;  
            }
            else
            {
                showAlien = true;
            }
            pbx_Spacee.Image = new MyImageDrawer().DrawPic(showAlien);
            timer1.Enabled = showAlien;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pbx_Spacee.Image = new MyImageDrawer().nextPic();
        }
    }
}
