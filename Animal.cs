using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public abstract class Animal
    {
        public string NameAnimal;

        // Default constructor
        public Animal()
        {
            Console.WriteLine("Animal");
        }

        public Animal(string sName)
        {
            this.NameAnimal = sName;
            Console.WriteLine("Print Name: ###");
        }

        // virtual for Polymorphism of child class
        public virtual void Move()
        {
            Console.WriteLine(">>>Move<<<");
        }

        public void Sleep()
        {
            Console.WriteLine(">>Sleep<<");
            Console.WriteLine(">>Sleep<<");
            Console.WriteLine(">>Sleep<<");
            Console.WriteLine(">>Sleep<<");
            Console.WriteLine(">>Sleep<<");
            Console.WriteLine(">>Sleep<<");
        }

    }
}
