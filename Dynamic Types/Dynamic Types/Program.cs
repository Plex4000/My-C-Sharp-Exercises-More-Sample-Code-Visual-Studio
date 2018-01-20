using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Types
{
    class Program
    {
        static void PrintValue(dynamic val)
        {
            Console.WriteLine(val);
        }

        static void Main(string[] args)
        {

            PrintValue("Hello World!!");
            PrintValue(100);
            PrintValue(100.50);
            PrintValue(true);
            PrintValue(DateTime.Now);
        }
    }
}
