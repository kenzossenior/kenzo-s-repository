using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex2
{
    class CarClass
    {
        private string make;
        private string model;
        private int mileage;
        private string colour;
        private int age;

        public CarClass(string make, string model, int mileage, string colour, int age)
        {
            this.make = make;
            this.model = model;
            this.mileage = mileage;
            this.colour = colour;
            this.age = age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"{this.make}, {this.model}, {this.mileage}, {this.colour} {this.age} ");
        }

        public void ChangeMileage()
        {

            Console.WriteLine("Do you want to change mileage for this vehicle? (Yes or No)");
            string input = Console.ReadLine();
            while(input != "Yes" && input != "No")
            {
                Console.WriteLine("Invalid entry, re enter");
                input = Console.ReadLine();
            }
            if (input == "Yes")
            {
                Console.WriteLine("input Mileage");
                int.TryParse(Console.ReadLine(), out this.mileage);
                while(this.mileage < 0 || this.mileage > 1000000)
                {
                    Console.WriteLine("Invalid entry, input Mileage");
                    int.TryParse(Console.ReadLine(), out this.mileage);
                }
            }
        }


    }
}
