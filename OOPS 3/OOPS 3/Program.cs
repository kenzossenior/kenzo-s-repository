using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_3
{
    class Program
    {
        static void Main(string[] args)
        {
            OG();
            Console.ReadKey();

        }

        public static void OG()
        {
            Animal pet1 = new Animal("Tim");
            Dog pet2 = new Dog("Jim");
            Cat pet3 = new Cat("Nib");

            Console.WriteLine(pet1.Name);
            Console.WriteLine(pet1.makeNoise());
            Console.WriteLine(pet1.Gender);
            Console.WriteLine();

            Console.WriteLine(pet2.Name);
            Console.WriteLine(pet2.makeNoise());
            Console.WriteLine(pet2.Gender);
            Console.WriteLine();

            Console.WriteLine(pet3.Name);
            Console.WriteLine(pet3.makeNoise());
            Console.WriteLine(pet3.Gender);
            Console.WriteLine();
        }

        //public static void ArraysNthatX()
        //{
        //    Animal pets = new Animal[5];
        //}
    }
}
