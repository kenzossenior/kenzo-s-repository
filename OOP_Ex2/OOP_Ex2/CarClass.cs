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

        public Car(string make, string model, int mileage,string colour, int age)
        {
            this.make = make;
            this.model = model;
            this.mileage = mileage;
            this.colour = colour;
            this.age = age;
        }
        public DisplayDetails()
        {

        }

        public ChangeMileage()
        {

        }
    }
}
