using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char temp;
            int calculatedDigit = 0;

            Console.WriteLine("Please enter the next digit of ISBN:");
            string ISBN = Console.ReadLine();

            while (count < 12)
            {
                temp = ISBN[count];

                calculatedDigit = calculatedDigit + int.Parse(ISBN[count].ToString());
                count++;
                calculatedDigit = calculatedDigit + int.Parse(ISBN[count].ToString()) * 3;
            }

            calculatedDigit = calculatedDigit % 10;
            calculatedDigit = 10 - calculatedDigit;

            if( calculatedDigit == ISBN[12])
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();
        }
    }
}
