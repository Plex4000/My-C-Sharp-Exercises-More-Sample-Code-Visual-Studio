using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");

            int num1;
            Int32.TryParse(Console.ReadLine(), out num1);


            Console.Write("please enter a number: ");

            int num2;
            Int32.TryParse(Console.ReadLine(), out num2);

            int a = num1;
            int b = num2;

            int temp = num2;

            b = num1;

            a = temp;

            Console.WriteLine($"The nums swaped are: {a} and {b}");
        }
    }
}
