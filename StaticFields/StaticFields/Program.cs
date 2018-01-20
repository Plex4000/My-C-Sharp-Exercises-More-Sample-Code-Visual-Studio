using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFields
{
    class Program
    {

        static int j = 20;
        static void Main(string[] args)
        {
            int j = 54;
            Console.WriteLine("Local scope int: " + j); // outputs local variable j which is 54

            PrintStaticInt();
        }

        static public void PrintStaticInt()
        {
            j = 21;
            Console.WriteLine("Static int: " + j); // outputs static field j which is now 21
        }
    }
}
