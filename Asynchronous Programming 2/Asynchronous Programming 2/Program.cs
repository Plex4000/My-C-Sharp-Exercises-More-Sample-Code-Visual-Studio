using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming_2
{
    class Program
    {
        public static async Task PrintAnswerToLife() // We can return Task instead of void
        {
            await Task.Delay(5000);
            int answer = 21 * 2;
            Console.WriteLine(answer);
        }
        static void Main(string[] args)
        {
            Task task = PrintAnswerToLife();
            task.Wait();
            Console.WriteLine("fdsfds");
        }
    }
}
