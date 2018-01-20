using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    interface IAnimal
    {
        string Talk();
    }
    abstract class Animal
    {
        int age;
        public virtual string Talk()
        {
            return "Raj";
        }
    }

    class dog : Animal, IAnimal
    {
        int age;
        public override string Talk()
        {
            return "Bark";
        }       
    }

    class cat : Animal, IAnimal
    {
        int age;
        public override string Talk()
        {
            return "Meow";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal kitty = new cat();

            Console.WriteLine(kitty.Talk());

        }
    }
}
