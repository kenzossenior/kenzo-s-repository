using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> someNumbers = new HashSet<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(someNumbers.Count);
            Console.WriteLine("Adding the number 12");
            someNumbers.Add(12);
            Console.WriteLine(someNumbers.Count);
            Console.WriteLine("aad now adding the numbers 4 and 5");
            someNumbers.Add(5);
            someNumbers.Add(4);
            Console.WriteLine(someNumbers.Count);
            Console.WriteLine("Adding the number 7");
            someNumbers.Add(7);
            Console.WriteLine(someNumbers.Count);

            foreach (int val in someNumbers)
            {
                Console.WriteLine(val);
            }
            Console.ReadKey();
        }
    }
}
