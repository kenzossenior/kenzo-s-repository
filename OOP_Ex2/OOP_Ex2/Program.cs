using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass Auto1 = new CarClass("Ford ", "Escort", 250000, "silver", 25);
            Auto1.ChangeMileage();
            CarClass Auto2 = new CarClass("Hyundai ", "i20", 32000, "black", 25);
            CarClass Auto3 = new CarClass("Ford ", "Escort", 100000, "white", 25);
            Auto1.DisplayDetails();
            Auto2.DisplayDetails();
            Auto3.DisplayDetails();
            Console.ReadKey();
        }
    }
}

