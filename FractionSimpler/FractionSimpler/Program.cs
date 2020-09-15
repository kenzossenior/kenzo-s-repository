using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionSimpler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numerator of fraction");
            int.TryParse(Console.ReadLine(), out int top);
            Console.WriteLine("Enter denominator of fraction");
            int.TryParse(Console.ReadLine(), out int Bottom);
            //TEST
            bool check = false;
            int hcf = 1;
            int biggestNum;

            if(top < Bottom)
            {
                biggestNum = top;
            }
            else { biggestNum = Bottom;}

            for (int i = biggestNum; i > 0; i--)
            {
                if (check == false && Bottom % i == 0 && top % i == 0)
                {
                     hcf = i;
                    check = true;
                }
            }
            Console.WriteLine($"{(top / hcf)}/{ Bottom / hcf}");
            Console.ReadKey();

        }
    }
}
