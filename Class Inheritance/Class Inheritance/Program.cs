using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance
{
    class Animal
    {
        public int Age { get; set; }

        public virtual void Talk()
        {
            Console.WriteLine("I'm an animal.");
        }
    }

    class Dog : Animal
    {
  
        public override void Talk()
        {
            Console.WriteLine("RUFF RUFF!");
        }
    }

    class Cat : Animal
    {

        public override void Talk()
        {
            Console.WriteLine("MEOW! MEOW!");
        }
    }

    class A
    {
        public void m()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public new void m()
        {
            Console.WriteLine("B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //polymorphism also illustrated here
            Animal dog = new Dog();
            dog.Talk();

            Animal cat = new Cat();
            cat.Talk();

            A a = new B();
            a.m();

        }
    }
}
