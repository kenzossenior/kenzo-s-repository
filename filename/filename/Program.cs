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
            string[] teams = new string[16];

            Console.WriteLine("Would you like to read or write the file?");
            string readOrWrite = Console.ReadLine();
            if (readOrWrite == "write")
            {
                getNames(teams);
                writeTeams(teams, filename);
            }
            if (readOrWrite == "read")
            {
                readNames(filename, teams);
            }
            Console.ReadKey();
        }

        static void getNames(string[] teams)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine("Enter Team Name {0}" , i + 1 );
                teams[i] = Console.ReadLine();
            }
        }

        static void writeTeams(string[] teams, string filename)
        {
            using (StreamWriter CurrentFile = new StreamWriter(filename))
            {
                for (int i = 0; i < teams.Length; i++)
                {
                    CurrentFile.WriteLine("Team {i}:" , teams[i]);
                }
            }
        }
        static void readNames(string filename, string[] teams)
        {
            using (StreamReader CurrentFile = new StreamReader(filename))
            {
                for (int i = 0; i < teams.Length; i++)
                {
                    Console.WriteLine(CurrentFile.ReadLine());
                }
            }
        }
    }
}
