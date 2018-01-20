using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_Casting
{
    public struct Point { public int X; public int Y; }
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 1234545543; // int is a 32-bit integer

            long y = x; // Implicit conversion to 64-bit integer i.e. converting a smaller int type to a larger int type

            Console.WriteLine(y);

            short z = (short)x; // Explicit conversion to 16-bit integer i.e. going from a larger int type to a smaller int type. loss of infomation occurs resulting in information overflow

            Console.WriteLine(z); //displays a negative number as output indicating loss of information and overflow
            int u = 0;
            Console.WriteLine(u++); // Outputs 0; x is now 1
            Console.WriteLine(++u); // Outputs 2; x is now 2
            Console.WriteLine(--u); // Outputs 1; x is now 1
        }
    }
}
