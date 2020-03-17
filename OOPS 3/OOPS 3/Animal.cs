using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_3
{
    class Animal
    {
        // variables
        private string name;
        private string gender;

        public string Name { get { return this.name; } }
        public string Gender { get { return this.gender; } }

        public Animal(string name)
        {
            SetGender();
            NameAnimal(name);
        }

        public Animal()
        {
            SetGender();
        }

        public void NameAnimal(string name)
        {
            this.name = name;
        }

        virtual public string makeNoise()
        {
            return "Gurgle";
        }

        public void SetGender()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            if (rnd.Next(0, 2) == 0)
            {
                this.gender = "male";
            }
            else { this.gender = "female"; }
        }

    }

    class Dog : Animal
    {
        public Dog()
            : base()
        { }

        public Dog(string name)
                   : base(name)
        { }

        override public string makeNoise()
        {
            return "woof";
        }
    }

    class Cat : Animal
    {
        public Cat()
            : base()
        { }

        public Cat(string name)
           : base(name)
        { }
        override public string makeNoise()
        {
            return "meow";
        }
        public string nameAnimal()
        {
            Console.WriteLine("What is the name of your dog?");
            this.name = Console.ReadLine();
            return this.name;
        }
    }
}
