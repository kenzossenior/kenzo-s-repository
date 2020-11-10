using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elephants = new int[5];

            int temp;

            Random RandomNumberGenerator = new Random();


            //Setting up program.

            Console.Write("Random Array: ");

            for (int i = 0; i < elephants.Length; i++)

            {

                elephants[i] = RandomNumberGenerator.Next(99);

                Console.Write($"{elephants[i]} ");

            }


            Console.WriteLine();


            //Sorting the array.
            int count = 0;
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < elephants.Length - 1; i++)

                {

                    for (int j = 0; j < elephants.Length - 1 - i; j++)
                    {

                        if (elephants[j] > elephants[j + 1])
                        {

                            temp = elephants[j];

                            elephants[j] = elephants[j + 1];

                            elephants[j + 1] = temp;
                            swap = true;
                        }
                    }

                    //Output intermediate sorting steps.

                    Console.WriteLine();

                    Console.Write($"Array v{i}: ");

                    for (int x = 0; x < elephants.Length; x++)
                    {

                        Console.Write($"{elephants[x]} ");

                    }
                    count++;
                }
            }
            while (swap == true ); //|| count != elephants.Length - 1


            Console.WriteLine();

            Console.WriteLine();


            //Output final version of array.

            Console.Write("Final Sorted Array: ");

            for (int i = 0; i < elephants.Length; i++)

            {

                Console.Write($"{elephants[i]} ");

            }


            Console.ReadKey();
        }
    }
}
