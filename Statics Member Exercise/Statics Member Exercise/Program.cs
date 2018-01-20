using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics_Member_Exercise
{
    //A class declared as static must contain only static fields and methods 
   static class TestClass1
    {
        public static int age = 45;

        public static int GetAge()
        {
            return age;
        }

    }

    //A class with static and non-static members coexisting with each other
    class TestClass2
    {
        public static int heightInInches = 68;

        public int GetHeight()
        {
            return heightInInches;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TestClass1.GetAge() + " years old");
            Console.WriteLine(new TestClass2().GetHeight() + " inches in height");

        }
    }
}
