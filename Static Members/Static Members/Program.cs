using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{
    class Program
    {
        static public int Age { get; set; } = 45;

        static Program()
        {

        }

        static public void PrintIfno()
        {
            Console.WriteLine(Age);

        }
        static void Main(string[] args)
        {
            PrintIfno();
        }
    }
}
