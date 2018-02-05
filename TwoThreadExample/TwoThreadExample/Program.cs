using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TwoThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = new Thread(WriteY); // Kick off a new thread
            //t.Start(); // running WriteY()
            //           // Simultaneously, do something on the main thread.
            //for (int i = 0; i < 1000; i++) Console.Write("x");

            //WriteY();
             Task task = Task.Factory.StartNew(() => Console.WriteLine("Foo"));
            //task.Wait();
            Task t2 = Task.Factory.StartNew(() => { for (int i = 0; i < 1000000; i++) Console.Write("x"); });
            //t2.Wait();
             Task t3 = Task.Factory.StartNew(() => { for (int i = 0; i < 1000000; i++) Console.Write("y"); });
            //t3.Wait();

            //Task<int> primeNumberTask = Task.Run(() =>
            //                    Enumerable.Range(2, 3000000).Count(n =>
            //                    Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
            //                    Console.WriteLine("Task running...");
            //                    Console.WriteLine("The answer is " + primeNumberTask.Result);
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
