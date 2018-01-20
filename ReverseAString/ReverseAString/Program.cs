using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
           
            string reverseString = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reverseString +=  words[i] + " ";
            }

            Console.Write("the entered string in reverse order is: " + reverseString);
            Console.WriteLine();
        }


    }
}
