using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTables
{
    class Program
    {
        public struct Data
        {
            public string key;
            public int index;
            public string firstName;
            public string lastName;
        }

        static void Main(string[] args)
        {
            Data[] hashTable = new Data[100];
            int choice = Menu();
            switch(choice)
            {
                case (1):
                    AddRecord(ref hashTable);
                break;
                case (2):

                break;
                case (3):

                break;
                case (4):

                break;

            }

        }

        static int HashFunction(ref string key)
        {
            int index = (key[2] * 1 + key[1] * 2 + key[2] * 3 + key[3] * 4) % 50;
            return index;
        }

        static int Menu()
        {
            int inp;
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Add record");
            Console.WriteLine("2) retrieve record");
            Console.WriteLine("3) Display all records");
            Console.WriteLine("4) End program");
            int.TryParse(Console.ReadLine(), out inp);
            return inp;
        }

        static void AddRecord(ref Data[] hashTable)
        {
            Console.WriteLine("Enter students key");
            string key = (Console.ReadLine());
            int index = HashFunction(ref key);
            key = hashTable[index].key;

            Console.WriteLine("First name of Student:");
            hashTable[index].firstName = Console.ReadLine();
            Console.WriteLine("Last name of Student:");
            hashTable[index].lastName = Console.ReadLine();

        }
    }
}
