using System;
using System.Collections.Generic;

namespace PassingMethodsAsParameters
{
    class Program
    {
        public int Method1(string input)
        {
            //... do something
            return 0;
        }

        public int Method2(string input)
        {
            //... do something different
            return 1;
        }

        public bool RunTheMethod(Func<string, int> myMethodName)
        {
            //... do stuff
            int i = myMethodName("My String");
            //... do more stuff
            return true;
        }

        public bool Test()
        {
            return RunTheMethod(Method1);
        }

        public static void Main()
        {
            Program p = new Program();
            Console.WriteLine(p.Test());
        }
    }
}
