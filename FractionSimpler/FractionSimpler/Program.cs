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

            bool check = false;
            int hcf = 1;

            for (int i = top; i > 0; i--)
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
