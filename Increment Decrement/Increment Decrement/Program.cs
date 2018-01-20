using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            for (int n = 0; n < 100; n++)
            {
                i = i++;
            }
            Console.WriteLine(i);
        }
    }
}
