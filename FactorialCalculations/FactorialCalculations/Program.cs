using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculations
{
    class Program
    {
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int numb;
            Int32.TryParse(Console.ReadLine(), out numb);
            Console.WriteLine($"The factorial of {numb} is: " + Factorial(numb));


        }
    }
}
