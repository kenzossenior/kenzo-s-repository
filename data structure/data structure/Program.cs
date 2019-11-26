using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            pupilInformation[] studentData = new pupilInformation[20];
            int num = 0;
            int choice = 0;

            while (choice != 5)
            {
                choice = Menu();
                if (choice == 1)
                {
                    GetPupilInfo(studentData, out num);
                }
                else if (choice == 2)
                {
                    loadData(num, studentData);
                }
                else if (choice == 3)
                {
                    writeData(num, studentData);
                }
                else if (choice == 4)
                {
                    DisplayPupilInfo(studentData, num);
                }
            }
            Console.ReadKey();
        }



        public struct pupilInformation
        {
            public string firstName;
            public string surname;
            public string school;
            public int testScore;
            public char currentGrade;
        }

        static void GetPupilInfo(pupilInformation[] studentData, out int num)
        {

            Console.WriteLine("Enter students in class:");
            int.TryParse(Console.ReadLine(), out num);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter firstname of student {0}:", i + 1);
                studentData[i].firstName = Console.ReadLine();
                Console.WriteLine("Enter surname of student {0}:", i + 1);
                studentData[i].surname = Console.ReadLine();
                Console.WriteLine("Enter school of student {0}:", i + 1);
                studentData[i].school = Console.ReadLine();
                Console.WriteLine("Enter testscore of student {0}:", i + 1);
                studentData[i].testScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter current grade of student {0} (A - U):", i + 1);
                studentData[i].currentGrade = char.Parse(Console.ReadLine());
            }
        }

        static void DisplayPupilInfo(pupilInformation[] studentData, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Student: {0}", i + 1);
                Console.WriteLine("Name: {0} {1}", studentData[i].firstName, studentData[i].surname);
                Console.WriteLine("School: {0}", studentData[i].school);
                Console.WriteLine("Testscore: {0}", studentData[i].testScore);
                Console.WriteLine("Current grade: {0}", studentData[i].currentGrade);

            }
        }

        static void loadData(int num, pupilInformation[] studentData)
        {
            using (StreamWriter CurrentFile = new StreamWriter("studentData.bin"))
            {
                for (int i = 0; i < num; i++)
                {
                    CurrentFile.WriteLine("{0}", studentData[i].firstName);
                    CurrentFile.WriteLine("{0}", studentData[i].surname);
                    CurrentFile.WriteLine("{0}", studentData[i].school);
                    CurrentFile.WriteLine("{0}", studentData[i].testScore);
                    CurrentFile.WriteLine("{0}", studentData[i].currentGrade);
                }
            }
            Console.WriteLine("loaded into program");
        }

        static void writeData(int num, pupilInformation[] studentData)
        {
            using (StreamReader CurrentFile = new StreamReader("studentData.bin"))
            {
                for (int i = 0; i < num; i++)
                {
                    studentData[i].firstName = CurrentFile.ReadLine();
                    studentData[i].surname = CurrentFile.ReadLine();
                    studentData[i].school = CurrentFile.ReadLine();
                    studentData[i].testScore = int.Parse(CurrentFile.ReadLine());
                    studentData[i].currentGrade = char.Parse(CurrentFile.ReadLine());
                }
                Console.WriteLine("Written to file");
            }
        }

        public static int Menu()
        {
            int input;
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Enter pupil details");
            Console.WriteLine("2) Load from file to program");
            Console.WriteLine("3) write to file");
            Console.WriteLine("4) Display information");
            Console.WriteLine("5) exit program");
            int.TryParse(Console.ReadLine(), out input);

            return input;

        }
    }
}

    

