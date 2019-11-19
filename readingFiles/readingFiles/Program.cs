using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Countries = new string[20];
            string fileName = @"countries.txt";

            Console.WriteLine("Listing Countries");
            Console.WriteLine("+++++++++++++++\n");
            readCountries(Countries, fileName);
            displayCountries(Countries);
            Console.ReadKey();
        }

        static void readCountries(string[] Countries, string fileName)
        {
            try
            {
                using (StreamReader CurrentFile = new StreamReader(fileName))
                {
                    for (int i = 0; i < Countries.Length; i++)
                    {
                        Countries[i] = CurrentFile.ReadLine();
                    }
                }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("Uh Oh, {0} ", ex.Message);
            }
        }

        static void displayCountries(string[] Countries)
        {
            for (int i = 0; i < Countries.Length; i++)
            {
                Console.WriteLine(Countries[i]);
            }
        }
    }

}

