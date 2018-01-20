using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please enter a number: ");

            string input = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //char j = input[i];
                int j;
                Int32.TryParse(input[i].ToString(), out j);
                sum = sum + j;
            }

            Console.WriteLine(sum);
        }
    }
}
