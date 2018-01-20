using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    public class MyClass
    {
        int age;
        int heightInInches;
        public MyClass(int age)
        {
            Console.WriteLine("I'm the first constructor that is called");
        }

        public MyClass(int age, int height) : this(age)
        {
            this.age = age;
            this.heightInInches = height;
            Console.WriteLine("I'm the second constructor that is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass(45, 68);


        }
    }
}
