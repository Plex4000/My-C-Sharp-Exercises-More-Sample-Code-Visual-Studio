using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Method

            Console.WriteLine("Input the first number: ");
            int firstNumber;
            Int32.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Input the first number: ");
            int secondNumber;
            Int32.TryParse(Console.ReadLine(), out secondNumber);

            int fnumholder = firstNumber;

            int snumholder = secondNumber;

            firstNumber = snumholder;
            secondNumber = fnumholder;

            Console.WriteLine($"First number: {firstNumber}");
            Console.WriteLine($"Second number: {secondNumber}");

            // Second Method

            Console.WriteLine("Input the first number: ");
            int fnum;
            Int32.TryParse(Console.ReadLine(), out fnum);

            Console.WriteLine("Input the first number: ");
            int snum;
            Int32.TryParse(Console.ReadLine(), out snum);

            Console.WriteLine($"First number: {snum}");
            Console.WriteLine($"Second number: {fnum}");


        }
    }
}
