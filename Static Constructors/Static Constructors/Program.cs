using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructors
{
    class Program
    {
        public class MyClass
        {
            static MyClass()
            {
                Console.WriteLine("From a static constructor!");
            }
        }
        static void Main(string[] args)
        {
            //the static MyClass Constructor is called only once when line 21 is executed. Subsequent calls to the constructor are omitted.
            MyClass myclass = new MyClass();
            MyClass newClass = new MyClass();
        }
    }
}
