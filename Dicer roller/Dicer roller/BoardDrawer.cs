using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dicer_roller
{
    class BoardDrawer
    {
        private Image felt = Properties.Resources.felt;

        private Image[] dotImages =
        {
            Properties.Resources.die1,
            Properties.Resources.die2,
            Properties.Resources.die3,
            Properties.Resources.die4,
            Properties.Resources.die5,
            Properties.Resources.die6,
        };

        private Bitmap board;

        public BoardDrawer()
        {
            board = new Bitmap(400, 400);
        }

        public Bitmap DrawBoard()
        {

            using (Graphics g = Graphics.FromImage(board))
            {

                g.DrawImage(felt, 0, 0, board.Width, board.Height);

            }

            return board;
        }

        public Bitmap DrawBoard(int die1, int die2)
        {

            int dieWidth = board.Width / 4;
            int dieHeight = board.Height / 4;

            int[] diceValues = { die1, die2 };
            using (Graphics g = Graphics.FromImage(board))
            {

                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < diceValues.Length; i++)
                {
                    g.DrawImage(dotImages[diceValues[i]- 1], dieWidth * i, dieHeight * i, dieWidth, dieHeight);
                }
            }

            return board;
        }

        public Bitmap DrawBoard(int die1, int die2, int die3)
        {

            int dieWidth = board.Width / 4;
            int dieHeight = board.Height / 4;

            int[] diceValues = { die1, die2, die3 };
            using (Graphics g = Graphics.FromImage(board))
            {

                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < diceValues.Length; i++)
                {
                    g.DrawImage(dotImages[diceValues[i] - 1], dieWidth * i, dieHeight * i, dieWidth, dieHeight);
                }
            }

            return board;
        }

    }
}
