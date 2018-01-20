using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class fdsfdsfsdafdafd
    {
        public static int MultiplyBy(this int value, int mulitiplier)
        {
            // Uses a second parameter after the instance parameter.
            return value * mulitiplier;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int result = 10.MultiplyBy(2).MultiplyBy(2);
            Console.WriteLine(result);
        }
    }
}
