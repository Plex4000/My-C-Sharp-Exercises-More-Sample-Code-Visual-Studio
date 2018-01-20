using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            Console.WriteLine("Number of elements in Queue: {0}", queue.Count);

            foreach (var i in queue)
                Console.WriteLine(i);
        }
    }
}
