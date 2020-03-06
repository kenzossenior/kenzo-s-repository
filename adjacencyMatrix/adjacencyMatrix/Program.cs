using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adjacencyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 6];
            string[] Towns = { "Lancaster", "Blackpool", "Southport", "Liverpool", "Manchester", "Preston" };
            int t1 = 0;
            int t2 = 0;


            matrix[0, 1] = 33;
            matrix[0, 5] = 22;

            matrix[1, 0] = 33;
            matrix[1, 5] = 17;

            matrix[2, 3] = 20;
            matrix[2, 5] = 20;

            matrix[3, 2] = 20;
            matrix[3, 4] = 35;
            matrix[3, 5] = 37;

            matrix[4, 3] = 35;
            matrix[4, 5] = 33;

            matrix[5, 0] = 22;
            matrix[5, 1] = 17;
            matrix[5, 2] = 20;
            matrix[5, 3] = 37;
            matrix[5, 4] = 33;

            Console.WriteLine("Enter the 2 towns you want to know the distance between");
            Console.Write("Town 1:");
            string town1 = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (Towns[i] == town1)
                {
                     t1 = i;
                }
            }

            Console.Write("Town 2:");
            string town2 = Console.ReadLine();
            

            for (int i = 0; i < 5; i++)
            {
                if (Towns[i] == town2)
                {
                     t2 = i;
                }
            }

            if (matrix[t1,t2] != 0)
            {
                Console.WriteLine("Distance between {0} and {1} is {2} miles" , town1, town2, matrix[t1,t2]);
            }
            else
            {
                Console.WriteLine("No roads directly link");
            }
            Console.ReadKey();
        }
    }
}
