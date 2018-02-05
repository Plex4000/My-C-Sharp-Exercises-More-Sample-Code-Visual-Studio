using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIEnumerableArray
{
    public delegate void ProgressReporter(int percentComplete);
    class Program
    {
        //public static void PrintForeach(IEnumerable<int> array)
        //{ 
        //    /*
            
        //    Length property not available in IEnumerable<int> Interface

        //    int length = array.Length; // Compile time error
            
        //     */

        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        static void Main(string[] args)
        {
           // int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
           //
            //PrintForeach(array);

            X x = new X();
            ProgressReporter p = x.InstanceProgress;
            p(99); // 99
            Console.WriteLine(p.Target); // True
            Console.WriteLine(p.Method);
        }

        class X
        {
            public void InstanceProgress(int percentComplete)
            => Console.WriteLine(percentComplete);
        }
    }
}
