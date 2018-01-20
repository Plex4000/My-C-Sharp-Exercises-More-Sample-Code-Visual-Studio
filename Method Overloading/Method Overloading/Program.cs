using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        public static void PrintInfo(string name)
        {
            Console.WriteLine($"My name is {name}");
        }

        public static void PrintInfo(string name, int age)
        {
            Console.WriteLine($"My name is {name} and I'm {age} years old");
        }
        static void Main(string[] args)
        {
            PrintInfo("James");
            PrintInfo("James", 30);
        }
    }
}
