using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes input length and width of rectangle as integer and print the rectangle.


            Console.Write("please enter the width of the rectangle: ");

            int num1;
            Int32.TryParse(Console.ReadLine(), out num1);

            Console.Write("please enter the height of the rectangle: ");

            int num2;
            Int32.TryParse(Console.ReadLine(), out num2);

            for (int i = 1; i <= num1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int k = 1; k <= num2 - 2; k++)
            {
                for (int l = 1; l <= num1; l++)
                {
                    if(l == 1 || l == num1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

            for (int j = 1; j <= num1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();


        }
    }
}
