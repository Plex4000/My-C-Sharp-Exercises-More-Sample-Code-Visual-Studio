using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareEqualsVSEqualsOperator
{
    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Test s = t;

            Console.WriteLine(s == t);
            Console.WriteLine(s.Equals(t));

            string h = "home";
            string l = h;

            h = "library";

            Console.WriteLine(h == l);
            Console.WriteLine(h.Equals(l));
        }
    }
}
