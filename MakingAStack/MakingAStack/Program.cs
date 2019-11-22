
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] theStack = new string[5];
            int NFS = 0;
            string input = ""; 

            Push(ref theStack, ref NFS);

            while (input != "end")
            {
                Console.WriteLine("Would you like to pop, push, display or end?");
                input = Console.ReadLine();
                if (input == "pop")
                {
                    Pop(theStack, ref NFS);
                    Console.Clear();
                }
                else if (input == "push")
                {
                    Push(ref theStack, ref NFS);
                    Console.Clear();
                }
                else if (input == "display")
                {
                    Display(theStack);
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }

        static void Push(ref string[] theStack, ref int NFS)
        {
            Console.Clear();
            Console.WriteLine("What would you like to push?");
            theStack[NFS] = Console.ReadLine();
            NFS++;

        }

        static void Pop(string[] theStack, ref int NFS)
        {
            Console.Clear();
            NFS = NFS - 1;
            theStack[NFS] = " ";
        }

        static void Display(string[] theStack)
        {
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("{0}) {1}" , i + 1 ,theStack[i]);
            }
            Console.ReadKey();
        }
    }
}
    




