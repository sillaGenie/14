using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat("Мурка");
            cat.ShowInfo();
            Dog dog = new Dog("Боб");
            dog.ShowInfo();

        }
    }
    abstract class Animal
    {
        public Animal(string n = "животное")
        {
            n = Name;
        }
        public abstract string Name { get; set; }

        abstract public void Say();
        public virtual void ShowInfo()
        {
        Console.WriteLine("Name: " + Name);
        Say();
          }

    }

     class Cat : Animal
    {
       string name;
       public Cat(string name)
       {
        Name = name;
        
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Мяу ");
        }

    }
    class Dog : Animal
    {
        string name;
        public Dog(string name)
        {
            Name = name;

        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}