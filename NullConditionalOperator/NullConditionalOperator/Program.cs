using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = null;
            string s = sb?.ToString(); // No error; s instead evaluates to null
        }
    }
}
