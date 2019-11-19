using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace writingToAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"names.txt";
            string[] names = new string[16];

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("ENter a name");
                names[i] = Console.ReadLine();
            }

            using (StreamWriter CurrentFile = new StreamWriter(filename))
            {
                for (int i = 0; i <= 15; i++)
                {
                    CurrentFile.WriteLine(names[i]);
                }
            }
        }
    }
}
