using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOrSubtractFromInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");

            int num1;
            Int32.TryParse(Console.ReadLine(), out num1);

            Console.Write("please enter another number: ");

            int num2;
            Int32.TryParse(Console.ReadLine(), out num2);

            Console.Write("type '+' for adding and '-' for subtracting: ");

            string opp = Console.ReadLine();

            if (opp == "+")
            {
                Console.WriteLine($"Adding the two numbers will be: {num1 + num2}");
            }

            if (opp == "-")
            {
                Console.WriteLine($"subtracting the two numbers will be: {num1 - num2}");
            }
        }
    }
}
