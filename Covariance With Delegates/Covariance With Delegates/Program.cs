using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_With_Delegates
{
    class Small
    {

    }
    class Big : Small
    {

    }
    class Bigger : Big
    {

    }
    class Program
    {
        public delegate Small covarDel(Big mc);
        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

        static void Main(string[] args)
        {
            covarDel del = Method1;

            Small sm = del(new Big());
        }
     
    }
}
