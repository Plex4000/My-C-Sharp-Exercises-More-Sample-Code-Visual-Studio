using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Parameters
{
    class Program
    {
        public static void CalculateBMI(ref float height, float weight, out float bmi)
        {
            bmi = 703 * weight / (height * height);
            height = height + 10;
        }

        //Optional Parameters

        public static void PrintInfo(int age, string name = "James")
        {
            Console.WriteLine($"My name is {name} and I'm {age} years old.");
        }

        //Varying length Params parameter

        public static void ProcessInfo(params string[] names)
        {
            foreach (var name in names)
            {
            
                Console.WriteLine(name);
            } 
        }

        static void Main(string[] args)
        {
            float bmi;
            float height = 68.0F;
            float weight = 120.0F;

            CalculateBMI(ref height, weight, out bmi);

            Console.WriteLine(bmi);
            Console.WriteLine(height);

            PrintInfo(45);

            string[] names = { "James", "David", "Robert" };

            ProcessInfo(names);

        }
    }
}
