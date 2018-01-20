using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapFirstAndLastLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please enter a series of numbers separated by spaces: ");

            string input = Console.ReadLine();
            bool isOdd = false;
            Nullable<int> oddNum = null;

            for (int i = 0; i < input.Length; i++)
            {
                int num;
                Int32.TryParse(input[i].ToString(), out num);
                if (num % 2 != 0) { isOdd = true; oddNum = num;  break; }
            }

            if (isOdd) { Console.WriteLine($"There is an odd number in your series which is {oddNum}!"); }
            else
            {
                Console.WriteLine("There are no odd numbers in the series!");
            }

            //int[][] array = new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 } };
            //for (int j = 0; j < array.Length; j += 1)
            //{
            //    for (int k = 0; k < array[j].Length; k += 1)
            //    {
            //        Console.Write(array[j][k]);
            //    }
            //}

        }
    }
}
