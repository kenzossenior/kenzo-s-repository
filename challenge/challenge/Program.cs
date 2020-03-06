using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int duplicateArray = 0;
            RandomNumbers(ref numbers);
            Duplicates(numbers, ref duplicateArray);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Duplicate found in  element {0}", duplicateArray +1);
            Console.ReadKey();
        }

        static void RandomNumbers(ref int[] numbers)
        {
            Random RNG = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = RNG.Next(numbers.Length);
            }
            
        }

        static void Duplicates(int[] numbers, ref int duplicateArray)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                for (int y = 0; y < numbers.Length; y++)
                {
                    if( i != y && duplicateArray == 0)
                    {
                        if (numbers[i] == numbers[y])
                        {
                             duplicateArray = y;
                        }
                    }
                }
            }
        }
    }
}
