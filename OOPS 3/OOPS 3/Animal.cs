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

        public string Name { get { return this.name;  } set { this.name = value; } }
        public string Gender { get { return this.gender; } set { } }

        public Animal(string name)
        {
            SetGender();
            NameAnimal(name);
        }

        public Animal()
        {
            //NameAnimal();
            SetGender();
        }

        public void NameAnimal(string name)
        {
            this.name = name;
        }

         virtual public void NameAnimal()
        {
            Console.WriteLine("What is the name of your animal?");
            this.Name = Console.ReadLine();
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

        new public void NameAnimal()
        {
            Console.WriteLine("What is the name of your dog?");
            this.Name = Console.ReadLine();
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

        new public void NameAnimal()
        {
            Console.WriteLine("What is the name of your cat?");
            this.Name = Console.ReadLine();
        }
    }
}