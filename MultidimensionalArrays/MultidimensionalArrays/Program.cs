using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //This is a Multidimensional Rectanglular array
            int[,] mArray = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };

            try
            {
                Console.Write("Please enter a value for the rectangular array: ");
                int input;
                input = Int32.Parse(Console.ReadLine());
                Console.WriteLine(mArray[0,input]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }


            //This is a Multidimensional Jagged array
            int[][] matrix = new int[][]
            {
            new int[] {0,2,2},
            new int[] {3,4,5},
            new int[] {6,7,8,9}
            };

            try
            {
                Console.Write("Please enter a value for the jagged array: ");
                int input;
                input = Int32.Parse(Console.ReadLine());
                Console.WriteLine(mArray[0, input]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }


        }
    }
}
