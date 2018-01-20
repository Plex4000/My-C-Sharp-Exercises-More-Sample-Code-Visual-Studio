using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbyValueAndRef
{
    class Program
    {
        static StringBuilder Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
           return fooSB;
        }

        static void Foo2(StringBuilder sb2)
        {
            sb2.Append("testing again");
            sb2 = null;
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            var f = Foo(sb);
           // Foo(sb);
            Console.WriteLine(sb.ToString());

            StringBuilder sb2 = sb;
            //sb2 = null;
            Foo2(sb2);
            Console.WriteLine(sb.ToString());
            //Console.WriteLine(sb2.ToString());

            //System.Text.StringBuilder sb = null;
            //string s = sb?.ToString(); // No error; s is null
            //Console.WriteLine(s);
          
        }
    }
}
