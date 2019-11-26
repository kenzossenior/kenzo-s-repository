using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            pupilInformation[] studentData = new pupilInformation[20];
            int num;
            GetPupilInfo(studentData, out num);
            DisplayPupilInfo(studentData, num);
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
            for (int i = 0; i < num; i ++)
            {
                Console.WriteLine("Enter firstname of student {0}:", i + 1);
                studentData[i].firstName = Console.ReadLine();
                Console.WriteLine("Enter surname of student {0}:", i + 1);
                studentData[i].surname = Console.ReadLine();
                Console.WriteLine("Enter school of student {0}:", i + 1);
                studentData[i].school = Console.ReadLine();
                Console.WriteLine("Enter testscore of student {0}:", i + 1);
                studentData[i].testScore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter current grade of student {0}:", i + 1);
                studentData[i].currentGrade = char.Parse(Console.ReadLine());
            }
        }

        static void DisplayPupilInfo(pupilInformation[] studentData, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Student: {0}", i + 1);
                Console.WriteLine("Name: {0} {1}", studentData[i].firstName, studentData[i].surname);
                Console.WriteLine("Testscore: {0}", studentData[i].school);
                Console.WriteLine("Testscore: {0}", studentData[i].testScore);
                Console.WriteLine("Current grade: {0}", studentData[i].currentGrade);

            }
        }
    }

}

