using System;

namespace EqualityComparison
{
    class Program
    {
        public class test
        {

        }
        static void Main(string[] args)
        {
            test x = null;
            test y = new test();

            object a = 3;
            object b = 3;

            int c = 3;
            int d = 4;

            Console.WriteLine($"x == y {x == y}");
            Console.WriteLine($"a == b {a == b}");
            Console.WriteLine($"c == d {c == d}");

            Console.WriteLine($"Equals x,y {x.Equals(y)}");
            Console.WriteLine($"Equals a,b {a.Equals(b)}");
            Console.WriteLine($"Equals c,d {c.Equals(d)}");

            Console.WriteLine($"Ojbect reference equals a,b {object.ReferenceEquals(a, b)}");
        }
    }
}
