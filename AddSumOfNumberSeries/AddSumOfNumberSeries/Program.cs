using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSumOfNumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            do
            {
                Console.Write("Please enter a number: ");
                Int64.TryParse(Console.ReadLine(), out number);
            } while (number == 0);

            int total = 0;
            for (int i = 0; i <= number; i++)
            {
                total = total + i;
            }

            Console.WriteLine($"The total is: {total}");
        }
    }
}
