using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNotIsNullOrEmpty
{
    class Program
    {
        static void Main(string[] args)
        {

            string test = "fdsa";

            if (!string.IsNullOrEmpty(test))
            {
                Console.WriteLine(!string.IsNullOrEmpty(test));
            }
        }
    }
}
