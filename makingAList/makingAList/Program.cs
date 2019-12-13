using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingAList
{
    class Program
    {
        static void Main(string[] args)
        {
            myList names = new myList();

            names.AddItem("ALice");
            names.AddItem("Bob");
            names.AddItem("Charlie");

            Console.WriteLine()
            Console.ReadKey();
        }
    }
}
