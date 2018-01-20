using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBinaryTriangle
{
    class Program
    {

        /*
        Write a program which takes input as integer and display the binary triangle on the basis of input integer.

        Example:
        1.If user gives input 5 then the binary triangle should be like this :
        1
        01
        010
        1010
        10101
         */

        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size:");
            size = int.Parse(Console.ReadLine());

            int tempInt = 0;

            for (int i = 1; i <= size; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    if(tempInt == 0)
                    {
                        Console.Write("1");
                        tempInt = 1;
                    }
                    else if (tempInt == 1)
                    {
                        Console.Write("0");
                        tempInt = 0;
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine("Triangle Size " + size + " is:");
        }
    }
}
