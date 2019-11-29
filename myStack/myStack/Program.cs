using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myQueue = new string[5];
            int NFS = 0;
            int FQ = 0;
            int choice = 0;

            while (choice != 4)
            {
                choice = menu();
                switch (choice)
                {
                    case 1:
                        AddToQueue(ref myQueue, ref NFS);
                        break;

                    case 2:
                        RemoveFromQueue(ref myQueue, ref FQ, ref NFS);
                        break;
                    case 3:
                        DisplayQueue(myQueue);
                        break;
                }
            }
            Console.ReadKey();
        }

        static void AddToQueue(ref string[] myQueue, ref int NFS)
        {
            Console.WriteLine("Enter what you want to add to the queue");
            myQueue[NFS] = Console.ReadLine();
            NFS++;
        }

        static void RemoveFromQueue(ref string[] myQueue, ref int FQ, ref int NFS)
        {
            myQueue[FQ] = "";
            FQ++;
            if (FQ == NFS)
            {
                FQ = 0;
                NFS = 0;
            }
        }

        static void DisplayQueue(string[] myQueue)
        {
            for(int i = 0; i < 5; i ++)
            {
                Console.WriteLine("{0}: {1} ", i + 1, myQueue[i]);
            }
        }

        static int menu()
        {
            Console.WriteLine("Would you like to:");
            Console.WriteLine("1) Add to the queue");
            Console.WriteLine("2) Remove from queue");
            Console.WriteLine("3) Display queue");
            Console.WriteLine("4) End program");
            int.TryParse(Console.ReadLine(), out int input);
            return input;

        }
    }
}
