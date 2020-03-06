using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out int num);


            int answer = FactorialN(num);


            Console.WriteLine("the factorial of {0} is {1}", num, answer);
            Console.ReadKey();
        }

        static int FactorialN(int num)
        {
            int answer;

            if (num == 1)
            {
                answer = 1;
            }
            else
            {
                answer = num * FactorialN(num - 1);
            }
            return answer;
        }
    }
}
