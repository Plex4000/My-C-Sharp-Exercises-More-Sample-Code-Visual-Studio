using System;
using System.Threading;

namespace triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of rows for this pattern :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', 2 * i + 1));
                //for (int j = 1; j <= 2 * i + 1; j++)
                //    Console.Write("*");
                Console.Write("\n");
            }

        }
    }
}
