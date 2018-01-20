using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Cooresponding_Array_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array1: [1, 3, -5, 4]");
            Console.WriteLine("Array2: [1, 4, -5, -2] \n");

            Console.WriteLine("The multiplication output of the cooresponding numbers in the arrays are:");

            int[] array1 = { 1, 3, -5, 4};
            int[] array2 = { 1, 4, -5, -2};

            for (int i = 0; i < 4; i++)
            {
                Console.Write(array1[i] * array2[i] + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
