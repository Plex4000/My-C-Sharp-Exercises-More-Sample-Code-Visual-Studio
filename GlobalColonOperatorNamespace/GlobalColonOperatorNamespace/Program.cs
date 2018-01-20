using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Foo
{
    public void baz()
    {
        Console.WriteLine("Foo 1");
    }

  
}

namespace GlobalColonOperatorNamespace
{
    class Foo
    {
        public void baz()
        {
            Console.WriteLine("Foo 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            global::Foo foo1 = new global::Foo();
            Foo foo2 = new Foo();
            foo1.baz();
            foo2.baz();
        }
    }
}
