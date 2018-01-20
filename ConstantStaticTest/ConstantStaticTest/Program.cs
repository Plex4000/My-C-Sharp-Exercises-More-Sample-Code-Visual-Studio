using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantStaticTest
{
    class test
    {

    }
    class Program
    {

        public const int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(Program.count); //this proves that const values are static by default
        }
    }
}
