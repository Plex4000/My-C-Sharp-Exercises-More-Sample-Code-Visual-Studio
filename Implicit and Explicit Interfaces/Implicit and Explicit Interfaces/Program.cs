using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_Interfaces
{
    interface IDoggy
    {
        void Talk();
    }

    interface IKitty
    {
        void Talk();
    }
    public class Dog : IDoggy
    {
        public int Age { get; set; }

        public void Talk()
        {
            Console.WriteLine("I'm a dog.");
        }
    }

    public class Cat : IDoggy, IKitty
    {
     

        void IKitty.Talk()
        {
            Console.WriteLine("Cat from kitty interface.");
        }

        void IDoggy.Talk()
        {
            Console.WriteLine("Cat from doggy interface.");
        }
    }

    public 

    class Program
    {
        static void Main(string[] args)
        {
            //calling the implicitly implemented interface method on the dog class
            Dog dog = new Dog();
            dog.Talk();
            
            //calling the explictly implemented interface method of the Cat class
            IKitty cat = new Cat();
            cat.Talk();

          
        }
    }
}
