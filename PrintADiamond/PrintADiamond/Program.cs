using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADiamond
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please enter an odd number: ");

            int rows;
            Int32.TryParse(Console.ReadLine(), out rows);

            int iRows = rows / 2 + 1;
            int count = rows/2;

            for (int i = 1; i <= iRows ; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write("-");
                }
                count--;
                for (int k = 1; k <= (2 * i) - 1; k++)
                {
                   
                    Console.Write("X");
                }

                Console.WriteLine();
            }

            count = 1;
            for (int i = rows / 2; i >= 1  ; i--)
            {
                for (int k = 1 ; k <= count; k++)
                {
                    Console.Write("-");
                }
                count++;
              
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
        }
    }
}
