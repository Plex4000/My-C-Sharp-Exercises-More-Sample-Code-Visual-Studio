using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_New_Virtual_Keywords
{
    public abstract class Animal
    {
        int age;

        public virtual void Talk()
        {
            Console.WriteLine("I'm an Animal!");
        }
    }

    
    public class Dog : Animal
    {
        int age;

        //This Talk method hides the Talk method in the Animal class
        public new void Talk()
        {
            Console.WriteLine("I'm an dog!");
        }

    }

    public class Cat : Animal
    {
        int age;

        //This Talk method overrides the Talk method in the Animal class
        public override void Talk()
        {
            Console.WriteLine("I'm an cat!");
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Dog dog1 = new Dog();
            Animal dog2 = new Dog();

            dog1.Talk();
            dog2.Talk();
            cat.Talk();
           

        }
    }
}
