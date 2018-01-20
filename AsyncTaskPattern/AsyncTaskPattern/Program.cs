using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskPattern
{
    class Program
    {
        static Task<string> GreetingAsync(string name)
        {
            return Task.Run<string>(() =>
            {
                return Greeting(name);
            });
        }

        static string Greeting(string name)
        {
            Task.Delay(3000).Wait();
            return $"Hello, {name}";
        }

        private async static void CallerWithAsync()
        {
            string result = await GreetingAsync("Stephanie");
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            CallerWithAsync();
        }
    }
}
