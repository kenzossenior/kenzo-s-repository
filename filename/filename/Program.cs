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
            string filename = @"lines.txt";

            using (StreamWriter CurrentFile = new StreamWriter(filename))
            {
                for (int i = 0; i == 9; i++)
                {
                    CurrentFile.WriteLine(i);
                }
            }
        }
    }
}
