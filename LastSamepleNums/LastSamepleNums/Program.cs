using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSamepleNums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which takes two integers N and M and produces last samples of N of the integers from N-1 to N-M.


            Console.Write("please enter a number: ");

            int num1;
            Int32.TryParse(Console.ReadLine(), out num1);


            Console.Write("please enter another number: ");

            int num2;
            Int32.TryParse(Console.ReadLine(), out num2);

            string answer = "";

            for (int i = num1 - 1; i >= num1 - num2; i--)
            {
                answer += i + " ";
            }

            Console.WriteLine($"the last {num2} digits of {num1} are: {answer}");
        }

    }
}
