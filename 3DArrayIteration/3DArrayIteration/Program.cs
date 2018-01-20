using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DArrayIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9} ,{ 10, 11, 12 } } };

            int[][] jaggedArray2 = new int[][]
{
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
};

            //print all elements in the multidimentional array

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine(array[i,j,k]);
                      
                    }
                }
            }

            // Print out all elements in the jagged array.
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int a = 0; a < jaggedArray2[i].Length; a++)
                {
                    Console.Write(jaggedArray2[i][a] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
