using System;
using System.Collections;

namespace PolymorphismViaInterfaces
{
    public interface Itest
    {
        void Talk();
    }
    public class Test1 : Itest
    {
        public void Talk()
        {
            Console.WriteLine("I'm talking! :)");
        }
    }

    public class Test2 : Itest
    {
        public void Talk()
        {
            Console.WriteLine("I'm talking 2! :)");
        }
    }
    class Program
    {



        static void Main(string[] args)
        {
            var list = new ArrayList();

            Itest test1 = new Test1();
            Itest test2 = new Test2();

            var list2 = new Itest[] { test1, test2 }; // can also crate arrays of interface objects

            list.Add(new Test1());
            list.Add(new Test2());

            foreach (Itest item in list)
            {
                item.Talk();
            }
        }
    }
}
