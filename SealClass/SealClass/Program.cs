using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealClass
{
    sealed public class Test
    {

    }

    public class B : Test //sealed classes cannot be inherited
    {


    }


    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(); // Sealed classes can be instantiated
        }
    }
}
