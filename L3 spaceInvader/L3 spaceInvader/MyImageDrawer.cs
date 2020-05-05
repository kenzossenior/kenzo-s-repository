using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace L3_spaceInvader
{
    class MyImageDrawer
    {

        private Image space = Properties.Resources.space;
        private Image invader1 = Properties.Resources.invader1;
        private Image invader2 = Properties.Resources.invader2;

        static private int position = 1;

        private Bitmap finalPic;


        public MyImageDrawer()
        {
            this.finalPic = new Bitmap(400, 400);
        }

        public MyImageDrawer (int width, int height)
        {
            this.finalPic = new Bitmap(width, height);
        }

        public Bitmap DrawPic()
        {
            using (Graphics g = Graphics.FromImage(finalPic))
            {
                g.DrawImage(space, 0, 0, finalPic.Width, finalPic.Height);
            }

            return finalPic;
        }

        public Bitmap DrawPic(bool show)
        {

            using (Graphics g = Graphics.FromImage(finalPic))
            {
                g.DrawImage(space, 0, 0, finalPic.Width, finalPic.Height);
                if (show )
                {
                    g.DrawImage(invader1, 50, 50, 50, 50);
                }
            }

            return finalPic;
        }

        public Bitmap nextPic()
        {
            using (Graphics g = Graphics.FromImage(finalPic))
            {
                g.DrawImage(space, 0, 0, finalPic.Width, finalPic.Height);
                if (position == 1)
                {
                    position = 2;
                    g.DrawImage(invader1, 50, 50, 50, 50);
                }
                else
                {
                    position = 1;
                    g.DrawImage(invader2, 50, 50, 50, 50);
                }
            }

            return finalPic;
        }
    }
}
