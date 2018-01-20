using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    class Program
    {
        public delegate void Print(int value);
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

        static void Main(string[] args)
        {
            Print print = delegate (int val) {
                Console.WriteLine($"Inside Anonymous method. Value: {val}");
            };

            print(100);

            //Anonymous methods can be passed as parameters to a method
            PrintHelperMethod(delegate (int val) { Console.WriteLine($"Anonymous method: {val}"); }, 100);
        }
    }
}
