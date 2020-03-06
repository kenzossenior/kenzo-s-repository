using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] NumberArray = { 1, 3, 5, 7, 9, 21, 34, 36, 46, 66, 77, 78, 79, 90, 92, 455, 500 };
            int searchNo;
            int min = 0;
            int max = NumberArray.Length - 1;

            Console.Write("What number do you want to find: ");
            int.TryParse(Console.ReadLine(), out searchNo);
            if (BinarySearch(NumberArray, searchNo, min, max) == -1)
            {
                Console.WriteLine("Not found in array");
            }
            else
            {
                Console.WriteLine("Found in element {0}", BinarySearch(NumberArray, searchNo, min, max) + 1);
            }
            Console.ReadKey();
        }

        public static int BinarySearch(int[] NumberArray, int key, int min, int max)
        {
            int mid = (min + max) / 2;
            if (min > max) return -1;
            else
            {
                 if (key > NumberArray[mid])
                {
                    min = mid;
                    return BinarySearch(NumberArray, key, mid + 1, max);
                }
                else if (key < NumberArray[mid])
                {
                    return BinarySearch(NumberArray, key, min, mid - 1);
                }
            }
            return mid;
        }

    }
}

