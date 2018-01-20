using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number or letter to print: ");
            string num = Console.ReadLine();

            while(num.Length != 1)
            {
                Console.Write("Please enter only 1 number or letter: ");
                num = Console.ReadLine();
            }
        
            Console.Write("How many digits long should the base be?: ");
            int baseLength;

            while(!int.TryParse(Console.ReadLine(), out baseLength))
            {
                Console.Write("Please enter only numbers: ");
            }

            for (int i = 1; i <= baseLength; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine("");
            }
        }
    }
}
