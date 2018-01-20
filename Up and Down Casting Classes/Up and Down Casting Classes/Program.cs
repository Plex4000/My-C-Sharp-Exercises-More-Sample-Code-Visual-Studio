using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_and_Down_Casting_Classes
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }

    public class Dog : Animal
    {
        public string Breed { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //implicit upcasting
            Animal animal = new Dog();

            //explicit downcasting
            Dog dog = (Dog)animal;
            
        }
    }
}
