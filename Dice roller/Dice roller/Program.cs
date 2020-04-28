using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaker myShaker = new Shaker();
            myShaker.RollDice();
            Console.WriteLine(myShaker.Die1.Face);
            Console.WriteLine(myShaker.Die2.Face);

            if(myShaker.isADouble())
            {
                Console.WriteLine(myShaker.Die3.Face);
            }
            Console.WriteLine("Total = {0}", myShaker.Total.ToString()); 

            Console.ReadKey();
        }
    }
}
