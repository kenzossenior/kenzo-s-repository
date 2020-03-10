using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pet1 = new Animal("spot", "dog", 3);
            Animal pet2 = new Animal("meg","cat",1);


            Console.WriteLine($" {pet1.name} {pet1.species} {pet1.weight} ");
            Console.WriteLine($" {pet2.name} {pet2.species} {pet2.weight} ");

            Console.ReadKey();


        }
    }
}
