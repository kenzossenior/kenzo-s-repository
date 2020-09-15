using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_roller
{
    class Shaker
    {
        public int Total { get {

                int temptTotal = Die1.Face + Die2.Face;
                if(isADouble())
                {
                    temptTotal = temptTotal + Die3.Face;
                }
                return temptTotal;
             } }

        Die[] Dice = new Die[2];
       public readonly Die Die1 = new Die();
       public readonly Die Die2 = new Die();
       public readonly Die Die3 = new Die();


        public void RollDice()
        {
            Die1.Roll();
            Die2.Roll();
            Die3.Roll();
        }

        public bool isADouble()
        {
            return Die1.Face == Die2.Face;
        }
       
    }

    class Die
    {
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public int Face { get; private set; }
        private byte sides = 6;

        public Die()
        {
            Roll();
        }

        public Die(byte sides)
        {
            if (sides > 1)
            {
                this.sides = sides;
                Roll();
            }
            else
            {
                throw new ArgumentOutOfRangeException("sides");
            }
        }

        public void Roll()
        {
            this.Face = rnd.Next(1, sides + 1);
        }
    }
}
